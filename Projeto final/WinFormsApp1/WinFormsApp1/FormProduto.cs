using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
            comboBoxMarcas.DataSource = CarregarMarcas();
            comboBoxMarcas.DisplayMember = "nome";
            comboBoxMarcas.ValueMember = "codigo";
            comboBoxFornecedor.DataSource = CarregarFornecedores();
            comboBoxFornecedor.DisplayMember = "nome";
            comboBoxFornecedor.ValueMember = "codigo";
            AtualizaGrid();
            textBoxCodigo.Visible = false;
        }

        public static DataTable CarregarMarcas()
        {
            try
            {
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                string sql = "Select * from Marca";
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

        public void Limpar()
        {
            textBoxDescricao.Clear();
            textBoxNome.Clear();
            textBoxEssencia.Clear();
            textBoxQuantidade.Clear();
            textBoxValorUni.Clear();
            comboBoxFornecedor.SelectedIndex = 0;
            comboBoxMarcas.SelectedIndex = 0;
            textBoxPesquisa.Clear();
        }


        public static DataTable CarregarFornecedores()
        {
            try
            {
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                string sql = "Select * from Fornecedores";
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

        #region botão voltar
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Form1();
            form.Show();
        }
        #endregion
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNome.Text == string.Empty)
                {
                    MessageBox.Show("INSIRA O NOME", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (textBoxEssencia.Text == string.Empty)
                {
                    MessageBox.Show("INSIRA A ESSÊNCIA", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (textBoxValorUni.Text == string.Empty)
                {
                    MessageBox.Show("INSIRA O VALOR", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (textBoxQuantidade.Text == string.Empty)
                {
                    MessageBox.Show("INSIRA A QUANTIDADE", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Produto prod = new Produto();
                    prod.Fornecedor = Convert.ToInt32(comboBoxFornecedor.SelectedValue);
                    prod.Marca = Convert.ToInt32(comboBoxMarcas.SelectedValue);
                    prod.Nome = textBoxNome.Text;
                    prod.Essencia = textBoxEssencia.Text;
                    prod.Descricao = textBoxDescricao.Text;
                    prod.Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                    prod.ValorUni = Convert.ToInt32(textBoxValorUni.Text);
                    //abrir conexão
                    SqlConnection con = new SqlConnection(dados.StringConexao);
                    con.Open();
                    string sqlInserir = "INSERT INTO produto(Fornecedores_codigo,Marca_codigo,nome, essencia, descricao, quantidade, valor_unitario) VALUES (@fornecedor, @marca, @nome, @essencia, @descricao, @quantidade, @valor)";

                    SqlCommand cmd = new SqlCommand(sqlInserir, con);
                    cmd.Parameters.Add("@fornecedor", SqlDbType.Int).Value = prod.Fornecedor;
                    cmd.Parameters.Add("@marca", SqlDbType.Int).Value = prod.Marca;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = prod.Nome;
                    cmd.Parameters.Add("@essencia", SqlDbType.VarChar).Value = prod.Essencia;
                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = prod.Descricao;
                    cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = prod.Quantidade;
                    cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = prod.ValorUni;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sistema\n", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                    Limpar();
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
                textBoxNome.Text = string.Empty;
                textBoxDescricao.Text = string.Empty;
            }
        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }


        public static DataTable PesquisarProduto(string nome)//retorno em tipo tabela
        {
            try
            {
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                //olhar como foi criado a tabela cliente
                string sql = "SELECT Produto.* FROM Produto where nome like @nome"; //traz os dados da tabela cliente
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
            //o comando dataSource faz com que os dados vindos do ListarClientes();
            //carregue o dataGride do cliente
            dataGridViewProduto.DataSource = PesquisarProduto(textBoxPesquisa.Text);
            //Montando o DataGrid com o cabeçalho e largura das colunas = tabela
            dataGridViewProduto.Columns[0].HeaderText = "Cód";
            dataGridViewProduto.Columns[1].HeaderText = "Nome";
            dataGridViewProduto.Columns[2].HeaderText = "Essência";
            dataGridViewProduto.Columns[3].HeaderText = "Descrição";
            dataGridViewProduto.Columns[4].HeaderText = "Quant.";
            dataGridViewProduto.Columns[5].HeaderText = "Valor Uni.";
            dataGridViewProduto.Columns[6].HeaderText = "Fornecedor";
            dataGridViewProduto.Columns[7].HeaderText = "Marca";

            //Largura das colunas
            dataGridViewProduto.Columns[0].Width = 50;
            dataGridViewProduto.Columns[1].Width = 150;
            dataGridViewProduto.Columns[2].Width = 150;
            dataGridViewProduto.Columns[3].Width = 170;
            dataGridViewProduto.Columns[4].Width = 100;
            dataGridViewProduto.Columns[5].Width = 100;
            dataGridViewProduto.Columns[6].Width = 150;
            dataGridViewProduto.Columns[7].Width = 150;
            //propriedades importantes do dataGrid
            //faz com que seja selecionada a linha toda do dataGrid
            dataGridViewProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //permissões do usuário 
            dataGridViewProduto.AllowUserToAddRows = false; //usuário não pode adicionar 
            dataGridViewProduto.AllowUserToDeleteRows = false; //usuário não pode deletar linhas 
            dataGridViewProduto.ReadOnly = true; //deixará o dataGrid para apenas leitura
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }


        public static DataTable ListarProduto()//retorno em tipo tabela
        {
            try { 
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                

                //olhar como foi criado a tabela cliente
                string sql = "SELECT Produto.codigo ,Produto.nome, Produto.essencia, Produto.descricao, Produto.quantidade, Produto.valor_unitario, Fornecedores.nome, Marca.nome FROM Produto INNER JOIN Fornecedores ON produto.Fornecedores_codigo = Fornecedores.codigo INNER JOIN Marca ON Produto.Marca_codigo = Marca.codigo"; //traz os dados da tabela produto 
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
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

        public void AtualizaGrid()
        {
            //o comando dataSource faz com que os dados vindos do ListarClientes();
            //carregue o dataGride do cliente
            dataGridViewProduto.DataSource = ListarProduto();
            //Montando o DataGrid com o cabeçalho e largura das colunas = tabela
            dataGridViewProduto.Columns[0].HeaderText = "Cód";
            dataGridViewProduto.Columns[1].HeaderText = "Nome";
            dataGridViewProduto.Columns[2].HeaderText = "Essência";
            dataGridViewProduto.Columns[3].HeaderText = "Descrição";
            dataGridViewProduto.Columns[4].HeaderText = "Quant.";
            dataGridViewProduto.Columns[5].HeaderText = "Valor Uni.";
            dataGridViewProduto.Columns[6].HeaderText = "Fornecedor";
            dataGridViewProduto.Columns[7].HeaderText = "Marca";

            //Largura das colunas
            dataGridViewProduto.Columns[0].Width = 50;
            dataGridViewProduto.Columns[1].Width = 150;
            dataGridViewProduto.Columns[2].Width = 150;
            dataGridViewProduto.Columns[3].Width = 170;
            dataGridViewProduto.Columns[4].Width = 100;
            dataGridViewProduto.Columns[5].Width = 100;
            dataGridViewProduto.Columns[6].Width = 150;
            dataGridViewProduto.Columns[7].Width = 150;

            //propriedades importantes do dataGrid
            //faz com que seja selecionada a linha toda do dataGrid
            dataGridViewProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //permissões do usuário 
            dataGridViewProduto.AllowUserToAddRows = false; //usuário não pode adicionar 
            dataGridViewProduto.AllowUserToDeleteRows = false; //usuário não pode deletar linhas 
            dataGridViewProduto.ReadOnly = true; //deixará o dataGrid para apenas leitura
        }


        public static Produto SelecionarProduto(int codigo)
        {
            try
            {
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                string SqlSelecionar = "SELECT * FROM Produto WHERE codigo=@codigo";
                SqlCommand cmd = new SqlCommand(SqlSelecionar, con);
                //Vai usar o codigo para fazer a busca no banco de dados
                cmd.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                //Vai percorrer a tabela fazendo a leitura dos dados
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //Seguir na sequencia do banco de dados
                    Produto prod = new Produto();
                    prod.Codigo = Convert.ToInt32(dr[0]);
                    prod.Fornecedor = Convert.ToInt32(dr[1]);
                    prod.Marca = Convert.ToInt32(dr[2]);
                    prod.Nome = dr[3].ToString();
                    prod.Essencia = dr[4].ToString();
                    prod.Descricao = dr[5].ToString();
                    prod.Quantidade = Convert.ToInt32(dr[6]);
                    prod.ValorUni = Convert.ToDecimal(dr[7]);
                    con.Close();
                    return prod;
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

        private void dataGridViewProduto_MouseClick(object sender, MouseEventArgs e)
        {

            //ao clicar no DataGridView vai selecionar o cliente//
            try
            {
                //vai verificar se há uma linha selecionada no DataGridView//
                int linha = dataGridViewProduto.SelectedRows[0].Index;
                if (linha >= 0)
                {
                    //vai pegar o código do cliente que foi clicado//
                    int codigo = Convert.ToInt32(dataGridViewProduto.Rows[linha].Cells[0].Value);
                    //chamar a classe cliente com uma função//
                    Produto prod = SelecionarProduto(codigo);
                    comboBoxFornecedor.Text = prod.Fornecedor.ToString();
                    comboBoxMarcas.Text = prod.Marca.ToString();
                    textBoxNome.Text = prod.Nome.ToString();
                    textBoxEssencia.Text = prod.Essencia.ToString();
                    textBoxDescricao.Text = prod.Descricao.ToString();
                    textBoxQuantidade.Text = prod.Quantidade.ToString();
                    textBoxValorUni.Text = prod.ValorUni.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao tentar carregar dados");
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resp = MessageBox.Show("Deseja realmente alterar os dados do cliente", "sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Vai perguntar se deseja realmente alterar
                        //vai iniciar capturando os dados alterados nos campos da tela e alterar no banco de dados
                        int linha = dataGridViewProduto.SelectedRows[0].Index;
                        Produto prod = new Produto();
                        //prod.Codigo = Convert.ToInt32(textBoxCodigo.Text);
                        prod.Nome = textBoxNome.Text;
                        prod.Essencia = textBoxEssencia.Text;
                        prod.Descricao= textBoxDescricao.Text;
                        prod.Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                        prod.ValorUni = Convert.ToDecimal(textBoxValorUni.Text);
                        //abrir conexão
                        SqlConnection con = new SqlConnection(dados.StringConexao);
                        con.Open();
                        string sqlAlterar = "UPDATE Produto SET nome=@nome,essencia=@essencia,descricao=@descricao,quantidade=@quantidade,valor_unitario=@valor";
                        SqlCommand cmd = new SqlCommand(sqlAlterar, con);
                        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = prod.Codigo;
                        cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = prod.Nome;
                        cmd.Parameters.Add("@essencia", SqlDbType.VarChar).Value = prod.Essencia;
                        cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = prod.Descricao;
                        cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = prod.Quantidade;
                        cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = prod.ValorUni;
                        MessageBox.Show("Produto alterado com sucesso!", "Sistema\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        AtualizaGrid();
                        Limpar();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
