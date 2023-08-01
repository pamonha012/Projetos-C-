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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
            textBoxCodigo.Enabled = false;
            //Vai carregar o comboBoxEstado
            comboBoxEstado.DataSource = CarregarUF();
            //exibir a sigla da UF
            comboBoxEstado.DisplayMember = "sigla";
            //valor do elemento uf
            comboBoxEstado.ValueMember = "id_uf";
            AtualizaGrid();
        }

        public void AtualizaGrid()
        {
            //o comando dataSource faz com que os dados vindos do ListarClientes();
            //carregue o dataGride do cliente
            dataGridViewCliente.DataSource = ListarCliente();
            //Montando o DataGrid com o cabeçalho e largura das colunas = tabela
            dataGridViewCliente.Columns[0].HeaderText = "Cód";
            dataGridViewCliente.Columns[1].HeaderText = "Nome";
            dataGridViewCliente.Columns[2].HeaderText = "CPF";
            dataGridViewCliente.Columns[3].HeaderText = "CEP";
            dataGridViewCliente.Columns[4].HeaderText = "Rua";
            dataGridViewCliente.Columns[5].HeaderText = "Nº";
            dataGridViewCliente.Columns[6].HeaderText = "Cidade";
            dataGridViewCliente.Columns[7].HeaderText = "UF";
            dataGridViewCliente.Columns[8].HeaderText = "Telefone";
            dataGridViewCliente.Columns[9].HeaderText = "Dt Nascimento";
            //Largura das colunas
            dataGridViewCliente.Columns[0].Width = 50;
            dataGridViewCliente.Columns[1].Width = 250;
            dataGridViewCliente.Columns[2].Width = 150;
            dataGridViewCliente.Columns[3].Width = 150;
            dataGridViewCliente.Columns[4].Width = 60;
            dataGridViewCliente.Columns[5].Width = 100;
            dataGridViewCliente.Columns[6].Width = 100;
            dataGridViewCliente.Columns[7].Width = 50;
            dataGridViewCliente.Columns[8].Width = 90;
            dataGridViewCliente.Columns[9].Width = 50;
            //propriedades importantes do dataGrid
            //faz com que seja selecionada a linha toda do dataGrid
            dataGridViewCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //permissões do usuário 
            dataGridViewCliente.AllowUserToAddRows = false; //usuário não pode adicionar 
            dataGridViewCliente.AllowUserToDeleteRows = false; //usuário não pode deletar linhas 
            dataGridViewCliente.ReadOnly = true; //deixará o dataGrid para apenas leitura
        }

        public static DataTable ListarCliente()//retorno em tipo tabela
        {
            try
            {
                SqlConnection con = new SqlConnection(Dados.StringConexao);
                con.Open();
                //olhar como foi criado a tabela cliente
                string sql = "Select * From Cliente"; //traz os dados da tabela cliente
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

        public static DataTable PesquisarCliente(string nome)//retorno em tipo tabela
        {
            try
            {
                SqlConnection con = new SqlConnection(Dados.StringConexao);
                con.Open();
                //olhar como foi criado a tabela cliente
                string sql = "Select * From Cliente where nome like @nome"; //traz os dados da tabela cliente
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

        public void Limpar() {
            textBoxCidade.Clear();
            textBoxCodigo.Clear();
            textBoxNome.Clear();
            textBoxNumero.Clear();
            textBoxRua.Clear();
            maskedTextBoxTelefone.Clear();
            maskedTextBoxCpf.Clear();
            maskedTextBoxDtNasc.Clear();
            maskedTextBoxCep.Clear();
            comboBoxEstado.SelectedIndex = 0;
            textBoxPesquisa.Clear();
        }
        public static DataTable CarregarUF() {
            try
            {
                //vai abrir conexão com o banco de dados 
                SqlConnection con = new SqlConnection(Dados.StringConexao);
                con.Open();
                //vai armazenar na variável sql o comando de selecionar tudo da tabela uf
                string sql = "Select * from Estado";
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
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                string cpf = maskedTextBoxCpf.Text.Replace(".", "").Replace("-", "");

                if (cpf.Length != 11)
                {
                    MessageBox.Show("CPF inválido.");
                    return;
                }
                int[] multiplicadores1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicadores2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string cpfSemDigito = cpf.Substring(0, 9);

                int soma = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(cpfSemDigito[i].ToString()) * multiplicadores1[i];
                }

                int resto = soma % 11;
                int digito1 = resto < 2 ? 0 : 11 - resto;

                cpfSemDigito += digito1;
                soma = 0;

                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(cpfSemDigito[i].ToString()) * multiplicadores2[i];
                }

                resto = soma % 11;
                int digito2 = resto < 2 ? 0 : 11 - resto;

                if (digito1 == int.Parse(cpf[9].ToString()) && digito2 == int.Parse(cpf[10].ToString()))
                {
                    if (textBoxNome.Text == String.Empty)
                    {
                        MessageBox.Show("INSIRA O NOME", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (maskedTextBoxTelefone.Text == String.Empty)
                    {
                        MessageBox.Show("INSIRA O TELEFONE", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (maskedTextBoxCep.Text == String.Empty)
                    {
                        MessageBox.Show("INSIRA O CEP", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (comboBoxEstado.SelectedIndex < 0)
                    {
                        MessageBox.Show("INFORME O ESTADO", "ATENÇÃO\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        SqlConnection con = new SqlConnection(Dados.StringConexao);
                        con.Open();
                        string sqlInserir = "Insert into Cliente(nome, cpf, cep, rua, numero_casa, cidade, uf, telefone, dt_nascimento) values (@nome, @cpf, @cep, @rua, @numero, @cidade, @uf, @telefone, @dt_nascimento)";
                        SqlCommand cmd = new SqlCommand(sqlInserir, con);
                        //especificar cada campo com seu valor da tela 
                        cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = textBoxNome.Text;
                        cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = maskedTextBoxCpf.Text;
                        cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = maskedTextBoxCep.Text;
                        cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = textBoxRua.Text;
                        cmd.Parameters.Add("@numero", SqlDbType.Int).Value = Convert.ToInt32(textBoxNumero.Text);
                        cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = textBoxCidade.Text;
                        cmd.Parameters.Add("@uf", SqlDbType.VarChar).Value = comboBoxEstado.Text;
                        cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = maskedTextBoxTelefone.Text;
                        cmd.Parameters.Add("@dt_nascimento", SqlDbType.Date).Value = Convert.ToDateTime(maskedTextBoxDtNasc.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Sistema\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        Limpar();
                    }
                }
                else
                {
                    MessageBox.Show("CPF inválido.");
                }


            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
                Limpar();
            }

        }

        private void dataGridViewCliente_MouseClick(object sender, MouseEventArgs e)
        {
            //ao clicar no DataGridView vai selecionar o cliente//
            try
            {
                //vai verificar se há uma linha selecionada no DataGridView//
                int linha = dataGridViewCliente.SelectedRows[0].Index;
                if (linha >= 0)
                {
                    //vai pegar o código do cliente que foi clicado//
                    int codigo = Convert.ToInt32(dataGridViewCliente.Rows[linha].Cells[0].Value);
                    //chamar a classe cliente com uma função//
                    Cliente cli = SelecionarCliente(codigo);
                    textBoxCodigo.Text = cli.Codigo.ToString();
                    textBoxNome.Text = cli.Nome.ToString();
                    maskedTextBoxCep.Text = cli.Cep.ToString();
                    maskedTextBoxCpf.Text = cli.Cpf.ToString();
                    maskedTextBoxTelefone.Text = cli.Telefone.ToString();
                    textBoxRua.Text = cli.Rua.ToString();
                    textBoxNumero.Text = cli.Numero.ToString();
                    textBoxCidade.Text = cli.Numero.ToString();
                    comboBoxEstado.Text = cli.Uf.ToString();
                    maskedTextBoxDtNasc.Text = cli.DataNasc.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao tentar carregar dados");
            }
        }

        public static Cliente SelecionarCliente(int codigo)
        {
            try{
                SqlConnection con = new SqlConnection(Dados.StringConexao);
                con.Open();
                string SqlSelecionar = "SELECT * FROM Cliente WHERE id_cliente=@codigo";
                SqlCommand cmd = new SqlCommand(SqlSelecionar, con);
                //Vai usar o codigo para fazer a busca no banco de dados
                cmd.Parameters.Add("codigo", SqlDbType.Int).Value = codigo;
                //Vai percorrer a tabela fazendo a leitura dos dados
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //Seguir na sequencia do banco de dados
                    Cliente cli = new Cliente();
                    cli.Codigo = Convert.ToInt32(dr[0]);
                    cli.Nome = dr[1].ToString();
                    cli.Cpf = dr[2].ToString();
                    cli.Cep = dr[3].ToString();
                    cli.Rua = dr[4].ToString();
                    cli.Numero = Convert.ToInt32(dr[5]);
                    cli.Cidade = dr[6].ToString();
                    cli.Uf = dr[7].ToString();
                    cli.Telefone = dr[8].ToString();
                    cli.DataNasc = Convert.ToDateTime(dr[9]);
                    con.Close();
                    return cli;
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

    

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                //Vai perguntar se deseja realmente alterar
                DialogResult resp = MessageBox.Show("Deseja realmente alterar os dados do cliente", "sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    //vai iniciar capturando os dados alterados nos campos da tela e alterar no banco de dados
                    int linha = dataGridViewCliente.SelectedRows[0].Index;
                    Cliente cli = new Cliente();
                    cli.Codigo = Convert.ToInt32(textBoxCodigo.Text);
                    cli.Nome = textBoxNome.Text;
                    cli.Cpf = maskedTextBoxCpf.Text;
                    cli.Telefone = maskedTextBoxTelefone.Text;
                    cli.Rua = textBoxRua.Text;
                    cli.Numero = Convert.ToInt32(textBoxNumero.Text);
                    cli.Cep = maskedTextBoxCep.Text;
                    cli.Cidade = textBoxCidade.Text;
                    cli.Uf = comboBoxEstado.Text;
                    cli.DataNasc = Convert.ToDateTime(maskedTextBoxDtNasc.Text);
                    //abrir conexão
                    SqlConnection con = new SqlConnection(Dados.StringConexao);
                    con.Open();
                    string sqlAlterar = "UPDATE cliente SET nome=@nome,cpf=@cpf,telefone=@telefone,rua=@rua,numero=@numero,cep=@cep,cidade=@cidade,uf=@uf,dtnascimnto=@dtnascimnto";
                    SqlCommand cmd = new SqlCommand(sqlAlterar, con);
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = cli.Codigo;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = cli.Nome;
                    cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cli.Cpf;
                    cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = cli.Telefone;
                    cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = cli.Rua;
                    cmd.Parameters.Add("@numero", SqlDbType.Int).Value = cli.Numero;
                    cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = cli.Cep;
                    cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cli.Cidade;
                    cmd.Parameters.Add("@uf", SqlDbType.VarChar).Value = cli.Uf;
                    cmd.Parameters.Add("@dtnascimnto", SqlDbType.Date).Value = cli.DataNasc;
                    cmd.ExecuteNonQuery();
                    con.Close();



                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void maskedTextBoxCpf_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            //o comando dataSource faz com que os dados vindos do ListarClientes();
            //carregue o dataGride do cliente
            dataGridViewCliente.DataSource = PesquisarCliente(textBoxPesquisa.Text);
            //Montando o DataGrid com o cabeçalho e largura das colunas = tabela
            dataGridViewCliente.Columns[0].HeaderText = "Cód";
            dataGridViewCliente.Columns[1].HeaderText = "Nome";
            dataGridViewCliente.Columns[2].HeaderText = "CPF";
            dataGridViewCliente.Columns[3].HeaderText = "CEP";
            dataGridViewCliente.Columns[4].HeaderText = "Rua";
            dataGridViewCliente.Columns[5].HeaderText = "Nº";
            dataGridViewCliente.Columns[6].HeaderText = "Cidade";
            dataGridViewCliente.Columns[7].HeaderText = "UF";
            dataGridViewCliente.Columns[8].HeaderText = "Telefone";
            dataGridViewCliente.Columns[9].HeaderText = "Dt Nascimento";
            //Largura das colunas
            dataGridViewCliente.Columns[0].Width = 50;
            dataGridViewCliente.Columns[1].Width = 250;
            dataGridViewCliente.Columns[2].Width = 150;
            dataGridViewCliente.Columns[3].Width = 150;
            dataGridViewCliente.Columns[4].Width = 60;
            dataGridViewCliente.Columns[5].Width = 100;
            dataGridViewCliente.Columns[6].Width = 100;
            dataGridViewCliente.Columns[7].Width = 50;
            dataGridViewCliente.Columns[8].Width = 90;
            dataGridViewCliente.Columns[9].Width = 50;
            //propriedades importantes do dataGrid
            //faz com que seja selecionada a linha toda do dataGrid
            dataGridViewCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //permissões do usuário 
            dataGridViewCliente.AllowUserToAddRows = false; //usuário não pode adicionar 
            dataGridViewCliente.AllowUserToDeleteRows = false; //usuário não pode deletar linhas 
            dataGridViewCliente.ReadOnly = true; //deixará o dataGrid para apenas leitura
        }
    }
}
