namespace WinFormsApp1
{
    public partial class FormCalcular : Form
    {
        decimal valorVenda, valorTotal, frete;
        public FormCalcular()
        {
            InitializeComponent();
           
        }



            private void buttonSair_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Deseja sair?", "Calcular Frete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                this.Close();
                }
            }



            private void buttonLimpar_Click(object sender, EventArgs e)
            {
                textBoxNomeVendedor.Clear();
                textBoxValorVenda.Clear();
                labelValorVenda.Text = "";
                labelValorFrete.Text = "";
                labelValorTotal.Text = "";
                labelAviso.Text = "";
                comboBoxEstado.SelectedIndex = -1;

            }

            private void buttonCalcular_Click(object sender, EventArgs e)
            {
                labelAviso.Text = "";
                if (valorVenda >= 2500)
                {
                    valorVenda = Convert.ToDecimal(textBoxValorVenda.Text);
                    frete = 0;
                    labelValorFrete.Text = "R$0,00";
                    valorTotal = valorVenda;
                    labelValorTotal.Text = valorTotal.ToString();
                    labelValorVenda.Text = valorVenda.ToString();
                }
                else
                {
                    valorVenda = Convert.ToDecimal(textBoxValorVenda.Text);
                    switch (comboBoxEstado.Text)
                    {
                        case "AM":
                            frete = 650;
                            break;
                        case "PI":
                            frete = 500;
                            break;
                        case "RS":
                            frete = 380;
                            break;
                        case "RJ":
                            frete = 230;
                            break;
                        default:
                            frete = 200;
                            break;
                    }
                    valorTotal = valorVenda + frete;
                    labelValorFrete.Text = frete.ToString("C"); //"C" é um tipo mascára que adiciona um R$ na interface
                    labelValorTotal.Text = valorTotal.ToString("C");
                    labelValorVenda.Text = valorVenda.ToString("C");
                }

            }
    }
}