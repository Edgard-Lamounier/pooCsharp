using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo(); // criou o objeto r1 da classe Retangulo

            double x = r1.getComprimento();
            double y = r1.Comprimento;

            Console.WriteLine(x);
            r1.setComprimento(10.5);
            r1.Comprimento = 10.5;
            Console.WriteLine(r1.getComprimento());
            
            r1.imprimeDados();

            Retangulo r2 = new Retangulo(); // criou o objeto r2 da classe Retangulo
            r2.imprimeDados();

            r1.setComprimento(10.5);
            r1.setAltura(8.8);

            r1.imprimeDados();
            r2.imprimeDados();

            Console.WriteLine("Perimetro do r1 = " + r1.Perimetro());
            Console.WriteLine("Perimetro do r2 = " + r2.Perimetro());

            Retangulo r3 = new Retangulo(4.9, 6.8);
            r3.imprimeDados(); 

            Console.ReadLine();
        }
    }
}
