using GerenciadorGastos.BLL;
using GerenciadorGastos.DAL.Models;
using GerenciadorGastos.MessageBoxControl;

namespace GerenciadorGastos.Forms.ItemForms
{
    public partial class AdicionarItem : Form
    {
        private PessoaBLL pessoaBLL = new PessoaBLL();
        private ItemBLL itemBLL = new ItemBLL();
        private Index indexForm;
        public AdicionarItem(Index indexForm)
        {
            InitializeComponent();
            PopulaComboBox();
            this.indexForm = indexForm;
        }

        #region Botões
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    string valorComPonto = textBox2.Text.Replace(',', '.');

                    if (decimal.TryParse(valorComPonto, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal valorItem))
                    {
                        Item item = new Item()
                        {
                            NomeItem = textBox1.Text,
                            DataCadastroItem = dateTimePicker1.Value.Date,
                            ValorItem = valorItem,
                            PessoaId = 1
                        };

                        itemBLL.AdicionarItem(item);

                        MessageBoxHelper.ExibirMessageBox("Item adicionado com sucesso!", "Sucesso", "Info");

                        this.Close();

                        indexForm.PopulaListView();

                    }
                    else
                    {
                        MessageBoxHelper.ExibirMessageBox("Adicione um valor válido", "Aviso", "Aviso");

                    }

                }
                else
                {
                    var selectPessoa = (PessoaComboBoxItem)comboBox1.SelectedItem;

                    string valorComPonto = textBox2.Text.Replace(',', '.');

                    if (decimal.TryParse(valorComPonto, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal valorItem))
                    {
                        Item item = new Item()
                        {
                            NomeItem = textBox1.Text,
                            DataCadastroItem = dateTimePicker1.Value.Date,
                            ValorItem = valorItem,
                            PessoaId = selectPessoa.PessoaId
                        };

                        itemBLL.AdicionarItem(item);

                        MessageBoxHelper.ExibirMessageBox("Item adicionado com sucesso!", "Sucesso", "Info");


                        this.Close();

                    }
                    else
                    {
                        MessageBoxHelper.ExibirMessageBox("Formato do valor incorreto", "Aviso", "Aviso");
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBoxHelper.ExibirMessageBox($"Ocorreu um erro: {ex.Message}", "Aviso", "Error");

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
            comboBox1.Items.Add("Selecione");
            comboBox1.SelectedIndex = 0;

            var pessoaList = pessoaBLL.ObterPessoas();

            foreach (var pessoa in pessoaList)
            {
                comboBox1.Items.Add(new PessoaComboBoxItem
                {
                    PessoaId = pessoa.PessoaId,
                    PessoaNome = pessoa.PessoaNome
                });
            }

        }

        #endregion

        #region Classes
        private class PessoaComboBoxItem
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
}
