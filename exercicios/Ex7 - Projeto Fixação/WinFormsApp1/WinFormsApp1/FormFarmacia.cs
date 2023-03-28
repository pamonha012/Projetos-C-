using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class FormFarmacia : Form
    {
        decimal valorUni, quantidade, subTotal, total;
        public FormFarmacia()
        {
            InitializeComponent();
            toolStripStatusLabelData.Text = DateTime.Now.ToLongDateString();
            addMarcas();
            comboBoxMarca.SelectedItem = "Selecionar marca";
            comboBoxMedicamento.SelectedItem = "Selecionar medicamento";
            

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            textBoxValorUni.Enabled = false;
            textBoxSubTotal.Enabled = false;
            textBoxTotal.Enabled = false;
            buttonCalcular.Enabled = false;
            radioButtonCredito.Enabled = false;
            radioButtonDinheiro.Enabled = false;
            radioButtonPopular.Enabled = false;
        }
        public void limpar()
        {
            textBoxValorUni.Clear();
            textBoxQuantidade.Clear();
            textBoxSubTotal.Clear();
            radioButtonCredito.Checked = false;
            radioButtonDinheiro.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButtonPopular.Checked = false;
            buttonCalcular.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButtonPopular.Enabled = false;
            labelResultado.Text= string.Empty;
        }

        public void addMarcas()
        {
            // vai adicionar items nos comboBox 0
            comboBoxMarca.Items.Add("Selecionar marca");
            comboBoxMedicamento.Items.Add("Selecionar medicamento");
            comboBoxMarca.Items.Add("Marca 1");
            comboBoxMarca.Items.Add("Marca 2");
            comboBoxMarca.Items.Add("Marca 3");
        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMarca.Text == "Marca 1")
            {
                textBoxValorUni.Clear();
                comboBoxMedicamento.Items.Clear();
                comboBoxMedicamento.Items.Add("Medicamento 1");

            }
            if (comboBoxMarca.Text == "Marca 2")
            {
                textBoxValorUni.Clear();
                comboBoxMedicamento.Items.Clear();
                comboBoxMedicamento.Items.Add("Medicamento 2");
            }
            if (comboBoxMarca.Text == "Marca 3")
            {
                textBoxValorUni.Clear();
                comboBoxMedicamento.Items.Clear();
                comboBoxMedicamento.Items.Add("Medicamento 3");
            }
            limpar();
            textBoxTotal.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void radioButtonCredito_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                subTotal = quantidade * valorUni;
                textBoxTotal.Text = subTotal.ToString("C");

                if (subTotal <= 100)
                {
                    radioButton1.Enabled = true;
                }
                else if (subTotal >= 101 && subTotal <= 200)
                {
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    buttonCalcular.Enabled = true;
                }
                else if (subTotal >= 201 && subTotal <= 300)
                {
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    buttonCalcular.Enabled = true;
                }
                else if (subTotal >= 301)
                {
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                    buttonCalcular.Enabled = true;
                }
            }
            catch (Exception)
            {
            }
        }

        private void radioButtonPopular_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                subTotal = quantidade * valorUni;
                total = subTotal - (subTotal * 15) / 100;
                textBoxTotal.Text = total.ToString("C");
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                buttonCalcular.Enabled = true;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception)
            {

            }
        }

        private void textBoxQuantidade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                quantidade = Convert.ToDecimal(textBoxQuantidade.Text);
                valorUni = Convert.ToDecimal(textBoxValorUni.Text);
                subTotal = quantidade * valorUni;
                textBoxSubTotal.Text = subTotal.ToString("C");
                radioButtonCredito.Enabled = true;
                radioButtonDinheiro.Enabled = true;
                radioButtonPopular.Enabled = true;

            }
            catch (Exception)
            {

            }
        }

        private void textBoxValorUni_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = subTotal.ToString("C");
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception)
            {

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();
                textBox2.Text = (subTotal / 2).ToString();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception)
            {

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Text = (subTotal / 3).ToString();
                textBox4.Clear();
            }
            catch (Exception)
            {

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Text = (subTotal / 4).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                subTotal = quantidade * valorUni;
                total = subTotal;
                textBoxTotal.Text = total.ToString("C");
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
            }
            catch (Exception)
            {

            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonDinheiro.Checked)
                {
                    labelResultado.Text = " Nota fiscal:\n" +
                                      " Produto: " + comboBoxMedicamento.Text + "\n" +
                                      " Quantidade: " + textBoxQuantidade.Text + "\n" +
                                      " Forma de pagamento: Dinheiro\n" +
                                      " Valor total: " + total.ToString("C") + "\n" +
                                      " Data: " + (toolStripStatusLabelData.Text = DateTime.Now.ToShortDateString()) + "\n" +
                                      " Hora: " + toolStripStatusLabelHora.Text;
                }
                else if (radioButtonPopular.Checked)
                {
                    labelResultado.Text = " Nota fiscal:\n" +
                                     " Produto: " + comboBoxMedicamento.Text + "\n" +
                                     " Quantidade: " + textBoxQuantidade.Text + "\n" +
                                     " Forma de pagamento: Farmácia Popular\n" +
                                     " Desconto de: " + ((subTotal * 15) / 100).ToString("C") + "\n" +
                                     " Valor total: " + total.ToString("C") + "\n" +
                                     " Data: " + (toolStripStatusLabelData.Text = DateTime.Now.ToShortDateString()) + "\n" +
                                     " Hora: " + toolStripStatusLabelHora.Text;
                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        labelResultado.Text = " Nota fiscal:\n" +
                                      " Produto: " + comboBoxMedicamento.Text + "\n" +
                                      " Quantidade: " + textBoxQuantidade.Text + "\n" +
                                      " Forma de pagamento: Crédito\n" +
                                      " Número de parcelas: 1x\n" +
                                      " Valor total: " + subTotal.ToString("C") + "\n" +
                                      " Data: " + (toolStripStatusLabelData.Text = DateTime.Now.ToShortDateString()) + "\n" +
                                      " Hora: " + toolStripStatusLabelHora.Text;
                    }
                    else if (radioButton2.Checked)
                    {
                        labelResultado.Text = " Nota fiscal:\n" +
                                      " Produto: " + comboBoxMedicamento.Text + "\n" +
                                      " Quantidade: " + textBoxQuantidade.Text + "\n" +
                                      " Forma de pagamento: Crédito\n" +
                                      " Número de parcelas: 2x\n" +
                                      " Valor total: " + (subTotal / 2).ToString("C") + "\n" +
                                      " Data: " + (toolStripStatusLabelData.Text = DateTime.Now.ToShortDateString()) + "\n" +
                                      " Hora: " + toolStripStatusLabelHora.Text;
                    }
                    else if (radioButton3.Checked)
                    {
                        labelResultado.Text = " Nota fiscal:\n" +
                                      " Produto: " + comboBoxMedicamento.Text + "\n" +
                                      " Quantidade: " + textBoxQuantidade.Text + "\n" +
                                      " Forma de pagamento: Crédito\n" +
                                      " Número de parcelas: 3x\n" +
                                      " Valor total: " + (subTotal / 3).ToString("C") + "\n" +
                                      " Data: " + (toolStripStatusLabelData.Text = DateTime.Now.ToShortDateString()) + "\n" +
                                      " Hora: " + toolStripStatusLabelHora.Text;
                    }
                    else if (radioButton4.Checked)
                    {
                        labelResultado.Text = " Nota fiscal\n" +
                                      " Produto: " + comboBoxMedicamento.Text + "\n" +
                                      " Quantidade: " + textBoxQuantidade.Text + "\n" +
                                      " Forma de pagamento: Crédito\n" +
                                      " Número de parcelas: 4x\n" +
                                      " Valor total: " + (subTotal / 4).ToString("C") + "\n" +
                                      " Data: " + (toolStripStatusLabelData.Text = DateTime.Now.ToShortDateString()) + "\n" +
                                      " Hora: " + toolStripStatusLabelHora.Text;
                    }
                }
                radioButtonCredito.Enabled = false;
                radioButtonDinheiro.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
            }
            catch (Exception)
            {
            }
        }

        private void FormFarmacia_Load(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            
            comboBoxMarca.SelectedIndex = 0;
            comboBoxMedicamento.SelectedIndex = -1;
            buttonCalcular.Enabled = false;
        }

        private void toolStripStatusLabelHora_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void comboBoxMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxMedicamento.Text)
                {
                    case "Medicamento 1":
                        valorUni = 100;
                        break;
                    case "Medicamento 2":
                        valorUni = 10;
                        break;
                    case "Medicamento 3":
                        valorUni = 1000;
                        break;
                    default:
                        break;
                }
                textBoxValorUni.Text = valorUni.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
