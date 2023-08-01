using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //biblioteca sql
using System.Data.SqlTypes;

namespace WinFormsApp1
{
    public partial class FormTeste : Form
    {
        public FormTeste()
        {
            InitializeComponent();
        }

        private void FormTeste_Load(object sender, EventArgs e)
        {

        }

        private void buttonTeste_Click(object sender, EventArgs e)
        {
            try
            {
                //vai efetuar uma conexão com o banco 
                SqlConnection con = new SqlConnection(Dados.StringConexao);
                con.Open();
                labelStatus.Text = "Conexão Ok";
                con.Close();
            }
            catch (SqlException erro)
            {
                labelStatus.Text = erro.Message;
            }
        }
    }
}
