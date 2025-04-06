using GerenciadorGastos.BLL;
using GerenciadorGastos.Forms.ItemForms;
using GerenciadorGastos.Forms.ItemForms.PagarItem;
using GerenciadorGastos.Forms.Terceiros;

namespace GerenciadorGastos.Forms
{
    public partial class Index : Form
    {
        ItemBLL itemBLL = new ItemBLL();
        FaturaBLL faturaBLL = new FaturaBLL();
        GastoFixoBLL gastoFixoBLL = new GastoFixoBLL();
        DividaBLL dividaBLL = new DividaBLL();

        public Index()
        {
            InitializeComponent();
            PopulaListView();
        }

        #region Botões
        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarItem formAdicionarItem = new AdicionarItem(this);

            formAdicionarItem.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoverItem formRemoverItem = new RemoverItem(this);

            formRemoverItem.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditarItem editarItemForm = new EditarItem(this);
            editarItemForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Terceiro formTerceiro = new Terceiro(this);
            formTerceiro.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var data = dateTimePicker1.Value.Date;

            PesquisaItensPorData(data);
            SetarDadosDisplayMenu(data);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var data = dateTimePicker1.Value.Date;
            PesquisaItensPorData(data);
            SetarDadosDisplayMenu(data);
        }


        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PagarItem pagarItemForm = new PagarItem(this);
            pagarItemForm.ShowDialog();
        }

        #endregion

        #region Funções
        public void PopulaListView()
        {
            try
            {

                var data = dateTimePicker1.Value.Date;
                SetarDadosDisplayMenu(data);

                listView1.Items.Clear();

                var itemsList = itemBLL.ObterItems(data);

                if (itemsList.Count != 0)
                {
                    foreach (var item in itemsList)
                    {
                        var pago = Convert.ToBoolean(item.Pago) ? "Sim" : "Não";

                        ListViewItem listViewItem = new ListViewItem(item.NomeItem);
                        listViewItem.SubItems.Add(item.ValorItem.ToString("C2"));
                        listViewItem.SubItems.Add(item.PessoaNome.ToString());
                        listViewItem.SubItems.Add(pago);
                        listView1.Items.Add(listViewItem);
                    }

                    label7.Text = itemBLL.ObterGastoTotalDia(data).ToString("C2");

                    foreach (ColumnHeader column in listView1.Columns)
                    {
                        column.Width = -2;
                    }

                }
                else
                {
                    label7.Text = "";
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        private void PesquisaItensPorData(DateTime data)
        {

            listView1.Items.Clear();
            var itemsList = itemBLL.ObterItems(data);

            try
            {
                if (itemsList.Count != 0)
                {
                    foreach (var item in itemsList)
                    {
                        var pago = item.Pago == false ? "Não" : "Sim";


                        ListViewItem listViewItem = new ListViewItem(item.NomeItem);
                        listViewItem.SubItems.Add(item.ValorItem.ToString("C2"));
                        listViewItem.SubItems.Add(item.PessoaNome.ToString());
                        listViewItem.SubItems.Add(pago);

                        listView1.Items.Add(listViewItem);
                    }

                    label7.Text = itemBLL.ObterGastoTotalDia(data).ToString("C2");
                    SetarDadosDisplayMenu(data);

                    foreach (ColumnHeader column in listView1.Columns)
                    {
                        column.Width = -2;
                    }
                    listView1.Visible = true;
                    label2.Visible = false;
                    label7.Visible = true;

                }
                else
                {
                    label7.Text = "";
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro: {ex.Message}");
            }
        }

        internal void SetarDadosDisplayMenu(DateTime data)
        {
            decimal valorGastoNoMes = itemBLL.ObterGastoPorMes(data);

            decimal faturaLimite = faturaBLL.ObterValorAtualFatura();
            decimal gastoFixo = gastoFixoBLL.ObterValorGastosFixo();
            decimal divida = dividaBLL.ObterValorDividas();

            decimal valorTotalMes = valorGastoNoMes + (gastoFixo + divida);

            decimal valorRestanteMes = faturaLimite - valorTotalMes;

            var dataAtual = DateTime.Now;
            int numeroDeSemanas = CalcularNumeroDeSemanas(dataAtual);

            var disponivelPorSemana = valorRestanteMes / numeroDeSemanas;

            label9.Text = valorRestanteMes.ToString("C2");
            label8.Text = disponivelPorSemana.ToString("C2");
            label10.Text = valorTotalMes.ToString("C2");

        }

        private int CalcularNumeroDeSemanas(DateTime dataAtual)
        {
            DateTime dia8 = new DateTime(dataAtual.Year, dataAtual.Month, 8);

            if (dataAtual.Day >= 8)
            {
                dia8 = dia8.AddMonths(1).AddDays(-1);
            }

            DateTime ultimoDomingo = dataAtual;
            while (ultimoDomingo.DayOfWeek != DayOfWeek.Sunday)
            {
                ultimoDomingo = ultimoDomingo.AddDays(-1);
            }

            int semanas = 0;
            DateTime proximoDomingo = ultimoDomingo.AddDays(7);

            while (proximoDomingo < dia8)
            {
                semanas++;
                proximoDomingo = proximoDomingo.AddDays(7);
            }

            return Math.Max(semanas, 1);
        }

        #endregion

    }
}
