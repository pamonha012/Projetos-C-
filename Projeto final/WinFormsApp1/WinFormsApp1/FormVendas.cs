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
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
            comboBoxMarca.SelectedItem = "Selecionar marca";
            comboBoxProduto.SelectedItem = "Selecionar Produto";
            textBoxVista.Enabled = false;
            textBox3.Enabled = false;
            textBox6.Enabled = false;
            textBox10.Enabled = false;
            radioButtonVista.Enabled = false;
            radioButton3.Enabled = false;
            radioButton6.Enabled = false;
            radioButton10.Enabled = false;
            TextBoxValorUni.Enabled = false;
            TextBoxSubTotal.Enabled = false;
            TextBoxTotal.Enabled = false;
            buttonCalcular.Enabled = false;
            radioButtonCredito.Enabled = false;
            radioButtonDinheiro.Enabled = false;

            comboBoxProduto.DataSource = CarregarProduto();
            comboBoxProduto.DisplayMember = "nome";
            comboBoxProduto.ValueMember = "codigo";

            comboBoxMarca.DataSource = CarregarMarca();
            comboBoxMarca.DisplayMember = "nome";
            comboBoxMarca.ValueMember = "codigo";
        }

        public static DataTable CarregarMarca()
        {
            try
            {
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                string sql = "Select * from Marca;";
                SqlCommand cmd = new SqlCommand(sql, con);
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

        public static DataTable CarregarProduto()
        {
            try
            {
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                string sql = "Select * from Produto;";
                SqlCommand cmd = new SqlCommand(sql, con);
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

        public void limpar()
        {
            TextBoxValorUni.Clear();
            textBoxQuantidade.Clear();
            TextBoxSubTotal.Clear();
            radioButtonCredito.Checked = false;
            radioButtonDinheiro.Checked = false;
            radioButtonVista.Checked = false;
            radioButton3.Checked = false;
            radioButton6.Checked = false;
            radioButton10.Checked = false;
            buttonCalcular.Enabled = false;
            radioButtonVista.Enabled = false;
            radioButton3.Enabled = false;
            radioButton6.Enabled = false;
            radioButton10.Enabled = false;
        }

        public void limparQuant()
        {
            TextBoxSubTotal.Clear();
            radioButtonCredito.Checked = false;
            radioButtonDinheiro.Checked = false;
            radioButtonVista.Checked = false;
            radioButton3.Checked = false;
            radioButton6.Checked = false;
            radioButton10.Checked = false;
            buttonCalcular.Enabled = false;
            radioButtonVista.Enabled = false;
            radioButton3.Enabled = false;
            radioButton6.Enabled = false;
            radioButton10.Enabled = false;
        }
        private void buttonVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Form1();
            form.Show();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limpar();
            TextBoxValorUni.Clear();
            TextBoxTotal.Clear();
            textBox10.Clear();
            textBox3.Clear();
            textBox6.Clear();
            textBoxVista.Clear();
            labelResultado.Text = string.Empty;
            comboBoxMarca.SelectedIndex = 0;
            comboBoxProduto.SelectedIndex = -1;
            buttonCalcular.Enabled = false;
        }
    }
}
