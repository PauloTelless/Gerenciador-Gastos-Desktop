using GerenciadorGastos.BLL;
using GerenciadorGastos.DAL.Models;
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

namespace GerenciadorGastos.Forms.ItemForms.PagarItem
{
    public partial class PagarItem : Form
    {
        ItemBLL ItemBLL = new ItemBLL();
        private Index indexForm;

        public PagarItem(Index indexForm)
        {
            InitializeComponent();
            PopulateCheckListBox();
            this.indexForm = indexForm;
        }

        #region Funções
        internal void PopulateCheckListBox()
        {
            var data = DateTime.Now;

            checkedListBox1.Items.Clear();
            var itemList = ItemBLL.ObterItensPorIntervalo(data);

            foreach (var item in itemList)
            {
                checkedListBox1.Items.Add(new Item()
                {
                    ItemId = item.ItemId,
                    NomeItem = item.NomeItem,
                    ValorItem = item.ValorItem,
                    DataCadastroItem = item.DataCadastroItem,
                });
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            checkedListBox1.Items.Clear();

            var dataSelecionada = dateTimePicker1.Value.Date;

            var itemList = ItemBLL.ObterItensPorIntervalo(dataSelecionada);

            foreach (var item in itemList)
            {
                checkedListBox1.Items.Add(new Item()
                {
                    ItemId = item.ItemId,
                    NomeItem = item.NomeItem,
                    ValorItem = item.ValorItem,
                    DataCadastroItem = item.DataCadastroItem,
                });
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dataAtual = DateTime.Now;

            Item itemSelecionado = (Item)checkedListBox1.SelectedItem;

            try
            {
                ItemBLL.PagarItem(itemSelecionado.ItemId);
                MessageBoxHelper.ExibirMessageBox("Item pago com sucesso!", "Sucesso", "Info");
                indexForm.SetarDadosDisplayMenu(dataAtual);
                indexForm.PopulaListView();
                PopulateCheckListBox();
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ExibirMessageBox($"Erro ao pagar item! {ex.Message}", "Erro", "Error: ");
            }
        }
        #endregion

        #region Botões
        private void button1_Click(object sender, EventArgs e)
        {
            ItensPagos itensPagosForm = new ItensPagos(indexForm, this);
            itensPagosForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dataAtual = DateTime.Now;

            try
            {
                ItemBLL.PagarTodosItens();

                MessageBoxHelper.ExibirMessageBox("Todos os itens foram pagos !", "Atenção", "Aviso");
                PopulateCheckListBox();
                indexForm.SetarDadosDisplayMenu(dataAtual);
                indexForm.PopulaListView();

            }
            catch (Exception ex)
            {

                MessageBoxHelper.ExibirMessageBox($"Erro ao pagar todos os itens! {ex.Message}", "Erro", "Error");
            }
        }
        #endregion


    }
}
