using GerenciadorGastos.BLL;
using GerenciadorGastos.Forms.ItemForms;
using GerenciadorGastos.MessageBoxControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorGastos.Forms.CustoFixo.RemoverCusto
{
    public partial class RemoverCusto : Form
    {
        GastoFixoBLL gastoFixoBLL = new GastoFixoBLL();
        private EditarItem editarItemForm;

        public RemoverCusto(EditarItem editarForm)
        {
            InitializeComponent();
            PopulaComboBox();
            this.editarItemForm = editarForm;
        }

        #region Botões
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var comboBoxSelecionado = (ComboBoxDeleteGastoFixo)comboBox1.SelectedItem;

                if (comboBoxSelecionado != null)
                {
                    gastoFixoBLL.DeletarGastoFixo(comboBoxSelecionado.GastoFixoId);

                    MessageBoxHelper.ExibirMessageBox("Custo fixo removido com sucesso !", "Sucesso", "Info");

                    this.Close();

                    editarItemForm.PopulateListView();

                }
                else
                {
                    MessageBoxHelper.ExibirMessageBox($"Selecione um item", "Aviso", "Aviso");

                }

            }
            catch (Exception ex)
            {

                MessageBoxHelper.ExibirMessageBox($"Ocorreu um erro {ex.Message}", "Erro", "Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funções
        private void PopulaComboBox()
        {
            var gastosFixoList = gastoFixoBLL.ObterGastosFixo();

            foreach (var gastoFixo in gastosFixoList)
            {
                comboBox1.Items.Add(new ComboBoxDeleteGastoFixo() { GastoFixoId = gastoFixo.GastoFixoId, NomeGastoFixo = gastoFixo.NomeGastoFixo });
            }
        }
        #endregion

        #region Classes
        private class ComboBoxDeleteGastoFixo
        {
            public string NomeGastoFixo { get; set; }
            public int GastoFixoId { get; set; }

            public override string ToString()
            {
                return NomeGastoFixo;
            }
        }
        #endregion

    }
}
