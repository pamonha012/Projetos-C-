using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class dados
    {
        //método que ira mostrar a string de conexão
        public static string StringConexao
        {
            get
            {
                return "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\guilherme.hcarvalho3\\Documents\\GPBanco.mdf;Integrated Security=True;Connect Timeout=30";
            }
        }
    }
}
