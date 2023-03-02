namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            
            if (textBoxUsuario.Text == String.Empty || textBoxSenha.Text == String.Empty){
                labelResultado.Text = "Preencha os campos";
            }else{
                switch (textBoxUsuario.Text.ToLower()){
                    case "eduardo":
                        if (textBoxSenha.Text == "1")
                        {
                            labelResultado.Text = "Bem vindo, Gerente";
                            labelResultado.ForeColor = Color.Green;
                        }
                        else if(textBoxUsuario.Text != "1")
                        {
                            labelResultado.Text = "Senha Inv�lida";
                            labelResultado.ForeColor = Color.Red;
                        }
                        break;
                    case "antonio":
                        if (textBoxSenha.Text == "2")
                        {
                            labelResultado.Text = "Bem vindo, Funcion�rio";
                            labelResultado.ForeColor = Color.Green;
                        }
                        else if (textBoxSenha.Text != "2")
                        {
                            labelResultado.Text = "Senha Inv�lida";
                            labelResultado.ForeColor = Color.Red;
                        }
                        break;
                    default:
                        labelResultado.Text = "Usuario Inv�lido";
                        labelResultado.ForeColor = Color.Red;
                        break;
                }
            }

            

        }
    }
}