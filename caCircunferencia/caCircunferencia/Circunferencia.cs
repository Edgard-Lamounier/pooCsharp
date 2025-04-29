using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caCircunferencia
{
    internal class Circunferencia
    {
        // atributos
        private double raio;

        // métodos
        public Circunferencia() // construtor default
        { raio = 0.0; }

        public Circunferencia(double _raio) // construtor default
        { raio = _raio; }

        public double Raio { get => raio; set => raio = value; }

        public double Comprimento()
        {
            return 2 * 3.1415 * raio;
        }

        public double Area()
        {
            return 3.1415 * raio * raio;
        }

    } // fim da classe Circunferencia
}
