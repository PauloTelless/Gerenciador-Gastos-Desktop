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

namespace GerenciadorGastos.Forms.Divida.EditarDivida
{
    public partial class EditarDivida : Form
    {
        DividaBLL dividaBLL = new DividaBLL();
        private EditarItem editarItemForm;

        public EditarDivida(EditarItem editarItemForm)
        {
            InitializeComponent();
            PopulaComboBox();
            DesabilitarCampos();
            this.editarItemForm = editarItemForm;
        }

        #region Botões
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dataCadastro = dateTimePicker1.Value.Date;
                var comboBoxSelecionado = (ComboBoxEditarDivida)comboBox1.SelectedItem;
                string valorComPonto = textBox2.Text.Replace(',', '.');

                if (comboBoxSelecionado == null)
                {
                    MessageBoxHelper.ExibirMessageBox("Selecione um item", "Aviso", "Aviso");
                    return;
                }

                if (decimal.TryParse(valorComPonto, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal valorItem))
                {
                    var divida = new GerenciadorGastos.DAL.Models.Divida
                    {
                        DividaId = comboBoxSelecionado.DividaId,
                        NomeDivida = textBox1.Text,
                        ValorDivida = valorItem,
                        DataCadastroDivida = dataCadastro,
                        DividaAtiva = checkBox1.Checked
                    };

                    dividaBLL.EditarDivida(divida);

                    MessageBoxHelper.ExibirMessageBox("Divida editada com sucesso!", "Sucesso", "Info");

                    this.Close();
                    editarItemForm.PopulateListView();
                }
                else
                {
                    MessageBoxHelper.ExibirMessageBox("Informe um valor válido", "Aviso", "Aviso");

                }

            }
            catch (Exception ex)
            {

                MessageBoxHelper.ExibirMessageBox($"Ocorreu um erro: {ex.Message}", "Erro", "Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                HabilitarCampos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Funções
        private void DesabilitarCampos()
        {


            label2.Visible = false;
            label3.Visible = false;
            label1.Visible = false;
            checkBox1.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;
            dateTimePicker1.Visible = false;


        }

        private void HabilitarCampos()
        {
            var comboBoxSelecionado = (ComboBoxEditarDivida)comboBox1.SelectedItem;

            label2.Visible = true;
            label3.Visible = true;
            label1.Visible = true;

            textBox1.Visible = true;

            if (comboBoxSelecionado.DividaAtiva)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;

            }

            textBox2.Visible = true;
            checkBox1.Visible = true;

            textBox1.Text = comboBoxSelecionado.NomeDivida;
            textBox2.Text = comboBoxSelecionado.ValorDivida.ToString();

            dateTimePicker1.Visible = true;
            dateTimePicker1.Value = comboBoxSelecionado.DataCadastroDivida;
        }

        private void PopulaComboBox()
        {
            var dividasList = dividaBLL.ObterDividas(false);

            foreach (var divida in dividasList)
            {

                comboBox1.Items.Add(new ComboBoxEditarDivida()
                {
                    DividaId = divida.DividaId,
                    NomeDivida = divida.NomeDivida,
                    ValorDivida = divida.ValorDivida,
                    DataCadastroDivida = divida.DataCadastroDivida,
                    DividaAtiva = divida.DividaAtiva

                });
            }

        }

        #endregion

        #region Classes
        private class ComboBoxEditarDivida
        {
            public int DividaId { get; set; }

            public string NomeDivida { get; set; }

            public decimal ValorDivida { get; set; }

            public bool DividaAtiva { get; set; }

            public DateTime DataCadastroDivida { get; set; }

            public override string ToString()
            {
                return NomeDivida;
            }
        }
        #endregion

    }
}
