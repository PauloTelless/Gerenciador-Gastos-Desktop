using GerenciadorGastos.DAL.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace GerenciadorGastos.DAL;

public class DividaDAL
{
    public List<Divida> ObterDividas()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();
        List<Divida> dividas = new List<Divida>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT divida_id, nome_divida, data_cadastro_divida, valor_divida FROM Divida";

            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            Divida divida = new Divida
                            {
                                DividaId = reader.GetInt32(reader.GetOrdinal("divida_id")),
                                NomeDivida = reader.GetString(reader.GetOrdinal("nome_divida")),
                                DataCadastroDivida = reader.GetDateTime(reader.GetOrdinal("data_cadastro_divida")),
                                ValorDivida = reader.GetDecimal(reader.GetOrdinal("valor_divida"))
                            };

                            dividas.Add(divida);
                        }

                        return dividas;

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar banco de dados: " + ex.Message);
            }
        }

    }

    public decimal ObterValorDividas()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT SUM(valor_divida) FROM Divida;";

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter o valor da divida: " + ex.Message);
            }
        }

    }

    public void AdicionarDivida(Divida divida)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

        string query = @"INSERT INTO Divida (nome_divida, data_cadastro_divida, valor_divida) VALUES (@nomeDivida, @dataCadastroDivida, @valorDivida)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {

            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@nomeDivida", divida.NomeDivida);
            sqlCommand.Parameters.AddWithValue("@dataCadastroDivida", divida.DataCadastroDivida);
            sqlCommand.Parameters.AddWithValue("@valorDivida", divida.ValorDivida);

            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    public void EditarDivida(Divida divida)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

        string query = @"UPDATE Divida 
        SET nome_divida = @nomeDivida, 
            data_cadastro_divida = @dataCadastroDivida, 
            valor_divida = @valorDivida 
        WHERE divida_id = @dividaId
        ";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@nomeDivida", divida.NomeDivida);
            sqlCommand.Parameters.AddWithValue("@dataCadastroDivida", divida.DataCadastroDivida);
            sqlCommand.Parameters.AddWithValue("@valorDivida", divida.ValorDivida);
            sqlCommand.Parameters.AddWithValue("@dividaId", divida.DividaId);

            try
            {
                connection.Open();
                int rows = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    public void DeletarDivida(int dividaId)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

        string query = @"DELETE Divida WHERE divida_id = @dividaId;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@dividaId", dividaId);

            try
            {
                connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
