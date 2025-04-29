using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caCircunferencia2
{
    internal class Ponto
    {
        // atributos 
        private double x;
        private double y;

        // métodos
        public Ponto()
        {
            x = 0;
            y = 0;
        }
        
        public Ponto(double x1, double y1)
        {
            x = x1;
            y = y1;
        }
        // getters e setters
        public double getX()
        { 
            return x; 
        }

        public void setX(double x1)
        {
            x = x1;
        }

        public double getY()
        { return y; }

        public void setY(double y1)
        {
            y = y1;
        }

        public void imprimir()
        { 
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
    } // fim da classe Ponto
}
