namespace conta_corrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Usuario;
            Conta deposito = new Conta();

            Console.WriteLine("Qual alterção você deseja");
            Usuario = Console.ReadLine();

            deposito.Saldo = Convert.ToDouble(Console.ReadLine());
            deposito.Numero = Convert.ToDouble(Console.ReadLine());

           
            if (Usuario == "sacar") {
                Console.WriteLine(deposito.Sacar()); 
            }if (Usuario == "depositar") {
                Console.WriteLine(deposito.Depositar()); 
            }if (Usuario == "saldo em conta") {
                Console.WriteLine($"Seu saldo atual é {deposito.Saldo_Conta()}"); 
            }


            //Console.WriteLine(deposito.Depositar());
            //Console.WriteLine(deposito.Sacar());
            //Console.WriteLine(deposito.Saldo_Conta());







        }
    }
}