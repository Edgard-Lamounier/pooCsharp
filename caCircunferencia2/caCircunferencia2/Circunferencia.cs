using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caCircunferencia2
{
    internal class Circunferencia
    {
        // atributos
        public double raio;
        public Ponto centro;

        public Circunferencia()
        {
            raio = 0;
            centro = new Ponto();
        }
        
        public Circunferencia(double raio, Ponto centro)
        { 
          this.raio = raio; 
          this.centro = centro; 
        }
        
        // métodos
        public double Area()
        { return 3.1415 * raio * raio; }

        public double Comprimento()
        {
            return 2 * 3.1415 * raio;
        }

        public void imprimir()
        {
            Console.WriteLine("Raio = " +  raio);
            Console.WriteLine("X do centro " + centro.getX());
            Console.WriteLine("Y do centro " + centro.getY());
        }

        
    } // fim da classe Circunferencia
}
