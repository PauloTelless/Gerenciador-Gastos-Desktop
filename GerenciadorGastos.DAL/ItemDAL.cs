using GerenciadorGastos.DAL.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace GerenciadorGastos.DAL
{
    public class ItemDAL
    {
        public List<Item> ObterItens(DateTime data)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();
            List<Item> itens = new List<Item>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT ite.*, 
       psa.pessoa_nome 
FROM Item ite 
JOIN Pessoa psa  
ON ite.pessoa_id = psa.pessoa_id 
WHERE CAST(ite.data_cadastro AS DATE) = @data;
";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@data", data.Date);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Item item = new Item
                            {
                                ItemId = reader.GetInt32(reader.GetOrdinal("item_id")),
                                NomeItem = reader.GetString(reader.GetOrdinal("nome_item")),
                                ValorItem = reader.GetDecimal(reader.GetOrdinal("valor_item")),
                                DataCadastroItem = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                                PessoaNome = reader.GetString(reader.GetOrdinal("pessoa_nome")),
                                PessoaId = reader.GetInt32(reader.GetOrdinal("pessoa_id"))
                            };

                            itens.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao acessar banco de dados: " + ex.Message);
                }
            }

            return itens;
        }

        public void AdicionarItem(Item item)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Item (nome_item, data_cadastro,valor_item, pessoa_id) " +
                               "VALUES (@NomeItem, @DataCadastroItem, @ValorItem,@PessoaId);";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@NomeItem", item.NomeItem);
                command.Parameters.AddWithValue("@ValorItem", item.ValorItem);
                command.Parameters.AddWithValue("@DataCadastroItem", item.DataCadastroItem);
                command.Parameters.AddWithValue("@PessoaId", item.PessoaId);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao adicionar item: " + ex.Message);
                }
            }
        }

        public decimal ObterTotalGastoDia(DateTime data)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(valor_item) FROM Item WHERE CAST(data_cadastro AS DATE) = @data";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@data", data);

                try
                {
                    connection.Open();

                    var result = command.ExecuteScalar();

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
                    throw new Exception("Erro ao obter o total gasto do dia: " + ex.Message);
                }
            }
        }

        public decimal ObterSomaValorItemPorMes(int mes, int ano)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();
            decimal totalValor = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(valor_item) AS TotalValor " +
               "FROM Item " +
               "WHERE MONTH(data_cadastro) = @Mes " +
               "AND YEAR(data_cadastro) = @Ano " +
               "AND pessoa_id = 1";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Mes", mes);
                command.Parameters.AddWithValue("@Ano", ano);

                try
                {
                    connection.Open();

                    var result = command.ExecuteScalar();

                    if (result == DBNull.Value || result == null)
                    {
                        totalValor = 0;
                    }
                    else
                    {
                        totalValor = Convert.ToDecimal(result);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao obter a soma do valor_item: " + ex.Message);
                }
            }

            return totalValor;
        }

        public void DeletarItem(int item_id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Item WHERE item_id = @item_id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@item_id", item_id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao adicionar item: " + ex.Message);
                }
            }
        }

    }
}
