namespace WinFormsApp1{ 
    public partial class FormNotas : Form{
        decimal notaP, notaM, notaC, notaI, notaFinal;
        public FormNotas(){
            InitializeComponent();
        }
        private void textBoxMatematica_TextChanged(object sender, EventArgs e){
            bool letra = decimal.TryParse(textBoxMatematica.Text, out notaM);
            if (letra == false){

                labelResultado.Text = "Use notas validas";
                textBoxMatematica.Clear();
            }else if (notaM > 10){
                buttonCalcular.Enabled = false;
                labelResultado.Text = "Use notas validas";
            }else{
                buttonCalcular.Enabled = true;
                labelResultado.Text = " ";
            }
        }
        private void textBoxCiencias_TextChanged(object sender, EventArgs e){
            bool letra = decimal.TryParse(textBoxCiencias.Text, out notaC);
            if (letra == false){ 

                labelResultado.Text = "Use notas validas";
                textBoxCiencias.Clear();
            }else if(notaC > 10){
                buttonCalcular.Enabled = false;
                labelResultado.Text = "Use notas validas";
            }else{
                buttonCalcular.Enabled = true;
                labelResultado.Text = " ";
            }
        }
        private void FormPortugues_Load(object sender, EventArgs e){}
        private void FormNotas_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl,!e.Shift, true, true, true);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e){
            bool letra = decimal.TryParse(textBoxIngles.Text, out notaI);
            if (letra == false){

                labelResultado.Text = "Use notas validas";
                textBoxIngles.Clear();
            }else if (notaI > 10){
                buttonCalcular.Enabled = false;
                labelResultado.Text = "Use notas validas";
            }else{
                buttonCalcular.Enabled = true;
                labelResultado.Text = " ";
            }
        }
        private void buttonCalcular_Click(object sender, EventArgs e){
            if (textBoxPortugues.Text == string.Empty || textBoxMatematica.Text == string.Empty || textBoxCiencias.Text == string.Empty || textBoxIngles.Text == string.Empty){
                labelResultado.Text = "Preencha os campos";
            }else{ 
                notaP = Convert.ToDecimal(textBoxPortugues.Text);
                notaM = Convert.ToDecimal(textBoxMatematica.Text);
                notaC = Convert.ToDecimal(textBoxCiencias.Text);
                notaI = Convert.ToDecimal(textBoxIngles.Text);
                notaFinal = (notaP + notaM + notaC + notaI) / 4;
                if (notaFinal >= 8){
                    labelNotaFinal.Text = "Sua média foi: " + notaFinal;
                    labelResultado.Text = "Você foi aprovado";
                    labelResultado.ForeColor = Color.Green;
                }else if (notaFinal >= 5 && notaFinal < 8){
                    labelNotaFinal.Text = "Sua média foi: " + notaFinal;
                    labelResultado.Text = "Você está de recuperação";
                    labelResultado.ForeColor = Color.Orange;
                }else{
                    labelNotaFinal.Text = "Sua média foi: " + notaFinal;
                    labelResultado.Text = "Você está reprovado";
                    labelResultado.ForeColor = Color.Red;
                }
            }
        }
        private void buttonLimpar_Click(object sender, EventArgs e){
            textBoxPortugues.Clear();
            textBoxMatematica.Clear();
            textBoxCiencias.Clear();
            textBoxIngles.Clear();
            labelNotaFinal.Text = " ";
            labelResultado.Text = " ";
        }
        private void textBoxPortugues_TextChanged(object sender, EventArgs e){
            bool letra = decimal.TryParse(textBoxPortugues.Text, out notaP);
            if (letra == false){
                labelResultado.Text = "Use notas validas";
                textBoxPortugues.Clear();
            }else if (notaP > 10){
                labelResultado.Text = "Use notas validas";
                buttonCalcular.Enabled = false;
            }else{
                buttonCalcular.Enabled = true;
                labelResultado.Text = " ";
            }
        }
    }
}