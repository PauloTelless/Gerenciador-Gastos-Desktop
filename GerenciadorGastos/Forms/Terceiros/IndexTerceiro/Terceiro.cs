using GerenciadorGastos.BLL;
using GerenciadorGastos.Forms.Terceiros.EditarTerceiro;

namespace GerenciadorGastos.Forms.Terceiros;

public partial class Terceiro : Form
{
    PessoaBLL pessoaBll = new PessoaBLL();
    private Index indexForm;

    public Terceiro(Index indexForm)
    {
        InitializeComponent();
        PopulateListView();
        this.indexForm = indexForm; 
    }

    #region Botões
    private void button1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        RemoverTerceiros removerTerceiros = new RemoverTerceiros(this);
        removerTerceiros.ShowDialog();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        AdicionarTerceiro adicionarTercieroForm = new AdicionarTerceiro();
        adicionarTercieroForm.ShowDialog();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        GerenciadorGastos.Forms.Terceiros.EditarTerceiro.EditarTerceiro editarTerceiroForm = new(this, indexForm);
        editarTerceiroForm.ShowDialog();
    }

    #endregion

    #region Funções
    internal void PopulateListView()
    {
        listView1.Items.Clear();
        decimal somaValor = 0;

        try
        {
            var pessoasItensList = pessoaBll.ObterPessoasTerceirasComItens();

            foreach (var item in pessoasItensList)
            {
                var pago = Convert.ToBoolean(item.Pago) ? "Sim" : "Não";

                if (pago == "Não")
                {
                    somaValor += item.ValorItem;

                }

                ListViewItem listViewItem = new ListViewItem(item.PessoaNome);
                listViewItem.SubItems.Add(item.ValorItem.ToString("C2"));
                listViewItem.SubItems.Add(item.NomeItem.ToString());
                listViewItem.SubItems.Add(item.DataCadastro.ToShortDateString());
                listViewItem.SubItems.Add(pago);

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
