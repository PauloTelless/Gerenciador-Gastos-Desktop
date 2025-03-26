using GerenciadorGastos.DAL.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Configuration;
using System.Data.SqlClient;

namespace GerenciadorGastos.DAL;

public class GastoFixoDAL
{
    public List<GastoFixo> ObterGastosFixo()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();
        List<GastoFixo> gastosFixo = new List<GastoFixo>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "  SELECT gasto_fixo_id, nome_gasto_fixo, CAST(data_cadastro_gasto_fixo AS DATE) AS data_cadastro_gasto_fixo, valor_gasto FROM GastoFixo;";

            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            GastoFixo gastoFixo = new GastoFixo
                            {
                                GastoFixoId = reader.GetInt32(reader.GetOrdinal("gasto_fixo_id")),
                                NomeGastoFixo = reader.GetString(reader.GetOrdinal("nome_gasto_fixo")),
                                DataCadastroGastoFixo = reader.GetDateTime(reader.GetOrdinal("data_cadastro_gasto_fixo")),
                                ValorGasto = reader.GetDecimal(reader.GetOrdinal("valor_gasto"))
                            };

                            gastosFixo.Add(gastoFixo);
                        }

                        return gastosFixo;

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao acessar banco de dados: " + ex.Message);
            }
        }

    }

    public decimal ObterValorGastosFixo()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT SUM(valor_gasto) FROM GastoFixo;";

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
                throw new Exception("Erro ao obter o valor da fatura: " + ex.Message);
            }
        }
    }

    public void AdicionarGastoFixo(GastoFixo gastoFixo)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

        string query = @"INSERT INTO GastoFixo (nome_gasto_fixo, data_cadastro_gasto_fixo, valor_gasto) VALUES (@nomeGasto, @dataCadastroGastoFixo, @valor_gasto)";


        using (SqlConnection connection = new SqlConnection(connectionString))
        {

            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nomeGasto", gastoFixo.NomeGastoFixo);
                command.Parameters.AddWithValue("@dataCadastroGastoFixo", gastoFixo.DataCadastroGastoFixo);
                command.Parameters.AddWithValue("@valor_gasto", gastoFixo.ValorGasto);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um erro: {ex.Message}");
            }

        }
    }

    public void EditarGastoFixo(GastoFixo gastoFixo)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

        string query = @"
                UPDATE GastoFixo 
                SET nome_gasto_fixo = @nomeGasto, valor_gasto = @valorGasto, data_cadastro_gasto_fixo = @dataCadastro	
                Where gasto_fixo_id = @gastoFixoId";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@nomeGasto", gastoFixo.NomeGastoFixo);
            sqlCommand.Parameters.AddWithValue("@dataCadastro", gastoFixo.DataCadastroGastoFixo);
            sqlCommand.Parameters.AddWithValue("@valorGasto", gastoFixo.ValorGasto);
            sqlCommand.Parameters.AddWithValue("@gastoFixoId", gastoFixo.GastoFixoId);

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

    public void DeletarGastoFixo(int gastoFixo)
    {

        string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

        string query = @"
                DELETE GastoFixo Where gasto_fixo_id = @gasto_fixo_id";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@gasto_fixo_id", gastoFixo);

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


