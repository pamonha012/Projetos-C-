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
    public partial class FormFornecedores : Form
    {
        public FormFornecedores()
        {
            InitializeComponent();
        }

        public void limpar()
        {
            textBoxNome.Clear();
            textBoxNumero.Clear();
            textBoxRua.Clear();
            TextBoxTelefone.Clear();
            TextBoxCnpj.Clear();
        }

        public static DataTable ListarFornecedores()
        {
            try
            {
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                string sql = "Select * From Fornecedores";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }
        public void AtualizaGrid()
        {
            dataGridViewFornecedores.DataSource = ListarFornecedores();
            dataGridViewFornecedores.Columns[0].HeaderText = "Cód";
            dataGridViewFornecedores.Columns[1].HeaderText = "Nome";
            dataGridViewFornecedores.Columns[2].HeaderText = "CNPJ";
            dataGridViewFornecedores.Columns[3].HeaderText = "Rua";
            dataGridViewFornecedores.Columns[4].HeaderText = "Nº";
            dataGridViewFornecedores.Columns[5].HeaderText = "Telefone";
            //Largura das colunas
            dataGridViewFornecedores.Columns[0].Width = 50;
            dataGridViewFornecedores.Columns[1].Width = 130;
            dataGridViewFornecedores.Columns[2].Width = 150;
            dataGridViewFornecedores.Columns[3].Width = 130;
            dataGridViewFornecedores.Columns[4].Width = 100;
            dataGridViewFornecedores.Columns[5].Width = 100;
            //propriedades importantes do dataGrid
            //faz com que seja selecionada a linha toda do dataGrid
            dataGridViewFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //permissões do usuário 
            dataGridViewFornecedores.AllowUserToAddRows = false; //usuário não pode adicionar 
            dataGridViewFornecedores.AllowUserToDeleteRows = false; //usuário não pode deletar linhas 
            dataGridViewFornecedores.ReadOnly = true; //deixará o dataGrid para apenas leitura
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Form1();
            form.Show();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string cnpj = TextBoxCnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "");

                if (cnpj.Length != 14)
                {
                    MessageBox.Show("CNPJ inválido.");
                    return;
                }

                int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                string cnpjSemDigito = cnpj.Substring(0, 12);

                int soma = 0;
                for (int i = 0; i < 12; i++)
                {
                    soma += int.Parse(cnpjSemDigito[i].ToString()) * multiplicadores1[i];
                }

                int resto = soma % 11;
                int digito1 = resto < 2 ? 0 : 11 - resto;

                cnpjSemDigito += digito1;
                soma = 0;

                for (int i = 0; i < 13; i++)
                {
                    soma += int.Parse(cnpjSemDigito[i].ToString()) * multiplicadores2[i];
                }

                resto = soma % 11;
                int digito2 = resto < 2 ? 0 : 11 - resto;

                if (digito1 == int.Parse(cnpj[12].ToString()) && digito2 == int.Parse(cnpj[13].ToString()))
                {
                    if (textBoxNome.Text == String.Empty)
                    {
                        MessageBox.Show("INSIRA O NOME", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (TextBoxTelefone.Text == String.Empty)
                    {
                        MessageBox.Show("INSIRA O TELEFONE", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (TextBoxCnpj.Text == String.Empty)
                    {
                        MessageBox.Show("INSIRA O CNPJ", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(dados.StringConexao);
                        con.Open();
                        string sqlInserir = "INSERT INTO Fornecedores (nome, cnpj, rua, numero, telefone) VALUES (@nome, @cnpj, @rua, @numero, @telefone)";
                        SqlCommand cmd = new SqlCommand(sqlInserir, con);
                        // Especificar cada campo com seu valor da tela 
                        cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = textBoxNome.Text;
                        cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = TextBoxCnpj.Text;
                        cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = textBoxRua.Text;
                        cmd.Parameters.Add("@numero", SqlDbType.Int).Value = Convert.ToInt32(textBoxNumero.Text);
                        cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = TextBoxTelefone.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sistema\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        limpar();
                        AtualizaGrid();
                    }
                }
                else
                {
                    MessageBox.Show("CNPJ inválido.");
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show("ERRO!", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpar();
            }

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
