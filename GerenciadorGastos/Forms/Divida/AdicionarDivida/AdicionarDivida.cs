using GerenciadorGastos.BLL;
using GerenciadorGastos.DAL.Models;
using GerenciadorGastos.Forms.ItemForms;
using GerenciadorGastos.MessageBoxControl;

namespace GerenciadorGastos.Forms.Divida.AdicionarDivida
{
    public partial class AdicionarDivida : Form
    {
        DividaBLL dividaBLL = new DividaBLL();
        private EditarItem editarItemForm;

        public AdicionarDivida(EditarItem editarItemForm)
        {
            InitializeComponent();
            this.editarItemForm = editarItemForm;
        }

        #region Botões
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dataCadastro = dateTimePicker1.Value.Date;

                string valorComPonto = textBox2.Text.Replace(',', '.');

                if (decimal.TryParse(valorComPonto, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal valorItem))
                {

                    var divida = new GerenciadorGastos.DAL.Models.Divida
                    {
                        NomeDivida = textBox1.Text,
                        ValorDivida = valorItem,
                        DataCadastroDivida = dataCadastro
                    };


                    dividaBLL.AdicionarDivida(divida);

                    MessageBoxHelper.ExibirMessageBox("Dívida adicionada com sucesso !", "Sucesso", "Info");

                    this.Close();
                    editarItemForm.PopulateListView();

                }
                else
                {
                    MessageBoxHelper.ExibirMessageBox("Adicione um valor válido", "Aviso", "Aviso");

                }

            }
            catch (Exception ex)
            {

                MessageBoxHelper.ExibirMessageBox($"Ocorreu um erro: {ex.Message}", "Erro", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
