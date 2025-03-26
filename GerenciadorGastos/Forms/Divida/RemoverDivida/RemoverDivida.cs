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

namespace GerenciadorGastos.Forms.Divida.RemoverDivida
{
    public partial class RemoverDivida : Form
    {
        DividaBLL dividaBLL = new DividaBLL();
        private EditarItem editarItemForm;

        public RemoverDivida(EditarItem editarItemForm)
        {
            InitializeComponent();
            PopulaComboBox();
            this.editarItemForm = editarItemForm;   
        }

        #region Botões
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var comboBoxSelecionado = (ComboBoxDeletarDivida)comboBox1.SelectedItem;

                if (comboBoxSelecionado != null)
                {
                    dividaBLL.DeletarDivida(comboBoxSelecionado.DividaId);

                    MessageBoxHelper.ExibirMessageBox($"Item deletado com sucesso !", "Sucesso", "Info");

                    this.Close();

                    editarItemForm.PopulateListView();

                }
                else
                {
                    MessageBoxHelper.ExibirMessageBox("Selecione um item", "Aviso", "Aviso");

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

        #region Funções
        private void PopulaComboBox()
        {
            var dividasList = dividaBLL.ObterDividas();

            foreach (var divida in dividasList)
            {
                comboBox1.Items.Add(new ComboBoxDeletarDivida()
                {
                    DividaId = divida.DividaId,
                    NomeDivida = divida.NomeDivida

                });
            }

        }

        #endregion

        #region Classes
        private class ComboBoxDeletarDivida
        {
            public int DividaId { get; set; }
            public string NomeDivida { get; set; }
            public override string ToString()
            {
                return NomeDivida;
            }
        }
        #endregion

    }
}
