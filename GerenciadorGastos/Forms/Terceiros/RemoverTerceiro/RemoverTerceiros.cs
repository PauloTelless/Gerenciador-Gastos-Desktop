using GerenciadorGastos.BLL;
using GerenciadorGastos.MessageBoxControl;

namespace GerenciadorGastos.Forms.Terceiros;

public partial class RemoverTerceiros : Form
{
    PessoaBLL pessoaBLL = new PessoaBLL();
    private Terceiro terceiroForm;

    public RemoverTerceiros(Terceiro terceiro)
    {
        InitializeComponent();
        PopulateComboBox();
        this.terceiroForm = terceiro;
    }

    #region Funções
    private void PopulateComboBox()
    {
        var terceirosList = pessoaBLL.ObterPessoasTerceiras();

        foreach (var terceiro in terceirosList)
        {
            comboBox1.Items.Add(
                new ComboBoxTerceiros
                {
                    PessoaId = terceiro.PessoaId,
                    PessoaNome = terceiro.PessoaNome
                });
        }

        if (comboBox1.Items.Count == 0)
        {
            label4.Visible = true;
            comboBox1.Visible = false;
            label2.Visible = false;
            label4.Text = "Não possui nenhum terceiro cadastrado.";
        }
        else
        {
            label4.Visible = false;

        }

    }

    #endregion

    #region Classes
    private class ComboBoxTerceiros
    {
        public int PessoaId { get; set; }
        public string PessoaNome { get; set; }

        public override string ToString()
        {
            return PessoaNome;
        }
    }
    #endregion

    #region Botões
    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var terceiroSelecionado = (ComboBoxTerceiros)comboBox1.SelectedItem;

        try
        {
            if (terceiroSelecionado == null)
            {
                MessageBoxHelper.ExibirMessageBox("Selecione primeiro uma pessoa !", "Atenção", "Aviso");
                return;
            }
            else
            {
                pessoaBLL.DeletarPessoa(terceiroSelecionado.PessoaId);

                MessageBoxHelper.ExibirMessageBox("Terceiro excluído com sucesso!", "Sucesso", "Info");
                terceiroForm.PopulateListView();
                this.Close();
            }

        }
        catch (Exception ex)
        {
            MessageBoxHelper.ExibirMessageBox($"Ocorreu um erro ao deletar um tercerio: {ex.Message}", "Erro", "Error");
        }

    }
    #endregion

}
