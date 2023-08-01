using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormMarcas : Form
    {
        public FormMarcas()
        {
            InitializeComponent();
            textBoxCodigo.Enabled = false;
        }

        private void limpar() {
            textBoxCodigo.Clear();
            textBoxNome.Clear();
            textBoxPesquisa.Clear();
            textBoxDescricao.Clear();
        }
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormMenu();
            form.Show();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNome.Text == String.Empty)
                {
                    MessageBox.Show("INSIRA O NOME", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SqlConnection con = new SqlConnection(Dados.StringConexao);
                    con.Open();
                    string sqlInserir = "Insert into Marca(nome, descricao) values (@nome, @descricao)";
                    SqlCommand cmd = new SqlCommand(sqlInserir, con);
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = textBoxNome.Text;
                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = textBoxDescricao.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Marca cadastrada com sucesso!", "Sistema\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    textBoxCodigo.Clear();
                    limpar();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("ERRO!", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
