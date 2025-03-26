using GerenciadorGastos.BLL;
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

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarPessoa();
        }

        private void AdicionarPessoa()
        {
            try
            {
                string nomePessoa = textBox1.Text;

                pessoaBLL.AdicionarPessoa(nomePessoa);

                this.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
