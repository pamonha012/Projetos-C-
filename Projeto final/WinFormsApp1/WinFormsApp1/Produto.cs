using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Produto
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private int fornecedor;
        public int Fornecedor
        {
            get { return fornecedor; }
            set { fornecedor = value; }
        }

        private int marca;
        public int Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string essencia;
        public string Essencia
        {
            get { return essencia; }
            set { essencia = value; }
        }

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        private decimal valorUni;
        public decimal ValorUni
        {
            get { return valorUni; }
            set { valorUni = value; }
        }
    }
}
