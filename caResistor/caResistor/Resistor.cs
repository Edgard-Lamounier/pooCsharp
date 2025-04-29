using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caResistor
{
    internal class Resistor
    {
        // atributos
        private double resistencia;
        private double potencia;

        // métodos
        public double Resistencia { get => resistencia; set => resistencia = value; }
        public double Potencia { get => potencia; set => potencia = value; }

        public Resistor() // construtor default
        {
            resistencia = 0.0;
            potencia = 0.0;
        }

        public Resistor(double a, double b)
        {
            resistencia = a;
            potencia = b;
        }


        public void imprimeResistor()
        {
            Console.WriteLine("Resistência = " +  resistencia);
            Console.WriteLine("Potência = " +  potencia);
        }

        public Resistor resistorSerie(Resistor r)
        {
            Resistor reqSerie = new Resistor();

            reqSerie.resistencia = this.resistencia + r.resistencia;
            if(this.potencia < r.potencia)
            {
                reqSerie.potencia = this.potencia;
            }
            else
                reqSerie.potencia = r.potencia;

            return (reqSerie);
        }

        public Resistor resistorParalelo(Resistor r)
        {
            Resistor reqParalelo = new Resistor();

            reqParalelo.resistencia = (this.resistencia * r.resistencia)/(this.resistencia + r.resistencia);
            if (this.potencia < r.potencia)
            {
                reqParalelo.potencia = this.potencia;
            }
            else
                reqParalelo.potencia = r.potencia;

            return (reqParalelo);
        }



    }
}
