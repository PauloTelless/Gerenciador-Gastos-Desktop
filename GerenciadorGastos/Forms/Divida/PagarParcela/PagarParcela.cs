using GerenciadorGastos.BLL;
using GerenciadorGastos.DAL.Models;
using GerenciadorGastos.Forms.ItemForms;
using GerenciadorGastos.MessageBoxControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorGastos.Forms.Divida.PagarParcela
{
    public partial class PagarParcela : Form
    {
        DividaBLL dividaBLL = new DividaBLL();
        ComboBoxPagarParcela divida = new ComboBoxPagarParcela();
        private Index indexForm;
        private EditarItem editarItem;
        int parcelaAtual = 0;


        public PagarParcela(EditarItem editarItem, Index index)
        {
            InitializeComponent();
            PopulaComboBox();
            EsconderConteudo();

            this.indexForm = index;
            this.editarItem = editarItem;   
        }

        #region Funções
        private void PopulaComboBox()
        {
            var dividaList = dividaBLL.ObterDividas();

            foreach (var item in dividaList)
            {
                comboBox1.Items.Add(new ComboBoxPagarParcela { DividaId = item.DividaId, NomeDivida = item.NomeDivida, ParcelaDivida = item.ParcelaDivida, DataCadastro = item.DataCadastroDivida, ValorDivida = item.ValorDivida, ParcelaDividaPaga = item.ParcelaDividaPaga });
            }
        }

        private void EsconderConteudo()
        {
            label3.Text = "";
            label3.Visible = false;
            label4.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            comboBox2.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                var comboBoxSelecionado = (ComboBoxPagarParcela)comboBox1.SelectedItem;
                divida = comboBoxSelecionado;

                HabilitarCampo(comboBoxSelecionado.ParcelaDivida, comboBoxSelecionado.DataCadastro, comboBoxSelecionado.ParcelaDividaPaga);
            }
        }

        private void HabilitarCampo(int parcelaTotal, DateTime dataCadastro, int parcelaPaga)
        {
            label3.Visible = true;
            comboBox2.Visible = true;
            label4.Visible = true;
            comboBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;

            PopulaComboBoxParcelas(parcelaTotal, dataCadastro, parcelaPaga);
        }

        private void PopulaComboBoxParcelas(int parcelaTotal, DateTime dataCadastro, int parcelaPaga)
        {
            comboBox2.Items.Clear();

            DateTime dataAtual = DateTime.Now;

            int mesesDecorridos = (dataAtual.Year - dataCadastro.Year) * 12 + (dataAtual.Month - dataCadastro.Month);

            if (dataAtual.Day < dataCadastro.Day)
                mesesDecorridos--;

            parcelaAtual = mesesDecorridos + 1;

            if (parcelaAtual < 1) parcelaAtual = 1;
            if (parcelaAtual > parcelaTotal) parcelaAtual = parcelaTotal;

            int parcelasRestantes = parcelaTotal - parcelaAtual;
            
            if (parcelaPaga != 0)
            {
                parcelasRestantes -= parcelaPaga;
            }


            label3.Text = $"Número de parcelas restantes: {parcelasRestantes}";

            for (int i = 0; i < parcelasRestantes; i++)
            {
                int numeroPacela = 1 + i;

                comboBox2.Items.Add(numeroPacela);
            }

        }

        private void AnteciparParcela(ComboBoxPagarParcela comboBoxPagar)
        {
            bool quitarDivida = false;

            int quantidadeParcelasAntecipadas = (int)comboBox2.SelectedItem;

            int dividaId = comboBoxPagar.DividaId;
            int parcelasRestantes = comboBoxPagar.ParcelaDivida - parcelaAtual;
            int novaParcela = parcelasRestantes - quantidadeParcelasAntecipadas;

            decimal valorParcela = (comboBoxPagar.ValorDivida / comboBoxPagar.ParcelaDivida);
            decimal valorDivida = divida.ValorDivida;
            decimal novoValorDivida = valorDivida - (quantidadeParcelasAntecipadas * valorParcela);

            if (novaParcela == 0)
            {
                quitarDivida = true;
            }


            try
            {
                if (comboBox2.SelectedIndex != -1)
                {
                    dividaBLL.AnteciparParcela(dividaId, novaParcela, novoValorDivida, quantidadeParcelasAntecipadas, quitarDivida);

                    MessageBoxHelper.ExibirMessageBox("Parcela antecipada !", "Sucesso", "Info");
                    editarItem.PopulateListViewDivida();
                    indexForm.PopulaListView();
                }
                else
                {
                    MessageBoxHelper.ExibirMessageBox("Selecione a quantidade de parcelas", "Atenção", "Aviso");
                }
            }
            catch (Exception ex)
            {

                MessageBoxHelper.ExibirMessageBox($"Ocorreu um erro: {ex.Message}", "Erro", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AnteciparParcela(divida);

        }
        #endregion

        #region Classes
        internal class ComboBoxPagarParcela
        {
            public int DividaId { get; set; }

            public string NomeDivida { get; set; }

            public int ParcelaDivida { get; set; }

            public decimal ValorDivida { get; set; }

            public DateTime DataCadastro { get; set; }

            public int ParcelaDividaPaga { get; set; }

            public override string ToString()
            {
                return NomeDivida;
            }
        }
        #endregion
    }
}
