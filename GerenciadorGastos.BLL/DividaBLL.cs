using GerenciadorGastos.DAL.Models;
using GerenciadorGastos.DAL;

namespace GerenciadorGastos.BLL;

public class DividaBLL
{
    DividaDAL dividaDAL = new DividaDAL();

    public List<Divida> ObterDividas()
    {
        try
        {
            var result = dividaDAL.ObterDividas();

            return result;
        }
        catch (Exception ex)
        {

            throw new Exception($"Ocorreu um erro {ex.Message}");
        }

    }

    public decimal ObterValorDividas()
    {
        try
        {
            var result = dividaDAL.ObterValorDividas();

            return result;
        }
        catch (Exception ex)
        {

            throw new Exception($"Ocorreu um erro {ex.Message}");
        }

    }

    public void AdicionarDivida(Divida divida)
    {
        try
        {
            dividaDAL.AdicionarDivida(divida);

        }
        catch (Exception ex)
        {

            throw new Exception($"Ocorreu um erro {ex.Message}");
        }
    }

    public void EditarDivida(Divida divida)
    {
        try
        {
            dividaDAL.EditarDivida(divida);
        }
        catch (Exception ex)
        {

            throw new Exception($"Ocorreu um erro {ex.Message}");
        }
    }

    public void DeletarDivida(int dividaId)
    {
        try
        {
            dividaDAL.DeletarDivida(dividaId);
        }
        catch (Exception ex)
        {

            throw new Exception($"Ocorreu um erro {ex.Message}");
        }
    }
}
