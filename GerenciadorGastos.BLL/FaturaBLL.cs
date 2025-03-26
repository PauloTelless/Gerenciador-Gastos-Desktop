using GerenciadorGastos.DAL;

namespace GerenciadorGastos.BLL;

public class FaturaBLL
{
    FaturaDAL faturaDAL = new FaturaDAL();

    public decimal ObterValorAtualFatura()
    {
        try
        {
            var result = faturaDAL.ObterValorFatura();
            return result;
        }
        catch (Exception ex)
        {

            throw new Exception($"Ocorreu um erro {ex.Message}");
        }

    }

    public void AtualizarValorFaturaAtual(decimal valor)
    {
        try
        {
            faturaDAL.AtualizarValorFatura(valor);

        }
        catch (Exception ex)
        {

            throw new Exception($"Ocorreu um erro {ex.Message}");
        }
    }
}
