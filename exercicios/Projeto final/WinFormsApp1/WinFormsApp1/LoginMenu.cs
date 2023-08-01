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
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormCliente();
            form.Show();
        }

        private void buttonFornecedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormFornecedores();
            form.Show();
        }
    }
}
