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
            AtualizaGrid();
        }

        public void limpar()
        {
            textBoxNome.Clear();
            textBoxNumero.Clear();
            textBoxRua.Clear();
            TextBoxTelefone.Clear();
            TextBoxCnpj.Clear();
            textBoxCodigo.Visible = false;
        }

        public static DataTable ListarFornecedores()
        {
            try
            {
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                string sql = "Select codigo, nome, cnpj, rua, numero, telefone From Fornecedores";
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
            dataGridViewFornecedores.Columns[2].Width = 200;
            dataGridViewFornecedores.Columns[3].Width = 130;
            dataGridViewFornecedores.Columns[4].Width = 100;
            dataGridViewFornecedores.Columns[5].Width = 130;
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
                    else if (textBoxSenha.Text == String.Empty)
                    {
                        MessageBox.Show("INSIRA A SENHA", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        //abrir conexão
                        SqlConnection con = new SqlConnection(dados.StringConexao);
                        con.Open();
                        string sqlInserir = "INSERT INTO Fornecedores (nome, cnpj, rua, numero, telefone, senha) VALUES (@nome, @cnpj, @rua, @numero, @telefone, @senha)";
                        SqlCommand cmd = new SqlCommand(sqlInserir, con);
                        // Especificar cada campo com seu valor da tela 
                        cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = textBoxNome.Text;
                        cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = TextBoxCnpj.Text;
                        cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = textBoxRua.Text;
                        cmd.Parameters.Add("@numero", SqlDbType.Int).Value = Convert.ToInt32(textBoxNumero.Text);
                        cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = TextBoxTelefone.Text;
                        cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = textBoxSenha.Text;
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

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resp = MessageBox.Show("Deseja realmente alterar os dados do fornecedor", "sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {

                    int linha = dataGridViewFornecedores.SelectedRows[0].Index;
                    Fornecedor forn = new Fornecedor();
                    //forn.Codigo = Convert.ToInt32(textBoxCodigo.Text);
                    forn.Nome = textBoxNome.Text;
                    forn.Cnpj = TextBoxCnpj.Text;
                    forn.Rua = textBoxRua.Text;
                    forn.Numero = Convert.ToInt32(textBoxNumero.Text);
                    forn.Telefone = TextBoxTelefone.Text;
                    forn.Senha = textBoxSenha.Text;
                    //abrir conexão
                    SqlConnection con = new SqlConnection(dados.StringConexao);
                    con.Open();
                    string sqlAlterar = "UPDATE Fornecedores SET nome=@nome,cnpj=@cnpj,rua=@rua,numero=@numero,telefone=@telefone";
                    SqlCommand cmd = new SqlCommand(sqlAlterar, con);
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = forn.Codigo;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = forn.Nome;
                    cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = forn.Cnpj;
                    cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = forn.Rua;
                    cmd.Parameters.Add("@numero", SqlDbType.Int).Value = forn.Numero;
                    cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = forn.Telefone;
                    cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = forn.Senha;
                    MessageBox.Show("Fornecedor alterado com sucesso!", "Sistema\n", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


        public static Fornecedor SelecionarFornecedores(int codigo)
        {
            try
            {
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                string SqlSelecionar = "SELECT * FROM Fornecedores WHERE codigo=@codigo";
                SqlCommand cmd = new SqlCommand(SqlSelecionar, con);
                //Vai usar o codigo para fazer a busca no banco de dados
                cmd.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                //Vai percorrer a tabela fazendo a leitura dos dados
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //Seguir na sequencia do banco de dados
                    Fornecedor forn = new Fornecedor();
                    forn.Codigo = Convert.ToInt32(dr[0]);
                    forn.Nome = dr[1].ToString();
                    forn.Cnpj = dr[2].ToString();
                    forn.Rua = dr[3].ToString();
                    forn.Numero = Convert.ToInt32(dr[4]);
                    forn.Telefone = dr[5].ToString();
                    con.Close();
                    return forn;
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

            private void dataGridViewFornecedores_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //vai verificar se há uma linha selecionada no DataGridView//
                int linha = dataGridViewFornecedores.SelectedRows[0].Index;
                if (linha >= 0)
                {
                    //vai pegar o código do cliente que foi clicado//
                    int codigo = Convert.ToInt32(dataGridViewFornecedores.Rows[linha].Cells[0].Value);
                    //chamar a classe cliente com uma função//
                    Fornecedor forn = SelecionarFornecedores(codigo);
                    textBoxNome.Text = forn.Nome.ToString();
                    TextBoxCnpj.Text = forn.Cnpj.ToString();
                    TextBoxTelefone.Text = forn.Telefone.ToString();
                    textBoxRua.Text = forn.Rua.ToString();
                    textBoxNumero.Text = forn.Numero.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao tentar carregar dados");
            }
        }


        public static DataTable PesquisarFornecedor(string nome)//retorno em tipo tabela
        {
            try
            {
                SqlConnection con = new SqlConnection(dados.StringConexao);
                con.Open();
                //olhar como foi criado a tabela cliente
                string sql = "Select * From Fornecedores where nome like @nome"; //traz os dados da tabela cliente
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
            dataGridViewFornecedores.DataSource = PesquisarFornecedor(textBoxPesquisa.Text);

            dataGridViewFornecedores.Columns[0].HeaderText = "Cód";
            dataGridViewFornecedores.Columns[1].HeaderText = "Nome";
            dataGridViewFornecedores.Columns[2].HeaderText = "CNPJ";
            dataGridViewFornecedores.Columns[3].HeaderText = "Rua";
            dataGridViewFornecedores.Columns[4].HeaderText = "N°";
            dataGridViewFornecedores.Columns[5].HeaderText = "Telefone";

            //Largura das colunas
            dataGridViewFornecedores.Columns[0].Width = 50;
            dataGridViewFornecedores.Columns[1].Width = 130;
            dataGridViewFornecedores.Columns[2].Width = 250;
            dataGridViewFornecedores.Columns[3].Width = 100;
            dataGridViewFornecedores.Columns[4].Width = 50;
            dataGridViewFornecedores.Columns[5].Width = 130;

            dataGridViewFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewFornecedores.AllowUserToAddRows = false;
            dataGridViewFornecedores.AllowUserToDeleteRows = false;
            dataGridViewFornecedores.ReadOnly = true;
        }
    }
}
