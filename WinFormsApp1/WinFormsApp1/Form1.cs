namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExibir_Click(object sender, EventArgs e)
        {
            // ao clicar no bot�o, dever�  capturar o vlor do 
            // textBoxNome e exibir no labelStatus
            // atribui��o de valores

            // labelStatus vai recber o valor inserido no textBoxNome
            labelStatusNome.Text = "Seja bem vindo: "+textBoxNome.Text;
            labelStatusTelefone.Text = "Seu telefone �: " + textBoxTelefone.Text;
            labelStatusCidade.Text = "Voc� mora em: " + textBoxCidade.Text;

            textBoxNome.Clear();
            textBoxTelefone.Clear();
            textBoxCidade.Clear();
            textBoxNome.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            labelStatusNome.Text = " ";
            labelStatusTelefone.Text = " ";
            labelStatusCidade.Text = " ";
        }
    }
}