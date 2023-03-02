namespace WinFormsApp2
{
    public partial class FormCalculadora : Form
    {
        decimal valor1, valor2, resultado;
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            labelOperacao.Text = "+";
            // declarar vari�veis para receber o valor
            // poderar usar o tipo decimal
            // ira analisar se os campos 1 e 2 est�o preenchidos
            // atribuir valores decimais para as vari�veis e efetua a convers�o
            // fazer o c�lculo e exibir o resultado
            
            if (textBoxValor1.Text == " " || textBoxValor2.Text == string.Empty)
            {
                labelAlerta.Text = "N�o deixe os campos vazios";
            }
            else
            {
                valor1 = Convert.ToDecimal(textBoxValor1.Text);
                valor2 = Convert.ToDecimal(textBoxValor2.Text);
                resultado = valor1 + valor2; 
                labelResultado.Text = resultado.ToString();
            }
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            labelOperacao.Text = "-";
            if (textBoxValor1.Text == " " || textBoxValor2.Text == string.Empty)
            {
                labelAlerta.Text = "N�o deixe os campos vazios";
            }
            else
            {
                valor1 = Convert.ToDecimal(textBoxValor1.Text);
                valor2 = Convert.ToDecimal(textBoxValor2.Text);
                resultado = valor1 - valor2;
                labelResultado.Text = resultado.ToString();
            };
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            labelOperacao.Text = "�";
            
            if (textBoxValor1.Text == " " || textBoxValor2.Text == " ")
            {
                labelAlerta.Text = "N�o deixe os campos vazios";
            }
            else
            {
                
                if (valor2 == 0) {
                    labelAlerta.Text = "N�o tem como dividir por 0";
                }
                else
                {
                    valor1 = Convert.ToDecimal(textBoxValor1.Text);
                    valor2 = Convert.ToDecimal(textBoxValor2.Text);
                    resultado = valor1 / valor2;
                    labelResultado.Text = resultado.ToString();
                }
                
            }
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            labelOperacao.Text = "x";
            if (textBoxValor1.Text == " " || textBoxValor2.Text == string.Empty)
            {
                labelAlerta.Text = "N�o deixe os campos vazios";
            }
            else
            {
                valor1 = Convert.ToDecimal(textBoxValor1.Text);
                valor2 = Convert.ToDecimal(textBoxValor2.Text);
                resultado = valor1 * valor2;
                labelResultado.Text = resultado.ToString();
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = " ";
            labelOperacao.Text = " ";
            labelAlerta.Text = " ";
            textBoxValor1.Clear();
            textBoxValor2.Clear();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }
        
    }
}