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
            textBoxCodigo.Visible = false;
        }

        public void AtualizaGrid()
        {

            dataGridViewMarca.DataSource = ListarMarca();

            dataGridViewMarca.Columns[0].HeaderText = "Cód";
            dataGridViewMarca.Columns[1].HeaderText = "Nome";
            dataGridViewMarca.Columns[2].HeaderText = "Descrição";


            dataGridViewMarca.Columns[0].Width = 50;
            dataGridViewMarca.Columns[1].Width = 170;
            dataGridViewMarca.Columns[2].Width = 350;

            dataGridViewMarca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewMarca.AllowUserToAddRows = false;
            dataGridViewMarca.AllowUserToDeleteRows = false; 
            dataGridViewMarca.ReadOnly = true; 
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
            try
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

                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = textBoxNome.Text;
                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = textBoxDescricao.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Marca cadastrada com sucesso!", "Sistema\n", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                    textBoxNome.Text = string.Empty;
                    textBoxDescricao.Text = string.Empty;
                    AtualizaGrid();
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
                textBoxNome.Text = string.Empty;
                textBoxDescricao.Text = string.Empty;
            }
            
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = string.Empty;
            textBoxDescricao.Text = string.Empty;
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resp = MessageBox.Show("Deseja realmente alterar os dados da marca", "sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    
                        int linha = dataGridViewMarca.SelectedRows[0].Index;
                        Marca mar = new Marca();
                        //mar.Codigo = Convert.ToInt32(textBoxCodigo.Text);
                        mar.Nome = textBoxNome.Text;
                        mar.Descricao = textBoxDescricao.Text;
                        SqlConnection con = new SqlConnection(dados.StringConexao);
                        con.Open();
                        string sqlAlterar = "UPDATE Marca SET nome=@nome,descricao=@descricao";
                        SqlCommand cmd = new SqlCommand(sqlAlterar, con);
                        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = mar.Codigo;
                        cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = mar.Nome;
                        cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = mar.Descricao;
                        MessageBox.Show("Marca alterada com sucesso!", "Sistema\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxNome.Text = string.Empty;
                        textBoxDescricao.Text = string.Empty;   

                        cmd.ExecuteNonQuery();
                        con.Close();
                        AtualizaGrid();
                    }
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable PesquisarMarca(string nome)//retorno em tipo tabela
        {
            try
            {
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                //olhar como foi criado a tabela cliente
                string sql = "Select * From Marca  where nome like @nome"; //traz os dados da tabela cliente
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@nome", SqlDbType.VarChar).Value = "%" + nome + "%";
                DataTable dt = new DataTable(); //instanciamento a classe dataTable 
                                                // carregamos as inf's do bco em tabela 
                da.Fill(dt);//preencheremos a tabela 
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            dataGridViewMarca.DataSource = PesquisarMarca(textBoxPesquisa.Text);

            dataGridViewMarca.Columns[0].HeaderText = "Cód";
            dataGridViewMarca.Columns[1].HeaderText = "Nome";
            dataGridViewMarca.Columns[2].HeaderText = "Descrição";
            //Largura das colunas
            dataGridViewMarca.Columns[0].Width = 50;
            dataGridViewMarca.Columns[1].Width = 130;
            dataGridViewMarca.Columns[2].Width = 150;

            dataGridViewMarca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        
            dataGridViewMarca.AllowUserToAddRows = false; 
            dataGridViewMarca.AllowUserToDeleteRows = false; 
            dataGridViewMarca.ReadOnly = true;
        }


        public static Marca SelecionarMarca(int codigo)
        {
            try
            {
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                string SqlSelecionar = "SELECT * FROM Marca WHERE codigo=@codigo";
                SqlCommand cmd = new SqlCommand(SqlSelecionar, con);
                //Vai usar o codigo para fazer a busca no banco de dados
                cmd.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                //Vai percorrer a tabela fazendo a leitura dos dados
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //Seguir na sequencia do banco de dados
                    Marca mar = new Marca();
                    mar.Codigo = Convert.ToInt32(dr[0]);
                    mar.Nome = dr[1].ToString();
                    mar.Descricao = dr[2].ToString();
                    
                    con.Close();
                    return mar;
                }
                else
                {
                    con.Close();
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


        private void dataGridViewMarca_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //vai verificar se há uma linha selecionada no DataGridView//
                int linha = dataGridViewMarca.SelectedRows[0].Index;
                if (linha >= 0)
                {
                    //vai pegar o código do cliente que foi clicado//
                    int codigo = Convert.ToInt32(dataGridViewMarca.Rows[linha].Cells[0].Value);
                    //chamar a classe cliente com uma função//
                    Marca mar = SelecionarMarca(codigo);
                    textBoxNome.Text = mar.Nome.ToString();
                    textBoxDescricao.Text = mar.Descricao.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao tentar carregar dados");
            }
        }
    }
}
