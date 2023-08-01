using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Form1();
            form.Show();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormCliente();
            form.Show();
        }

        private void buttonProduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormProduto();
            form.Show();
        }

        private void buttonFornecedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormFornecedores();
            form.Show();
        }

        private void buttonMarca_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormMarcas();
            form.Show();
        }
    }
}
