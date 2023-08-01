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
            textBoxCodigo.Enabled= false;
        }

        public void limpar() {
            textBoxCidade.Clear();
            textBoxCodigo.Clear();
            textBoxNome.Clear();
            textBoxNumero.Clear();
            textBoxRua.Clear();
            textBoxCodMarca.Clear();   
            textBoxNomeMarca.Clear();
            maskedTextBoxTelefone.Clear();
            maskedTextBoxCnpj.Clear();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormMenu();
            form.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string cnpj = maskedTextBoxCnpj.Text.Replace(".", "").Replace("-", "").Replace("/", "");

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

                if (int.Parse(cnpj[12].ToString()) != digito1 || int.Parse(cnpj[13].ToString()) != digito2)
                {
                    if (textBoxNome.Text == String.Empty)
                    {
                        MessageBox.Show("INSIRA O NOME", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (maskedTextBoxTelefone.Text == String.Empty)
                    {
                        MessageBox.Show("INSIRA O TELEFONE", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (maskedTextBoxCnpj.Text == String.Empty)
                    {
                        MessageBox.Show("INSIRA O CNPJ", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(Dados.StringConexao);
                        con.Open();
                        string sqlInserir = "Insert into Fornecedores(nome, cnpj, rua, numero, telefone) values (@nome, @cnpj, @rua, @numero, @telefone)";
                        SqlCommand cmd = new SqlCommand(sqlInserir, con);
                        //especificar cada campo com seu valor da tela 
                        cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = textBoxNome.Text;
                        cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = maskedTextBoxCnpj.Text;
                        cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = textBoxRua.Text;
                        cmd.Parameters.Add("@numero", SqlDbType.Int).Value = Convert.ToInt32(textBoxNumero.Text);
                        cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = maskedTextBoxTelefone.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sistema\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        textBoxCodigo.Clear();
                        limpar();
                    }
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show("ERRO!", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpar();
            }
        }
    }
}
