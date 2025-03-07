using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double getTotalAmount()
        {
            return Preco * Quantidade;
        }
        public string getDetaiProduct()
        {
            return $"Nome: {Nome}, Preco: {Preco}, Quantidade, {Quantidade}";
        }
    }
}
