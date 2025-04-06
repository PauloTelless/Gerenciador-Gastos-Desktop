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
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um erro ao obter as pessoas: {ex.Message}");
            }

        }

        public List<Pessoa> ObterPessoasTerceiras()
        {
            try
            {
                var result = pessoaDAL.ObterPessoasTerceiras();

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um erro ao obter os terceiro: {ex.Message}");
            }

        }

        public List<PessoaItem> ObterPessoasTerceirasComItens()
        {
            try
            {
                var result = pessoaDAL.ObterPessoasTerceirasComItens();

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um erro ao obter os terceiro: {ex.Message}");
            }
        }

        public void AdicionarPessoa(string nomePessoa)
        {
            try
            {
                pessoaDAL.AdicionarPessoa(nomePessoa);

            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um erro ao adicionar o terceiro: {ex.Message}");
            }
        }

        public void DeletarPessoa(int pessoaId)
        {
            try
            {
                pessoaDAL.DeletarPessoa(pessoaId);

            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um erro ao deletar o terceiro: {ex.Message}");
            }
        }
    
        public void EditarPessoa(int pessoaId, string nome)
        {
            try
            {
                pessoaDAL.EditarPessoa(pessoaId, nome);
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um erro ao editar o terceiro: {ex.Message}");
            }
        }
    }
}
