using System.Configuration;

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

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            bool letra = int.TryParse(textBoxImparPar.Text, out numero);
            if (textBoxImparPar.Text == string.Empty){
                labelParImpar.Text = "Preencha o campo";
            }else if (letra == false){
                labelParImpar.Text = "Insira um número inteiro";
            }
            else{
                numero = Convert.ToInt32(textBoxImparPar.Text);
                if (numero % 2 == 0){
                    labelParImpar.Text = "O número " + numero + " é par";
                }else{
                    labelParImpar.Text = "O número " + numero + " é ímpar";
                }
            }
        }
    }
}