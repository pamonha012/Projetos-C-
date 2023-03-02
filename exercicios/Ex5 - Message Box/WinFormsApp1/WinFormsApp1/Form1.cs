namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            if (textBoxValor.Text ==  string.Empty)
            {
                MessageBox.Show("Campo obrigatório!", "Atenção");
                textBoxValor.Focus();
            }
            else
            {
                MessageBox.Show(textBoxValor.Text, "Sistema Message Box");
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?S/N",
                "Sistemas MessageBox", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MessageBox.Show("Salvou ok!", "Sistemas MessageBox");
                textBoxValor.Clear();
            }
        }
    }
}