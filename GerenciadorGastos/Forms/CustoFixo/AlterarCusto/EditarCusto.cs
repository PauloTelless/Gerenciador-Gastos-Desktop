using GerenciadorGastos.BLL;
using GerenciadorGastos.DAL.Models;
using GerenciadorGastos.Forms.ItemForms;
using GerenciadorGastos.MessageBoxControl;

namespace GerenciadorGastos.Forms.CustoFixo.AlterarCusto
{
    public partial class EditarCusto : Form
    {
        GastoFixoBLL gastoFixoBLL = new GastoFixoBLL();
        private EditarItem editarItemForm;

        public EditarCusto(EditarItem editarItemForm)
        {
            InitializeComponent();
            PopulaComboBox();
            DesabilitarCampos();
            this.editarItemForm = editarItemForm;
        }

        #region Botões
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HabilitarCampos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dataCadastroNova = dateTimePicker1.Value;
                string valorComPonto = textBox2.Text.Replace(',', '.');
                var comboBoxSelecionado = (ComboBoxGastoFixo)comboBox1.SelectedItem;

                if (comboBoxSelecionado == null)
                {
                    MessageBoxHelper.ExibirMessageBox("Selecione um item", "Aviso", "Aviso");

                }

                if (decimal.TryParse(valorComPonto, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal valorItem))
                {
                    var gastoFixo = new GastoFixo()
                    {
                        GastoFixoId = comboBoxSelecionado.GastoFixoId,
                        NomeGastoFixo = textBox1.Text,
                        DataCadastroGastoFixo = dataCadastroNova,
                        ValorGasto = valorItem

                    };

                    gastoFixoBLL.EditarGastoFixo(gastoFixo);

                    MessageBoxHelper.ExibirMessageBox("Custo fixo atualizado com sucesso !", "Sucesso", "Info");

                    this.Close();

                    editarItemForm.PopulateListView();

                }

            }
            catch (Exception ex)
            {

                MessageBoxHelper.ExibirMessageBox($"Ocorreu um erro {ex.Message}", "Erro", "Error");
            }

        }


        #endregion

        #region Funções
        private void HabilitarCampos()
        {
            var comboBoxSelecionado = (ComboBoxGastoFixo)comboBox1.SelectedItem;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = true;

            textBox1.Text = comboBoxSelecionado.NomeGastoFixo;
            textBox2.Text = comboBoxSelecionado.ValorGastoFixo.ToString();

            dateTimePicker1.Visible = true;
            dateTimePicker1.Value = comboBoxSelecionado.DataCadastroGastoFixo;
        }

        private void DesabilitarCampos()
        {


            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;
            dateTimePicker1.Visible = false;


        }

        private void PopulaComboBox()
        {
            var gastosFixoList = gastoFixoBLL.ObterGastosFixo();

            foreach (var gastoFixo in gastosFixoList)
            {
                comboBox1.Items.Add(new ComboBoxGastoFixo
                {
                    NomeGastoFixo = gastoFixo.NomeGastoFixo,
                    GastoFixoId = gastoFixo.GastoFixoId,
                    ValorGastoFixo = gastoFixo.ValorGasto,
                    DataCadastroGastoFixo = gastoFixo.DataCadastroGastoFixo
                });
            }
        }
        #endregion

        #region Classes
        private class ComboBoxGastoFixo
        {
            public int GastoFixoId { get; set; }

            public string NomeGastoFixo { get; set; }

            public decimal ValorGastoFixo { get; set; }

            public DateTime DataCadastroGastoFixo { get; set; }

            public override string ToString()
            {
                return NomeGastoFixo;
            }
        }
        #endregion

    }
}
