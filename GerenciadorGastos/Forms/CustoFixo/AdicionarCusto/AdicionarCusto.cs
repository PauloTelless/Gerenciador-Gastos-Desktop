using GerenciadorGastos.BLL;
using GerenciadorGastos.DAL.Models;
using GerenciadorGastos.Forms.CustoFixo.AlterarCusto;
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

namespace GerenciadorGastos.Forms.CustoFixo.AdicionarCusto
{
    public partial class AdicionarCusto : Form
    {
        GastoFixoBLL gastoFixoBLL = new GastoFixoBLL();
        private EditarItem editarItemForm;

        public AdicionarCusto(EditarItem editarItem)
        {
            InitializeComponent();
            this.editarItemForm = editarItem;
        }

        #region Botões
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string valorComPonto = textBox2.Text.Replace(',', '.');

                if (decimal.TryParse(valorComPonto, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal valorItem))
                {
                    var dataCadastroFixo = dateTimePicker1.Value.Date;

                    GastoFixo gastoFixo = new GastoFixo()
                    {
                        NomeGastoFixo = textBox1.Text,
                        DataCadastroGastoFixo = dataCadastroFixo,
                        ValorGasto = valorItem
                    };

                    gastoFixoBLL.AdicionarGastoFixo(gastoFixo);

                    MessageBoxHelper.ExibirMessageBox("Custo adicionado com sucesso!", "Sucesso", "Info");

                    this.Close();
                    editarItemForm.PopulateListView();
                }
                else
                {
                    MessageBoxHelper.ExibirMessageBox("Adicione um valor válido", "Aviso", "Aviso");
                }

            }
            catch (Exception ex)
            {

                MessageBoxHelper.ExibirMessageBox($"Ocorreu um erro {ex.Message}", "Erro", "Error");
            }
        }
        #endregion

    }
}
