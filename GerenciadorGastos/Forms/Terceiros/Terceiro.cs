using GerenciadorGastos.BLL;

namespace GerenciadorGastos.Forms.Terceiros;

public partial class Terceiro : Form
{
    PessoaBLL pessoaBll = new PessoaBLL();

    public Terceiro()
    {
        InitializeComponent();
        PopulateListView();
    }

    #region Botões
    private void button1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    #endregion

    #region Funções
    private void PopulateListView()
    {
        listView1.Items.Clear();
        decimal somaValor = 0;

        try
        {
            var pessoasItensList = pessoaBll.ObterPessoaTerceira();

            foreach (var item in pessoasItensList)
            {
                somaValor += item.ValorItem;

                ListViewItem listViewItem = new ListViewItem(item.PessoaNome);
                listViewItem.SubItems.Add(item.ValorItem.ToString("C2"));
                listViewItem.SubItems.Add(item.NomeItem.ToString());
                listViewItem.SubItems.Add(item.DataCadastro.ToShortDateString());

                listView1.Items.Add(listViewItem);
            }

            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = -2;
            }

            label3.Text = somaValor.ToString("C2");

        }
        catch (Exception)
        {

            throw;
        }

    }
    #endregion


}
