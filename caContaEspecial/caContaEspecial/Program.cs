using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caContaEspecial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta(1, 500.00);
            Conta c2 = new Conta(2, 300.00);
            ContaEspecial c3 = new ContaEspecial(3, 200.00, 1000.00);

            c1.Saque(200.00);
            c2.Saque(450.50);
            c3.Saque(350.00);

            c1.verSaldo();
            c2.verSaldo();
            c3.verSaldo();

            Console.ReadLine();

        }
    }
}
