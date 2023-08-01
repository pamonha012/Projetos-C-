using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormCliente();
            form.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxLogin.Clear();
            textBoxSenha.Clear();
        }

            private void buttonLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxLogin.Text == string.Empty || textBoxSenha.Text == String.Empty)
                {
                    MessageBox.Show("PREENCHA TODOS OS CAMPOS", "ATENÇÃO\n", MessageBoxButtons.OK);
                }
                else if (textBoxLogin.Text.ToLower() == "admin" && textBoxSenha.Text == "12345")
                {
                    //SOCORRO
                    MessageBox.Show("Acesso OK", "Seja bem vindo!\n", MessageBoxButtons.OK);
                    this.Hide();
                    var form = new FormMenu();
                    form.Show();
                } else if (textBoxLogin.Text.ToLower() == "cliente" && textBoxSenha.Text == "123") {
                    MessageBox.Show("Acesso OK", "Seja bem vindo!\n", MessageBoxButtons.OK);
                    this.Hide();
                    var form = new Form1();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos", "ATENÇÃO\n", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
            }
        }


    } 
}
    

