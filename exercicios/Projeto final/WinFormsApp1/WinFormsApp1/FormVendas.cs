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
        decimal valorUni, quantidade, subTotal, total;
        private int produtoId = 1; // ID do produto a ser comprado
        public FormVendas()
        {
            InitializeComponent();
            TextBoxValorUni.Enabled = false;
            TextBoxSubTotal.Enabled = false;
            TextBoxTotal.Enabled = false;
            buttonCalcula.Enabled = false;
            AtualizaGrid();
            toolStripStatusLabelData.Text = DateTime.Now.ToLongDateString();
        }

        public void limpar()
        {
            TextBoxValorUni.Clear();
            textBoxQuantidade.Clear();
            TextBoxSubTotal.Clear();
            buttonCalcula.Enabled = false;
            textBoxCodigo.Clear();
        }

        public void limparQuant()
        {
            TextBoxSubTotal.Clear();
            buttonCalcula.Enabled = false;
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
            labelResultado.Text = string.Empty;
            buttonCalcula.Enabled = false;
        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    prod.Marca = Convert.ToInt32(dr[2]);
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

        public static DataTable ListarProduto()//retorno em tipo tabela
        {
            try
            {
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

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                quantidade = Convert.ToDecimal(textBoxQuantidade.Text);
                valorUni = Convert.ToDecimal(TextBoxValorUni.Text);
                subTotal = quantidade * valorUni;
                TextBoxSubTotal.Text = subTotal.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void buttonCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                //if (textBoxQuantidade.Text == string.Empty)
                //{
                //    MessageBox.Show("INSIRA A QUANTIDADE", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
                //else
                //{
                    //Venda ven = new Venda();
                    //ven.Cliente = Convert.ToInt32(textBoxCodigo.Text);
                    //ven.Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                    //ven.Valor = Convert.ToDecimal(TextBoxTotal.Text);
                    ////abrir conexão
                    //SqlConnection conn = new SqlConnection(dados.StringConexao);
                    //conn.Open();
                    //string sqlInserir = "INSERT INTO Vendas(Cliente_codigo, quantidade, valor_total) VALUES (@cliente, @quantidade, @valor)";
                    //SqlCommand cmd = new SqlCommand(sqlInserir, conn);
                    //cmd.Parameters.Add("@cliente", SqlDbType.Int).Value = ven.Cliente;
                    //cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = ven.Quantidade;
                    //cmd.Parameters.Add("@valor", SqlDbType.Decimal).Value = ven.Valor;
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Compra realizada com sucesso!");
                    //conn.Close();


                    int quantidadeDesejada = Convert.ToInt32(textBoxQuantidade.Text);
                    SqlConnection con = new SqlConnection(dados.StringConexao);
                    con.Open();
                    string selectQuantidadeQuery = "SELECT quantidade FROM Produto WHERE codigo = @codigo";
                    using (SqlConnection connection = new SqlConnection(dados.StringConexao))
                    {
                        connection.Open();
                        // Consulta para obter a quantidade em estoque do produto

                        using (SqlCommand selectQuantidadeCommand = new SqlCommand(selectQuantidadeQuery, connection))
                        {
                            selectQuantidadeCommand.Parameters.AddWithValue("@codigo", produtoId);
                            int quantidadeAtualEmEstoque = Convert.ToInt32(selectQuantidadeCommand.ExecuteScalar());
                            // Verificar se há quantidade suficiente em estoque
                            if (quantidadeAtualEmEstoque >= quantidadeDesejada)
                            {
                                // Calcular nova quantidade em estoque após a compra
                                int novaQuantidadeEmEstoque = quantidadeAtualEmEstoque - quantidadeDesejada;
                                // Atualizar a quantidade em estoque no banco de dados
                                string updateQuantidadeQuery = "UPDATE Produto SET quantidade = @NovaQuantidade WHERE codigo = @codigo";

                                using (SqlCommand updateQuantidadeCommand = new SqlCommand(updateQuantidadeQuery, connection))
                                {
                                    updateQuantidadeCommand.Parameters.AddWithValue("@NovaQuantidade", novaQuantidadeEmEstoque);
                                    updateQuantidadeCommand.Parameters.AddWithValue("@codigo", produtoId);
                                    updateQuantidadeCommand.ExecuteNonQuery();
                                    MessageBox.Show("Compra realizada com sucesso!");
                                    AtualizaGrid(); 
                                }
                            }
                            else
                            {
                                MessageBox.Show("Compra realizada com sucesso!");
                            }
                        }
                    }

                    decimal quantidade = Convert.ToDecimal(textBoxQuantidade.Text);
                    decimal valorUni = Convert.ToDecimal(TextBoxValorUni.Text);
                    decimal subTotal = quantidade * valorUni;
                    decimal total = subTotal;
                    TextBoxTotal.Text = subTotal.ToString();

                    labelResultado.Text = " Nota fiscal:\n" +
                                          " Quantidade: " + textBoxQuantidade.Text + "\n" +
                                          " Valor total: " + total.ToString("C") + "\n" +
                                          " Data: " + DateTime.Now.ToShortDateString() + "\n" +
                                          " Hora: " + DateTime.Now.ToShortTimeString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHora.Text = DateTime.Now.ToLongTimeString();
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

        private void dataGridViewProduto_MouseClick(object sender, MouseEventArgs e)
        {
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
                    TextBoxValorUni.Text = prod.ValorUni.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao tentar carregar dados");
            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            
        }
    }
}
