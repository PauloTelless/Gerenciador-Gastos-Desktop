using GerenciadorGastos.DAL.Models;
using System.Configuration;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GerenciadorGastos.DAL
{
    public class ItemDAL
    {
        public List<Item> ObterItens(DateTime data, bool pago = false)
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

                if (pago)
                {
                    query += "AND pago = 1";
                }

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
                                Pago = reader.GetBoolean(reader.GetOrdinal("pago")),
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

        public List<Item> ObterItens(bool pago = false)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();
            List<Item> itens = new List<Item>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Item WHERE pago = 0 ORDER BY data_cadastro DESC";

                if (pago == true)
                {
                    query = @"SELECT * FROM Item WHERE pago = 1 ORDER BY data_cadastro DESC;";

                }

                SqlCommand command = new SqlCommand(query, connection);

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
                                Pago = reader.GetBoolean(reader.GetOrdinal("pago")),
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
                string query = "SELECT SUM(valor_item) FROM Item WHERE CAST(data_cadastro AS DATE) = @data AND pago = 0";

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

        public decimal ObterSomaValorItemPorMes(DateTime data)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();
            decimal totalValor = 0;

            DateTime dataInicio;
            DateTime dataFim;

            if (data.Day >= 8)
            {
                dataInicio = new DateTime(data.Year, data.Month, 8);
                dataFim = dataInicio.AddMonths(1).AddDays(-1);
            }
            else
            {
                dataInicio = new DateTime(data.Year, data.Month, 1).AddMonths(-1).AddDays(7);
                dataFim = new DateTime(data.Year, data.Month, 7);
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT SUM(valor_item) AS TotalValor 
                               FROM Item 
                               WHERE data_cadastro >= @DataInicio 
                               AND data_cadastro <= @DataFim 
                               AND pessoa_id = 1 AND pago = 0";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DataInicio", dataInicio);
                command.Parameters.AddWithValue("@DataFim", dataFim);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();

                    totalValor = result == DBNull.Value || result == null
                        ? 0
                        : Convert.ToDecimal(result);
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

        public void PagarItem(int item_id, bool retivarPagamento = false)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

            string query = @"UPDATE Item SET pago = 1 WHERE item_id = @item_id";

            if (retivarPagamento)
            {
                query = @"UPDATE Item SET pago = 0 WHERE item_id = @item_id";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@item_id", item_id);

                try
                {
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new Exception($"Ocorreu um erro ao pagar item: {ex.Message}");
                }

            }
        }

        public void PagarTodosItens()
        {
            DateTime data = DateTime.Today;
            DateTime dataInicio;
            DateTime dataFim;

            dataInicio = new DateTime(data.Year, data.Month, 8).AddMonths(-1);
            dataFim = new DateTime(data.Year, data.Month, 7);


            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

            string query = @"
        UPDATE Item 
        SET pago = 1
        WHERE data_cadastro >= @dataInicio AND data_cadastro < @dataFim";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                sqlCommand.Parameters.AddWithValue("@dataInicio", dataInicio);
                sqlCommand.Parameters.AddWithValue("@dataFim", dataFim);

                try
                {
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ocorreu um erro ao pagar todos os itens: {ex.Message}");
                }
            }
        }

    }
}
