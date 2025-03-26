using GerenciadorGastos.DAL;
using GerenciadorGastos.DAL.Models;

namespace GerenciadorGastos.BLL;

public class GastoFixoBLL
{
    GastoFixoDAL gastoFixoDAL = new GastoFixoDAL();

    public List<GastoFixo> ObterGastosFixo()
    {
        try
        {
            var result = gastoFixoDAL.ObterGastosFixo();

            return result;
        }
        catch (Exception ex)
        {

            throw new Exception($"Ocorreu um erro {ex.Message}");
        }

    }

    public decimal ObterValorGastosFixo()
    {
        try
        {
            var result = gastoFixoDAL.ObterValorGastosFixo();

            return result;
        }
        catch (Exception ex)
        {

            throw new Exception($"Ocorreu um erro {ex.Message}");
        }
    }

    public void AdicionarGastoFixo(GastoFixo gastoFixo)
    {
        try
        {
            gastoFixoDAL.AdicionarGastoFixo(gastoFixo);

        }
        catch (Exception ex)
        {

            throw new Exception($"Ocorreu um erro {ex.Message}");
        }
    }

    public void EditarGastoFixo(GastoFixo gastoFixo)
    {
        try
        {
            gastoFixoDAL.EditarGastoFixo(gastoFixo);

        }
        catch (Exception ex)
        {

            throw new Exception($"Ocorreu um erro {ex.Message}");
        }
    }

    public void DeletarGastoFixo(int gastoFixoId)
    {
        try
        {
            gastoFixoDAL.DeletarGastoFixo(gastoFixoId);

        }
        catch (Exception ex)
        {

            throw new Exception($"Ocorreu um erro {ex.Message}");
        }
    }
}
