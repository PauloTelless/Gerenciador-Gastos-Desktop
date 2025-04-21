using GerenciadorGastos.BLL;
using GerenciadorGastos.DAL.Models;
using GerenciadorGastos.MessageBoxControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GerenciadorGastos.Forms.ItemForms.PagarItem
{
    public partial class PagarItem : Form
    {
        ItemBLL ItemBLL = new ItemBLL();
        private Index indexForm;
        private decimal totalValor;

        public PagarItem(Index indexForm)
        {
            InitializeComponent();
            PopulateCheckListBox();
            this.indexForm = indexForm;
        }

        #region Funções
        internal void PopulateCheckListBox()
        {
            totalValor = 0;

            var data = DateTime.Now;

            checkedListBox1.Items.Clear();
            var itemList = ItemBLL.ObterItensPorIntervalo(data, false);

            foreach (var item in itemList)
            {
                if (item.PessoaId == 1)
                {
                    totalValor += item.ValorItem;
                }

                checkedListBox1.Items.Add(new Item()
                {
                    ItemId = item.ItemId,
                    NomeItem = item.NomeItem,
                    ValorItem = item.ValorItem,
                    DataCadastroItem = item.DataCadastroItem,
                });

                string mes = data.ToString("MMMM", new CultureInfo("pt-BR")).ToUpper();

                label2.Text = $"Valor total gasto em {mes}: R$ {totalValor}";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            totalValor = 0;

            checkedListBox1.Items.Clear();

            var dataSelecionada = dateTimePicker1.Value.Date;

            var itemList = ItemBLL.ObterItensPorIntervalo(dataSelecionada, false);

            foreach (var item in itemList)
            {
                if (item.PessoaId == 1)
                {
                    totalValor += item.ValorItem;
                }

                checkedListBox1.Items.Add(new Item()
                {
                    ItemId = item.ItemId,
                    NomeItem = item.NomeItem,
                    ValorItem = item.ValorItem,
                    DataCadastroItem = item.DataCadastroItem,
                });
            }

            string mes = dataSelecionada.ToString("MMMM", new CultureInfo("pt-BR")).ToUpper();

            label2.Text = $"Valor total gasto em {mes}: R$ {totalValor}";

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
