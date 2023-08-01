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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
            textBoxCodigo.Enabled= false;
            comboBoxFornecedor.DataSource = CarregarFornecedor();
            comboBoxFornecedor.DisplayMember = "nome";
            comboBoxFornecedor.ValueMember = "id_fornecedor";

            comboBoxMarcas.DataSource = CarregarMarca();
            comboBoxMarcas.DisplayMember = "nome";
            comboBoxMarcas.ValueMember = "id_marca";
        }

        public void Limpar() {

            textBoxQuantidade.Clear();
            textBoxCodigo.Clear();
            textBoxDescricao.Clear();
            textBoxValorUni.Clear();
            textBoxNome.Clear();
        }

        public static DataTable CarregarFornecedor()
        {
            try
            {
                SqlConnection con = new SqlConnection(Dados.StringConexao);
                con.Open();
                string sqlFornecedor = "Select * from Fornecedores";
                SqlCommand cmd = new SqlCommand(sqlFornecedor, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public static DataTable CarregarMarca()
        {
            try
            {
                SqlConnection con = new SqlConnection(Dados.StringConexao);
                con.Open();
                string sqlMarca = "Select * from Marca";
                SqlCommand cmd = new SqlCommand(sqlMarca, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormMenu();
            form.Show();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNome.Text == String.Empty)
                {
                    MessageBox.Show("INSIRA O NOME", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(textBoxQuantidade.Text == String.Empty) {
                    MessageBox.Show("INSIRA A QUANTIDADE", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (textBoxValorUni.Text == String.Empty)
                {
                    MessageBox.Show("INSIRA O VALOR", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    SqlConnection con = new SqlConnection(Dados.StringConexao);
                    con.Open();
                    string sqlInserir = "Insert into Produto(Fornecedores_id_fornecedor, Marca_id_marca, nome, quantidade, valor_unitario, descricao) values (@idfornecedor, @idmarca, @nome, @quantidade, @valor, @descricao)";
                    SqlCommand cmd = new SqlCommand(sqlInserir, con);
                    cmd.Parameters.Add("@idfornecedor", SqlDbType.Int).Value = Convert.ToInt32(comboBoxFornecedor.SelectedValue);
                    cmd.Parameters.Add("@idmarca", SqlDbType.Int).Value = Convert.ToInt32(comboBoxMarcas.SelectedValue);
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = textBoxNome.Text;
                    cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(textBoxQuantidade.Text);
                    cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = Convert.ToDecimal(textBoxValorUni.Text);
                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = textBoxDescricao.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Porduto cadastrado com sucesso!", "Sistema\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    textBoxCodigo.Clear();
                    Limpar();
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
