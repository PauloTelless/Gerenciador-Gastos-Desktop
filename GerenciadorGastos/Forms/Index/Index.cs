using GerenciadorGastos.BLL;
using GerenciadorGastos.Forms.ItemForms;
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
            Terceiro formTerceiro = new Terceiro();
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

        private void button6_Click(object sender, EventArgs e)
        {
            AdicionarTerceiro adicionarTercieroForm = new AdicionarTerceiro();
            adicionarTercieroForm.ShowDialog();
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
                        ListViewItem listViewItem = new ListViewItem(item.NomeItem);
                        listViewItem.SubItems.Add(item.ValorItem.ToString("C2"));
                        listViewItem.SubItems.Add(item.PessoaNome.ToString());
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
                        ListViewItem listViewItem = new ListViewItem(item.NomeItem);
                        listViewItem.SubItems.Add(item.ValorItem.ToString("C2"));
                        listViewItem.SubItems.Add(item.PessoaNome.ToString());

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

        private void SetarDadosDisplayMenu(DateTime data)
        {
            decimal valorGastoNoMes = itemBLL.ObterGastoPorMes(data.Month, data.Year);

            decimal faturaLimite = faturaBLL.ObterValorAtualFatura();
            decimal gastoFixo = gastoFixoBLL.ObterValorGastosFixo();
            decimal divida = dividaBLL.ObterValorDividas();

            decimal valorTotalMes = valorGastoNoMes + (gastoFixo + divida);

            decimal valorRestanteMes = faturaLimite - valorTotalMes;

            int numeroDeSemanas = CalcularNumeroDeSemanas(data);

            var disponivelPorSemana = valorRestanteMes / numeroDeSemanas;

            label9.Text = valorRestanteMes.ToString("C2");
            label8.Text = disponivelPorSemana.ToString("C2");
            label10.Text = valorTotalMes.ToString("C2");

        }

        private int CalcularNumeroDeSemanas(DateTime dataFatura)
        {
            int semanas = 0;

            DateTime proximoDia8 = new DateTime(dataFatura.Year, dataFatura.Month, 8).AddMonths(1);

            DateTime dataAtual = DateTime.Now;

            if (dataFatura != dataAtual)
            {
                dataAtual = dataFatura; 
            }

            if (dataAtual > proximoDia8)
            {
                return 0;
            }

            DateTime dataInicioRestante = dataAtual;
            if (dataInicioRestante.DayOfWeek != DayOfWeek.Monday)
            {
                dataInicioRestante = dataInicioRestante.AddDays(-(int)dataInicioRestante.DayOfWeek + (int)DayOfWeek.Monday);
            }

            while (dataInicioRestante < proximoDia8)
            {
                semanas++;
                dataInicioRestante = dataInicioRestante.AddDays(7);
            }

            return semanas;
        }

        #endregion

    }
}
