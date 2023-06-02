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
            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            //o comando dataSource faz com que os dados vindos do ListarClientes();
            //carregue o dataGride do cliente
            dataGridViewMarca.DataSource = ListarMarca();
            //Montando o DataGrid com o cabeçalho e largura das colunas = tabela
            dataGridViewMarca.Columns[0].HeaderText = "Cód";
            dataGridViewMarca.Columns[1].HeaderText = "Nome";
            dataGridViewMarca.Columns[2].HeaderText = "Descrição";

            //Largura das colunas
            dataGridViewMarca.Columns[0].Width = 50;
            dataGridViewMarca.Columns[1].Width = 130;
            dataGridViewMarca.Columns[2].Width = 250;

            //propriedades importantes do dataGrid
            //faz com que seja selecionada a linha toda do dataGrid
            dataGridViewMarca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //permissões do usuário 
            dataGridViewMarca.AllowUserToAddRows = false; //usuário não pode adicionar 
            dataGridViewMarca.AllowUserToDeleteRows = false; //usuário não pode deletar linhas 
            dataGridViewMarca.ReadOnly = true; //deixará o dataGrid para apenas leitura
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Form1();
            form.Show();
        }

        public static DataTable ListarMarca()
        {
            try
            {
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                string sql = "Select * From Marca";
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

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == string.Empty)
            {
                MessageBox.Show("INSIRA O NOME", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                string sqlInserir = "INSERT INTO Marca (nome, descricao) VALUES (@nome, @descricao)";
                SqlCommand cmd = new SqlCommand(sqlInserir, con);
                // Especificar cada campo com seu valor da tela 
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = textBoxNome.Text;
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = textBoxDescricao.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Marca cadastrada com sucesso!", "Sistema\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = string.Empty;
            textBoxDescricao.Text = string.Empty;
        }
    }
}
