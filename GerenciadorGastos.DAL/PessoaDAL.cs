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

        public List<PessoaItem> ObterPessoasTerceiras()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnection"].ToString();

            List<PessoaItem> pessoas = new List<PessoaItem>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "  SELECT psa.pessoa_nome,item.nome_item, item.valor_item, item.data_cadastro FROM Item AS item JOIN Pessoa AS psa ON item.pessoa_id = psa.pessoa_id WHERE item.pessoa_id != 1";

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
                                DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro"))
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
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
