using Retangulo;

namespace Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Produto produto1 = new Produto("Lapis", 500, 81); 
            Produto produto2 = new Produto("Pacoca", 200, 1); 
            Produto produto3 = new Produto("Chá Bear Matte", 8, 400); 

            Console.WriteLine(produto1.ToString()); 
            Console.WriteLine(produto2.ToString()); 
            Console.WriteLine(produto3.ToString());*/
            // Parte do Retangulo 

            Retangulo retangulo= new Retangulo();
            retangulo.Altura = 0;
            retangulo.Largura = 10;

            Console.WriteLine(retangulo.perimetro());




        }
    }
}
