using GerenciadorGastos.BLL;
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

namespace GerenciadorGastos.Forms.Terceiros
{
    public partial class AdicionarTerceiro : Form
    {
        PessoaBLL pessoaBLL = new PessoaBLL();

        public AdicionarTerceiro()
        {
            InitializeComponent();
        }

        #region Botões
        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarPessoa();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        #endregion

        #region Funções
        private void AdicionarPessoa()
        {
            try
            {
                string nomePessoa = textBox1.Text;

                if (nomePessoa == "")
                {
                    MessageBoxHelper.ExibirMessageBox("Digite o nome do terceiro", "Atenção", "Aviso");
                    return;
                }

                pessoaBLL.AdicionarPessoa(nomePessoa);
                MessageBoxHelper.ExibirMessageBox("Terceiro adicionado com sucesso !", "Sucesso", "Info");
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBoxHelper.ExibirMessageBox($"Ocorreu um erro ao adicionar um tercerio: {ex.Message}", "Erro", "Error");
            }

        }

        #endregion


    }
}
