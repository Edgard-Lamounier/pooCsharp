using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNumeroComplexo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumComplexo z1 = new NumComplexo(2.0, 3.0);
            NumComplexo z2 = new NumComplexo(3.0, 2.0);
            NumComplexo z3 = new NumComplexo();

            z3 = z1.soma(z2);
            z3.imprime();
            Console.ReadLine();
        }
    }
}
