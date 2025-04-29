using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caCircunferencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome back");

            Circunferencia c1 = new Circunferencia();
            Console.WriteLine(c1.Raio); // getter
            c1.Raio = 10.0; // setter
            Console.WriteLine(c1.Raio);

            Circunferencia c2 = new Circunferencia(5.5);
            Console.WriteLine(c2.Raio);

            Console.WriteLine("O comprimento do c1 = " + c1.Comprimento());
            Console.WriteLine("A area do c2 = " + c2.Area());
            Console.ReadLine();
        }
    }
}
