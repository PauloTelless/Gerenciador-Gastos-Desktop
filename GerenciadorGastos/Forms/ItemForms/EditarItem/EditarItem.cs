using GerenciadorGastos.BLL;
using GerenciadorGastos.Forms.CustoFixo.AdicionarCusto;
using GerenciadorGastos.Forms.CustoFixo.AlterarCusto;
using GerenciadorGastos.Forms.CustoFixo.RemoverCusto;
using GerenciadorGastos.Forms.Divida.AdicionarDivida;
using GerenciadorGastos.Forms.Divida.EditarDivida;
using GerenciadorGastos.Forms.Divida.RemoverDivida;
using System.Globalization;

namespace GerenciadorGastos.Forms.ItemForms
{
    public partial class EditarItem : Form
    {
        GastoFixoBLL gastoFixoBLL = new GastoFixoBLL();
        DividaBLL dividaBLL = new DividaBLL();
        FaturaBLL faturaBLL = new FaturaBLL();
        ItemBLL itemBLL = new ItemBLL();
        private Index indexForm;

        public EditarItem(Index indexForm)
        {
            InitializeComponent();
            PopulateListView();
            this.indexForm = indexForm;
        }

        #region Botões
        private void button8_Click(object sender, EventArgs e)
        {

            var valorNovoString = textBox3.Text;

            valorNovoString = valorNovoString.Replace(".", "").Replace(",", ".");


            decimal valorNovo;
            if (decimal.TryParse(valorNovoString, NumberStyles.Any, CultureInfo.InvariantCulture, out valorNovo))
            {
                AtualizarValorFaturaLimite(valorNovo);
                indexForm.PopulaListView();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            indexForm.PopulaListView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarCusto adicionarCustoForm = new AdicionarCusto(this);
            adicionarCustoForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoverCusto removerCustoForm = new RemoverCusto(this);
            removerCustoForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditarCusto editarCustoForm = new EditarCusto(this);
            editarCustoForm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PopulateListView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdicionarDivida adicionarDividaForm = new AdicionarDivida(this);
            adicionarDividaForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RemoverDivida removerDividaForm = new RemoverDivida(this);
            removerDividaForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditarDivida editarDividaForm = new EditarDivida(this);
            editarDividaForm.ShowDialog();
        }
        #endregion

        #region Funções
        internal void PopulateListView()
        {
            PopulateListViewGastoFixo();
            PopulateListViewDivida();
            SetValoresLabel();
        }

        internal void PopulateListViewGastoFixo()
        {
            listView1.Items.Clear();

            var gastosFixoList = gastoFixoBLL.ObterGastosFixo();

            foreach (var gastoFixo in gastosFixoList)
            {
                ListViewItem listViewItem = new ListViewItem(gastoFixo.NomeGastoFixo);
                listViewItem.SubItems.Add(gastoFixo.ValorGasto.ToString("C2"));

                listView1.Items.Add(listViewItem);

                foreach (ColumnHeader column in listView1.Columns)
                {
                    column.Width = -2;
                }
            }
        }

        private void PopulateListViewDivida()
        {
            listView2.Items.Clear();

            var dividaList = dividaBLL.ObterDividas();

            foreach (var divida in dividaList)
            {
                ListViewItem listViewItem = new ListViewItem(divida.NomeDivida);
                listViewItem.SubItems.Add(divida.ValorDivida.ToString("C2"));

                listView2.Items.Add(listViewItem);

                foreach (ColumnHeader column in listView2.Columns)
                {
                    column.Width = -2;
                }
            }
        }

        private void SetValoresLabel()
        {
            decimal gastoFixo = gastoFixoBLL.ObterValorGastosFixo();
            decimal divida = dividaBLL.ObterValorDividas();
            decimal total = gastoFixo + divida;

            label3.Text = gastoFixo.ToString("C2");
            label5.Text = divida.ToString("C2");
            label7.Text = total.ToString("C2");

            var dataAtual = DateTime.Now.ToShortDateString();
            label12.Text = dataAtual;

            var mes = DateTime.Now.Month;
            var ano = DateTime.Now.Year;

            decimal faturaAtual = itemBLL.ObterGastoPorMes(mes, ano);
            decimal faturaAtualTotal = faturaAtual + total;
            decimal faturaLimite = faturaBLL.ObterValorAtualFatura();

            decimal valorDisponivel = faturaLimite - faturaAtualTotal;

            label10.Text = faturaAtualTotal.ToString("C2");
            label11.Text = faturaBLL.ObterValorAtualFatura().ToString("C2");
            label15.Text = valorDisponivel.ToString("C2");
        }

        private void AtualizarValorFaturaLimite(decimal valor)
        {
            textBox3.Text = string.Empty;
            faturaBLL.AtualizarValorFaturaAtual(valor);
            label11.Text = valor.ToString();

            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;

            decimal gastoMes = itemBLL.ObterGastoPorMes(mes, ano);
            decimal gastoFixo = gastoFixoBLL.ObterValorGastosFixo();
            decimal divida = dividaBLL.ObterValorDividas();

            decimal totalFatura = gastoMes + (gastoFixo + divida);

            decimal valorRestante = valor - totalFatura;

            label11.Text = valor.ToString("C2");
            label15.Text = valorRestante.ToString("C2");

        }

        #endregion

    }

}
