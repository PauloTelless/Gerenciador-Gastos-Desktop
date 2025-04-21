using GerenciadorGastos.BLL;
using GerenciadorGastos.DAL.Models;
using GerenciadorGastos.Forms.ItemForms.PagarItem;
using GerenciadorGastos.MessageBoxControl;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorGastos.Forms.ItemForms;

public partial class ItensPagos : Form
{
    ItemBLL ItemBLL = new ItemBLL();
    private Index indexForm;
    private GerenciadorGastos.Forms.ItemForms.PagarItem.PagarItem pagarItemForm;
    private decimal totalValor;

    public ItensPagos(Index indexForm, PagarItem.PagarItem pagarItemForm)
    {
        InitializeComponent();
        PopulateCheckListBox();
        this.indexForm = indexForm;
        this.pagarItemForm = pagarItemForm;
    }

    #region Funções
    private void PopulateCheckListBox()
    {
        checkedListBox1.Items.Clear();

        var data = dateTimePicker1.Value.Date;

        var itemList = ItemBLL.ObterItensPorIntervalo(data, true);


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

        string mes = data.ToString("MMMM", new CultureInfo("pt-BR")).ToUpper();
        label2.Text = $"Valor total gasto em {mes}: R$ {totalValor}";

    }
    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var dataAtual = DateTime.Now;

        try
        {
            var itemSelecionado = (Item)checkedListBox1.SelectedItem;

            ItemBLL.PagarItem(itemSelecionado.ItemId, true);


            MessageBoxHelper.ExibirMessageBox("O item voltou a sua fatura!", "Atenção", "Aviso");
            pagarItemForm.PopulateCheckListBox();
            PopulateCheckListBox();
            indexForm.PopulaListView();
            indexForm.SetarDadosDisplayMenu(dataAtual);
        }
        catch (Exception ex)
        {

            MessageBoxHelper.ExibirMessageBox($"Ocorreu um erro ao colocar o item de volta à fatura: {ex.Message}", "Erro", "Error");
        }

    }


    #endregion

    #region Botões
    private void button1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
        totalValor = 0;
        var data = dateTimePicker1.Value.Date;

        checkedListBox1.Items.Clear();
        var itemList = ItemBLL.ObterItensPorIntervalo(data, true);

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

        string mes = data.ToString("MMMM", new CultureInfo("pt-BR")).ToUpper();
        label2.Text = $"Valor total gasto em {mes}: R$ {totalValor}";
    }

    #endregion

}
