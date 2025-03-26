using GerenciadorGastos.BLL;
using GerenciadorGastos.MessageBoxControl;

namespace GerenciadorGastos.Forms.ItemForms
{
    public partial class RemoverItem : Form
    {
        ItemBLL itemBLL = new ItemBLL();
        private Index indexForm;

        public RemoverItem(Index indexForm)
        {
            InitializeComponent();
            PopulaCombox();
            this.indexForm = indexForm;
        }

        #region Botões
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            PopulaCombox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var selectPessoa = (ComboBoxItem)comboBox2.SelectedItem;

                if (selectPessoa != null)
                {
                    itemBLL.DeletarItem(selectPessoa.ItemId);

                    MessageBoxHelper.ExibirMessageBox("Item removido com sucesso", "Sucesso", "Info");

                    this.Close();

                    indexForm.PopulaListView();
                }
                else
                {
                    MessageBoxHelper.ExibirMessageBox("Selecione um item", "Aviso", "Aviso");

                }

            }
            catch (Exception ex)
            {

                MessageBoxHelper.ExibirMessageBox($"Ocorreu um erro: {ex.Message}", "Sucesso", "Error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Funções
        private void PopulaCombox()
        {
            comboBox2.Items.Clear();

            try
            {
                var data = dateTimePicker1.Value.Date;

                var itemsList = itemBLL.ObterItems(data);

                if (itemsList.Count != 0)
                {

                    label5.Text = "Selecione o item:";

                    foreach (var item in itemsList)
                    {
                        comboBox2.Items.Add(new ComboBoxItem() { ItemId = item.ItemId, NomeItem = item.NomeItem, ValorItem = item.ValorItem });
                    }

                    comboBox2.Visible = true;
                }
                else
                {
                    label5.Text = "Não possui itens para esse dia";
                    comboBox2.Items.Clear();
                    comboBox2.Visible = false;

                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        #endregion

        #region Classes
        private class ComboBoxItem
        {
            public int ItemId { get; set; }
            public string NomeItem { get; set; }
            public decimal ValorItem { get; set; }

            public override string ToString()
            {
                return $"{NomeItem} - {ValorItem.ToString("C2")}";
            }
        }
        #endregion

    }
}
