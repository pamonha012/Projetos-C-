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

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxLogin.Clear();
            textBoxSenha.Clear();
            labelStatus.Text = string.Empty;
        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == string.Empty || textBoxSenha.Text == String.Empty)
            {
                labelStatus.Text = "Preencha os campos";
                labelStatus.ForeColor = Color.Blue;
            }
            else if (textBoxLogin.Text.ToLower() == "admin" && textBoxSenha.Text == "12345")
            {
                labelStatus.Text = "Acesso OK";
                labelStatus.ForeColor = Color.Green;
                this.Hide();
                var form = new Form1();
                form.Show();
            }
            else
            {
                labelStatus.Text = "Usuário ou senha inválidos";
                labelStatus.ForeColor = Color.Red;
            }

        }

    } 
}
    

