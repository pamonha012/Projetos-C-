namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelData.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabelDia.Text= DateTime.Now.ToShortDateString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void radioButtonCorBranca_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton.Text = "Você escolheu branco";
        }

        private void radioButtonCorPreta_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton.Text = "Você escolheu preto";
        }

        private void checkBoxMascu_CheckedChanged(object sender, EventArgs e)
        {
            /* ao selecionar Masculino, precisa 
               desmarcara o feminino e atribuir M ao LabelCheckBox*/
            if(checkBoxMascu.Checked == true){
                labelCheckBox.Text = "Masculino";
                checkBoxFemi.Checked = false;
            }
            else
            {
                labelCheckBox.Text = " ";
            }

        }

        private void checkBoxFemi_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxFemi.Checked == true){
                labelCheckBox.Text = "Feminino";
                checkBoxMascu.Checked = false;
            }
            else
            {
                labelCheckBox.Text = " ";
            }
        }

        private void comboBoxNomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //exibir na Label o índices selecionado
           // índice inicia a partir do zero!
           labelComboBox.Text = comboBoxNomes.SelectedIndex.ToString();
        }

        private void labelComboBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxBairros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //vai exibir o nome do bairro 
            labelComboBox2.Text = comboBoxBairros.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            toolStripStatusLabelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            labelCalendario.Text = monthCalendar.SelectionStart.ToShortDateString();
        }
    }
}