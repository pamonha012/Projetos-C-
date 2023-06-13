using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Fornecedor
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }


        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        private string cnpj;
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        private string rua;
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }


        private int numero;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
