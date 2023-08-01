using System.Text;

namespace WinFormsApp1{
    public partial class Form1 : Form{
        // Declarações de variáveis globais 
        decimal valorUni, quantidade, subTotal, total; 
        public Form1(){
            InitializeComponent();
            // Coloca a data atual 
            toolStripStatusLabelData.Text = DateTime.Now.ToLongDateString();
            addMarcas();

            // Inicia o comboBox com valor definido
            comboBoxMarca.SelectedItem = "Selecionar marca";
            comboBoxProduto.SelectedItem = "Selecionar Produto";

            // Desabilita o textBox, radioButton, impossibilitando que o usário edite
            textBoxVista.Enabled= false; 
            textBox3.Enabled = false;
            textBox6.Enabled = false;
            textBox10.Enabled = false;
            radioButtonVista.Enabled = false;
            radioButton3.Enabled = false;
            radioButton6.Enabled = false;
            radioButton10.Enabled = false;
            textBoxValorUni.Enabled = false;
            textBoxSubTotal.Enabled = false;    
            textBoxTotal.Enabled = false;
            buttonCalcular.Enabled = false;
            radioButtonCredito.Enabled = false;
            radioButtonDinheiro.Enabled = false;

        }

        //criar uam função/método: é poder posicionar ou inserir 
        //em qualquer lugar do código sem redundâncias 
        public void addMarcas(){ 
            // vai adicionar items nos comboBox 
            comboBoxMarca.Items.Add("Selecionar marca");
            comboBoxMarca.Items.Add("Marca Milho verde");
            comboBoxMarca.Items.Add("Marca 1");
            comboBoxMarca.Items.Add("Marca 2");
        }

        // Método criado para limpar campos específicos 
        public void limpar() {
            textBoxValorUni.Clear();
            textBoxQuantidade.Clear();
            textBoxSubTotal.Clear(); 
            radioButtonCredito.Checked = false;
            radioButtonDinheiro.Checked= false;
            radioButtonVista.Checked = false;
            radioButton3.Checked = false;
            radioButton6.Checked = false;   
            radioButton10.Checked = false;
            buttonCalcular.Enabled = false;
            radioButtonVista.Enabled = false;
            radioButton3.Enabled = false;
            radioButton6.Enabled = false;
            radioButton10.Enabled = false;
        }

        public void limparQuant()
        {
            textBoxSubTotal.Clear();
            radioButtonCredito.Checked = false;
            radioButtonDinheiro.Checked = false;
            radioButtonVista.Checked = false;
            radioButton3.Checked = false;
            radioButton6.Checked = false;
            radioButton10.Checked = false;
            buttonCalcular.Enabled = false;
            radioButtonVista.Enabled = false;
            radioButton3.Enabled = false;
            radioButton6.Enabled = false;
            radioButton10.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e){
            
        }

        private void label4_Click(object sender, EventArgs e){

        }

        private void pictureBox1_Click(object sender, EventArgs e){

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){

        }

        private void timer1_Tick(object sender, EventArgs e){
            // Evento para adicionar a hora atual e contínua
            toolStripStatusLabelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e){
            // ao validar qual marca é, vai add items no produto
            // referente as marcas
            if(comboBoxMarca.Text == "Marca Milho verde"){
                textBoxValorUni.Clear();
                comboBoxProduto.Items.Clear();
                comboBoxProduto.Items.Add("Milho na mateiga");
                comboBoxProduto.Items.Add("Milho na espiga");
                
            }
            if(comboBoxMarca.Text == "Marca 1"){
                textBoxValorUni.Clear();
                comboBoxProduto.Items.Clear();
                comboBoxProduto.Items.Add("Produto 1");
            }
            if (comboBoxMarca.Text == "Marca 2"){
                textBoxValorUni.Clear();
                comboBoxProduto.Items.Clear();
                comboBoxProduto.Items.Add("Produto 2");
            }
            limpar();
            textBoxTotal.Clear();
            textBox10.Clear();
            textBox3.Clear();
            textBox6.Clear();
        }

        private void buttonLimpar_Click(object sender, EventArgs e){
            limpar();
            textBoxValorUni.Clear();
            textBoxTotal.Clear();
            textBox10.Clear();
            textBox3.Clear();
            textBox6.Clear();
            textBoxVista.Clear();
            labelResultado.Text = string.Empty;
            comboBoxMarca.SelectedIndex= 0; 
            comboBoxProduto.SelectedIndex = -1;
            buttonCalcular.Enabled = false;
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e){
            try
            {
                switch (comboBoxProduto.Text)
                {
                    case "Milho na mateiga":
                        valorUni = 12;
                        break;
                    case "Milho na espiga":
                        valorUni = 10;
                        break;
                    case "Produto 1":
                        valorUni = 100;
                        break;
                    case "Produto 2":
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

        private void label7_Click(object sender, EventArgs e){

        }

        private void textBoxTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonCredito_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                subTotal = quantidade * valorUni;
                textBoxTotal.Text = subTotal.ToString();
                
                if (subTotal <= 350)
                {
                    radioButtonVista.Enabled = true;
                    buttonCalcular.Enabled = true;
                }
                else if (subTotal >= 351 && subTotal <=1500)
                {
                    radioButtonVista.Enabled = true;
                    radioButton3.Enabled = true;
                    buttonCalcular.Enabled = true;
                }
                else if (subTotal >=1501 && subTotal <= 5000)
                {
                    radioButtonVista.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton6.Enabled = true;
                    buttonCalcular.Enabled = true;
                }
                else if (subTotal >= 5001)
                {
                    radioButtonVista.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton6.Enabled = true;
                    radioButton10.Enabled = true;
                    buttonCalcular.Enabled = true;
                }
            }
            catch (Exception)
            {
            }
        }

        private void textBoxSubTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonVista_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxVista.Text = subTotal.ToString();
                textBox3.Clear();
                textBox6.Clear();
                textBox10.Clear();
            }
            catch (Exception)
            {

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = (subTotal/3).ToString();
                textBoxVista.Clear();
                textBox6.Clear();
                textBox10.Clear();
            }
            catch (Exception)
            {
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = (subTotal/6).ToString();
                textBoxVista.Clear();
                textBox3.Clear();
                textBox10.Clear();
            }
            catch (Exception)
            {
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                textBox10.Text = (subTotal/10).ToString();
                textBoxVista.Clear();
                textBox3.Clear();
                textBox6.Clear();
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FormMenu();
            form.Show();
        }

        private void textBoxSubTotal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxTotal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxVista_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxValorUni_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void textBoxQuantidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButtonDinheiro_CheckedChanged(object sender, EventArgs e){
            try
            {
                subTotal = quantidade * valorUni;
                total = subTotal - (subTotal * 5) / 100;
                textBoxTotal.Text = total.ToString();
                radioButtonVista.Enabled = false;
                radioButton3.Enabled = false;
                radioButton6.Enabled = false;
                radioButton10.Enabled = false;
            }
            catch (Exception)
            {

            }
        }

        private void textBoxQuantidade_TextChanged(object sender, EventArgs e){
            try{
                quantidade = Convert.ToDecimal(textBoxQuantidade.Text);
                valorUni = Convert.ToDecimal(textBoxValorUni.Text);
                subTotal = quantidade * valorUni;
                textBoxSubTotal.Text = subTotal.ToString();
                radioButtonCredito.Enabled = true;
                radioButtonDinheiro.Enabled= true;
                
            }catch (Exception){

            }
            
        }

        private void buttonCalcular_Click(object sender, EventArgs e){
            try
            {
                if (radioButtonDinheiro.Checked)
                {
                    labelResultado.Text = " Nota fiscal:\n" +
                                      " Produto: " + comboBoxProduto.Text + "\n" +
                                      " Quantidade: " + textBoxQuantidade.Text + "\n" +
                                      " Forma de pagamento: Dinheiro\n" +
                                      " Desconto de: " + ((subTotal * 5) / 100).ToString() + "\n" +
                                      " Valor total: " + total.ToString() + "\n" +
                                      " Data: " + (toolStripStatusLabelData.Text = DateTime.Now.ToShortDateString()) + "\n" +
                                      " Hora: " + toolStripStatusLabelHora.Text;
                }
                else
                {
                    if (radioButtonVista.Checked)
                    {
                        labelResultado.Text = " Nota fiscal:\n" +
                                      " Produto: " + comboBoxProduto.Text + "\n" +
                                      " Quantidade: " + textBoxQuantidade.Text + "\n" +
                                      " Forma de pagamento: Crédito\n" +
                                      " Número de parcelas: À vista\n" +
                                      " Valor total: " + subTotal.ToString() + "\n" +
                                      " Data: " + (toolStripStatusLabelData.Text = DateTime.Now.ToShortDateString()) + "\n" +
                                      " Hora: " + toolStripStatusLabelHora.Text;
                    }
                    else if (radioButton3.Checked)
                    {
                        labelResultado.Text = " Nota fiscal:\n" +
                                      " Produto: " + comboBoxProduto.Text + "\n" +
                                      " Quantidade: " + textBoxQuantidade.Text + "\n" +
                                      " Forma de pagamento: Crédito\n" +
                                      " Número de parcelas: 3x\n" +
                                      " Valor total: " + (subTotal / 3).ToString() + "\n" +
                                      " Data: " + (toolStripStatusLabelData.Text = DateTime.Now.ToShortDateString()) + "\n" +
                                      " Hora: " + toolStripStatusLabelHora.Text;
                    }
                    else if (radioButton6.Checked)
                    {
                        labelResultado.Text = " Nota fiscal:\n" +
                                      " Produto: " + comboBoxProduto.Text + "\n" +
                                      " Quantidade: " + textBoxQuantidade.Text + "\n" +
                                      " Forma de pagamento: Crédito\n" +
                                      " Número de parcelas: 6x\n" +
                                      " Valor total: " + (subTotal / 6).ToString() + "\n" +
                                      " Data: " + (toolStripStatusLabelData.Text = DateTime.Now.ToShortDateString()) + "\n" +
                                      " Hora: " + toolStripStatusLabelHora.Text;
                    }
                    else if (radioButton10.Checked)
                    {
                        labelResultado.Text = " Nota fiscal\n" +
                                      " Produto: " + comboBoxProduto.Text + "\n" +
                                      " Quantidade: " + textBoxQuantidade.Text + "\n" +
                                      " Forma de pagamento: Crédito\n" +
                                      " Número de parcelas: 10x\n" +
                                      " Valor total: " + (subTotal / 10).ToString() + "\n" +
                                      " Data: " + (toolStripStatusLabelData.Text = DateTime.Now.ToShortDateString()) + "\n" +
                                      " Hora: " + toolStripStatusLabelHora.Text;
                    }
                }
                radioButtonCredito.Enabled = false;
                radioButtonDinheiro.Enabled = false;
                radioButtonVista.Enabled = false;
                radioButton3.Enabled = false;
                radioButton6.Enabled = false;
                radioButton10.Enabled = false;
            }
            catch (Exception)
            {
            }
                                  
        }
    }
}