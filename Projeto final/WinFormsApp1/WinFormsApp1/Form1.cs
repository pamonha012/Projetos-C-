namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFornecedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormFornecedores();
            form.Show();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormCliente();
            form.Show();
        }

        private void buttonVendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormVendas();
            form.Show();
        }

        private void buttonProduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormProduto();
            form.Show();
        }

        private void buttonMarca_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormMarcas();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormLogin();
            form.Show();
        }
    }
}