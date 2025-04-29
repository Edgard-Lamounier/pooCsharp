using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTratamentoExcecoes2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int quociente(int numerador, int denominador)
            {
                return (numerador / denominador);
            }

            int num, den;

            Console.WriteLine("Entre o numerador : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre o denominador : ");
            den = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quociente: " + quociente(num, den));
            Console.ReadLine();

        }
    }
}
