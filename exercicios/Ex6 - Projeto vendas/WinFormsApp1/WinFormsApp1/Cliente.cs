using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Cliente
    {
        //aqui terá as propriedades de acordo com os campos recebidos da tela que serão salvos no bd
        //será usado o conceito de encapsulamento, as variáveis privadas em métodos públicos das praopriedades serão encapsuladas 

        //atalho para declaração propriedade com encapsulamento
        // propfull + tab tab

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


        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
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


        private string cidade;
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }


        private string uf;
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }


        private string 
            telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }


        private DateTime dataNasc;

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

    }
}
