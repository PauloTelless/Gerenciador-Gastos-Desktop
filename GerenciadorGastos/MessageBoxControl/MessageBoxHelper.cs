namespace GerenciadorGastos.MessageBoxControl;

public class MessageBoxHelper
{
    public static void ExibirMessageBox(string mensagem, string? legenda, string tipoErro)
    {

        MessageBox.Show(mensagem, legenda, MessageBoxButtons.OK, ObterMessageBoxIcon(tipoErro));


        MessageBoxIcon ObterMessageBoxIcon(string tipoErro)
        {
            if (tipoErro == "Error")
            {
                return MessageBoxIcon.Error;
            }
            else if (tipoErro == "Info")
            {
                return MessageBoxIcon.Information;

            }
            else if (tipoErro == "Aviso")
            {
                return MessageBoxIcon.Warning;
            }

            return MessageBoxIcon.Information;

        }
    }


}
