using GerenciadorGastos.BLL;
using GerenciadorGastos.MessageBoxControl;

namespace GerenciadorGastos.Forms.Terceiros.EditarTerceiro;

public partial class EditarTerceiro : Form
{
    PessoaBLL PessoaBLL = new PessoaBLL();
    private Terceiro terceiroForm;
    private Index indexForm;

    public EditarTerceiro(Terceiro terceiroForm, Index indexForm)
    {
        InitializeComponent();
        PopulateComboBox();
        this.terceiroForm = terceiroForm;
        this.indexForm = indexForm;
    }

    #region Funções

    private void PopulateComboBox()
    {
        label3.Visible = false;
        textBox1.Visible = false;

        var pessoaList = PessoaBLL.ObterPessoasTerceiras();

        foreach (var pessoa in pessoaList)
        {
            comboBox1.Items.Add(new ComboBoxPessoa()
            {
                PessoaId = pessoa.PessoaId,
                PessoaNome = pessoa.PessoaNome
            });
        }
    }
    #endregion

    #region Botões
    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            var pessoaSelecionada = (ComboBoxPessoa)comboBox1.SelectedItem;
            if (pessoaSelecionada == null)
            {
                MessageBoxHelper.ExibirMessageBox("Selecione uma pessoa !", "Atenção", "Aviso");
                return;
            }

            PessoaBLL.EditarPessoa(pessoaSelecionada.PessoaId, textBox1.Text);

            MessageBoxHelper.ExibirMessageBox("O terceiro foi editado com sucesso!", "Sucesso", "Info");

            this.Close();

            terceiroForm.PopulateListView();
            indexForm.PopulaListView();
        }
        catch (Exception ex)
        {

            MessageBoxHelper.ExibirMessageBox($"Ocorreu um erro ao editar o terceiro! {ex.Message}", "Erro", "Error");
        }

    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var pessoaSelecionada = (ComboBoxPessoa)comboBox1.SelectedItem;

        if (pessoaSelecionada != null)
        {
            label3.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = pessoaSelecionada.PessoaNome;
        }
    }
    #endregion

    #region Classes
    private class ComboBoxPessoa
    {
        public int PessoaId { get; set; }

        public string PessoaNome { get; set; }

        public override string ToString()
        {
            return PessoaNome;
        }
    }
    #endregion

}
