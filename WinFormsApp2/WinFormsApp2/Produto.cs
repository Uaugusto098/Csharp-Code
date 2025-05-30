using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Produto
    {
        public int codigo;
        public string nome;
        public double preco;
        public int quant;

        public Produto() { }

        public Produto(int codigo, string nome, double preco, int quant)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
            this.quant = quant;
        }

       
    }
}


