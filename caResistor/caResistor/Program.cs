using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caResistor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Resistor r1 = new Resistor(2.5, 5.0);
            Resistor r2 = new Resistor(1.5, 3.0);
            Resistor r3 = new Resistor();
            Resistor r4 = new Resistor();

            r1.imprimeResistor();
            r2.imprimeResistor();

            r3 = r1.resistorSerie(r2);
            r4 = r1.resistorParalelo(r2);

            r3.imprimeResistor();
            r4.imprimeResistor();

            Console.ReadLine();
        }
    }
}
