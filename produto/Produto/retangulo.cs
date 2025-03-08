using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;
        public double Tamanho;


        public string perimetro()
        {
            Tamanho = 2 + (Largura * Altura);
            return $"Largura{perimetro}, Altura{}";

        }


    }

}

