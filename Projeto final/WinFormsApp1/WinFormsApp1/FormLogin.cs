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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            CarregarCliente();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        public static DataTable CarregarCliente()
        {
            try
            {
                //vai abrir conexão com o banco de dados 
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                //vai armazenar na variável sql o comando de selecionar tudo da tabela uf
                string sql = "Select * from Cliente";
                //executar o comando sql usando a string de conexão aberta 
                SqlCommand cmd = new SqlCommand(sql, con);
                //vai efetuar uma leitura dos dados
                SqlDataReader dr = cmd.ExecuteReader();
                //fazer o tratamento para tabela
                DataTable dt = new DataTable();
                //vai carregar os dados obtidos na leitura
                dt.Load(dr);
                //vai retornar as informações para comboBoxUf
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private bool AutenticarUsuario(string cpf, string senha)
        {
            using (SqlConnection connection = new SqlConnection(dados.StringConexao))
            {
                try
                {
                    connection.Open();

                    // Consultar o banco de dados para verificar se as credenciais são válidas
                    string query = "SELECT COUNT(codigo) FROM Cliente WHERE cpf = @cpf AND senha = @senha";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@cpf", cpf);
                    command.Parameters.AddWithValue("@senha", senha);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                    return false;
                }
            }
        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {

            try
            {

                string cpf = TextBoxCpf.Text;
                string senha = textBoxSenha.Text;

                if (AutenticarUsuario(cpf, senha))
                {
                    MessageBox.Show("Bem vindo!");
                    this.Hide();
                    var form = new Form1();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("CPF ou senha inválidos!");
                    TextBoxCpf.Text = string.Empty;
                    textBoxSenha.Text = string.Empty;
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
        

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            TextBoxCpf.Text = string.Empty;
            textBoxSenha.Text = string.Empty;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormCliente();
            form.Show();
        }
    }
}
