using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c1 = new ContaBancaria(12345, "José da Silva", 3500.47);
            c1.imprime();
            Console.ReadLine();
            
            c1.Deposito(2500.00);
            c1.imprime();
            Console.ReadLine();

            c1.Saque(500.00);
            c1.imprime();
            Console.ReadLine();
        }
    }
}
