using GerenciadorGastos.DAL;
using GerenciadorGastos.DAL.Models;

namespace GerenciadorGastos.BLL
{
    public class ItemBLL
    {
        private ItemDAL itemDAL = new ItemDAL();

        public List<Item> ObterItems(DateTime data)
        {
            try
            {
                var result = itemDAL.ObterItens(data);

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Item> ObterItensPorIntervalo(DateTime data, bool pago = false)
        {
            try
            {
                var result = itemDAL.ObterItensPorIntervalo(data);

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Item> ObterItems(bool pago = false)
        {
            try
            {
                var result = itemDAL.ObterItens(pago);

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void PagarItem(int item_id, bool reativarPagamento = false)
        {
            try
            {
                itemDAL.PagarItem(item_id, reativarPagamento);
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um erro ao pagar item: {ex.Message}");
            }
        }

        public void AdicionarItem(Item item)
        {
            try
            {

                itemDAL.AdicionarItem(item);

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar item: " + ex.Message);
            }
        }

        public decimal ObterSomaValorSemanaAtual(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var result = itemDAL.ObterSomaValorSemanaAtual(dataInicio, dataFim);

                return result;  
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um erro ao obter o gasto da semana atual. {ex.Message}");
            }
        }

        public decimal ObterGastoTotalDia(DateTime data)
        {
            try
            {
                var result = itemDAL.ObterTotalGastoDia(data);

                return (decimal)result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public decimal ObterGastoPorMes(DateTime data)
        {
            try
            {
                var result = itemDAL.ObterSomaValorItemPorMes(data);

                return (decimal)result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletarItem(int item_id)
        {
            try
            {
                itemDAL.DeletarItem(item_id);
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um erro ao deletar o item: {ex.Message}");
            }
        }

        public void PagarTodosItens()
        {
            try
            {
                itemDAL.PagarTodosItens();

            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um erro ao pagar todos os itens: {ex.Message}");
            }
        }
    }
}
