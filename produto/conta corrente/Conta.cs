using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta_corrente
{
    internal class Conta
    {
        public double Numero;
        public string Titular;
        public double Saldo;

        public string Depositar()
        {

            return $"{Saldo + Numero}";

        }
        public string Sacar()
           
        {
            return $"{Saldo - Numero}";


        }
        public string Saldo_Conta()

        {
            return $"{Saldo}";

        }

      
       
            
    }
}
