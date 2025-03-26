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

        public decimal ObterGastoPorMes(int mes, int ano)
        {
            try
            {
                var result = itemDAL.ObterSomaValorItemPorMes(mes, ano);

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
            catch (Exception)
            {

                throw;
            }
        }
    }
}
