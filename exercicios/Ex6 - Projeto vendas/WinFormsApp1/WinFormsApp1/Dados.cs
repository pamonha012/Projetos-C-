using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Dados
    {
        //método que ira mostrar a string de c.onexão
        public static string StringConexao
        {
            get {
                return "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\guilherme.hcarvalho3\\Documents\\BDVendas.mdf;Integrated Security=True;Connect Timeout=30";
            }
        }
    }
}
