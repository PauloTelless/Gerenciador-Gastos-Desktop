using GerenciadorGastos.BLL;
using GerenciadorGastos.DAL.Models;
using GerenciadorGastos.Forms.ItemForms.PagarItem;
using GerenciadorGastos.MessageBoxControl;
using GerenciadorGastos.MessageBoxControl;

namespace GerenciadorGastos.Forms.ItemForms;

public partial class ItensPagos : Form
{
    ItemBLL ItemBLL = new ItemBLL();
    private Index indexForm;
    private GerenciadorGastos.Forms.ItemForms.PagarItem.PagarItem pagarItemForm;

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
        var itemList = ItemBLL.ObterItems(true);

        foreach (var item in itemList)
        {
            checkedListBox1.Items.Add(item);
        }

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

    #endregion

}
