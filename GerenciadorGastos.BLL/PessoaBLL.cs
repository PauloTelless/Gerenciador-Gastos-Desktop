using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorGastos.DAL;
using GerenciadorGastos.DAL.Models;

namespace GerenciadorGastos.BLL
{
    public class PessoaBLL
    {
        private PessoaDAL pessoaDAL = new PessoaDAL();

        public List<Pessoa> ObterPessoas()
        {
            try
            {
                var result = pessoaDAL.ObterPessoas();

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<PessoaItem> ObterPessoaTerceira()
        {
            try
            {
                var result = pessoaDAL.ObterPessoasTerceiras();

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AdicionarPessoa(string nomePessoa)
        {
            try
            {
                pessoaDAL.AdicionarPessoa(nomePessoa);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
