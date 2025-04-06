using GerenciadorGastos.DAL.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace GerenciadorGastos.DAL
{
    public class PessoaDAL
    {
        public List<Pessoa> ObterPessoas()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

            List<Pessoa> pessoas = new List<Pessoa>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT pessoa_id, pessoa_nome, data_cadastro FROM Pessoa;";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pessoa pessoa = new Pessoa
                            {
                                PessoaId = reader.GetInt32(reader.GetOrdinal("pessoa_id")),
                                PessoaNome = reader.GetString(reader.GetOrdinal("pessoa_nome")),
                                DataCadastroPessoa = reader.GetDateTime(reader.GetOrdinal("data_cadastro"))
                            };

                            pessoas.Add(pessoa);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return pessoas;
        }

        public List<PessoaItem> ObterPessoasTerceirasComItens()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

            List<PessoaItem> pessoas = new List<PessoaItem>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT psa.pessoa_nome,item.nome_item, item.valor_item, item.data_cadastro, item.pago FROM Item AS item JOIN Pessoa AS psa ON item.pessoa_id = psa.pessoa_id WHERE item.pessoa_id != 1 ORDER BY item.data_cadastro DESC";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PessoaItem pessoa = new PessoaItem
                            {
                                PessoaNome = reader.GetString(reader.GetOrdinal("pessoa_nome")),
                                NomeItem = reader.GetString(reader.GetOrdinal("nome_item")),
                                ValorItem = reader.GetDecimal(reader.GetOrdinal("valor_item")),
                                DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro")),
                                Pago = reader.GetBoolean(reader.GetOrdinal("pago"))
                            };

                            pessoas.Add(pessoa);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return pessoas;
        }

        public List<Pessoa> ObterPessoasTerceiras()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

            List<Pessoa> pessoas = new List<Pessoa>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT pessoa_id, pessoa_nome, data_cadastro FROM Pessoa WHERE pessoa_id != 1;";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pessoa pessoa = new Pessoa
                            {
                                PessoaId = reader.GetInt32(reader.GetOrdinal("pessoa_id")),
                                PessoaNome = reader.GetString(reader.GetOrdinal("pessoa_nome")),
                                DataCadastroPessoa = reader.GetDateTime(reader.GetOrdinal("data_cadastro"))
                            };

                            pessoas.Add(pessoa);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return pessoas;
        }

        public void AdicionarPessoa(string nomePessoa)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Pessoa(pessoa_nome, data_cadastro) VALUES (@nomePessoa, GetDate());";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nomePessoa", nomePessoa);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }

        public void DeletarPessoa(int pessoaId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryItem = "DELETE FROM Item WHERE pessoa_id = @pessoaId";
                string queryPessoa = "DELETE FROM Pessoa WHERE pessoa_id = @pessoaId";

                try
                {
                    SqlCommand commandItem = new SqlCommand(queryItem, connection);
                    commandItem.Parameters.AddWithValue("@pessoaId", pessoaId);
                    commandItem.ExecuteNonQuery();

                    SqlCommand commandPessoa = new SqlCommand(queryPessoa, connection);
                    commandPessoa.Parameters.AddWithValue("pessoaId", pessoaId);
                    commandPessoa.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new Exception("Ocorreu um erro ao excluir um pessa", ex);
                }
            }
        }

        public void EditarPessoa(int pessoaId, string nome)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Pessoa SET pessoa_nome = @nome WHERE pessoa_id = @pessoaId";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@nome", nome);
                sqlCommand.Parameters.AddWithValue("@pessoaId", pessoaId);

                try
                {
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();   
                }
                catch (Exception ex)
                {

                    throw new Exception($"Ocorreu um erro ao editar um tercerio: {ex.Message}");
                }
            }
        }
    }
}
