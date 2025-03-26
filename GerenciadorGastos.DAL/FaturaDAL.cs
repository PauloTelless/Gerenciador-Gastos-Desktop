using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Configuration;
using System.Data.SqlClient;

namespace GerenciadorGastos.DAL;

public class FaturaDAL
{
    public decimal ObterValorFatura()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT fatura_valor FROM Fatura;";
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

    public void AtualizarValorFatura(decimal novoValor)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "UPDATE Fatura SET fatura_valor = @faturaValor WHERE fatura_id = @faturaId";

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@faturaValor", novoValor);
                command.Parameters.AddWithValue("@faturaId", 1);
                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar o valor da fatura: " + ex.Message);
            }
        }
    }

}
