using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caContaHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta(1, 500.00);
            Conta c2 = new Conta(2, 300.00);

            c1.Deposito(200.00);
            c2.Saque(450.00);

            c1.verSaldo();
            c2.verSaldo();

            ContaEspecial c3 = new ContaEspecial(3, 400.00, 1000.0);
            c3.Saque(600.00);
            c3.verSaldo();
            Console.ReadLine();
        }
    }
}
