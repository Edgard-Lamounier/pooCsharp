using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNumeroComplexo
{
    internal class NumComplexo
    {
        // atributos
        private double re;
        private double im;

        public double Re { get => re; set => re = value; }
        public double Im { get => im; set => im = value; }

        public NumComplexo()
        {
            re = 0.0;
            im = 0.0;
        }

        public NumComplexo(double _re, double _im)
        {
            re = _re;
            im = _im;
        }

        public double Modulo()
        { return Math.Sqrt(re * re + im * im); }

        public double Argumento()
        { return Math.Atan(im / re); }

        public NumComplexo soma(NumComplexo z)
        {
            NumComplexo temp = new NumComplexo();

            temp.re = re + z.re;
            temp.im = im + z.im;

            return (temp);
        }

        public void imprime()
        {
            Console.WriteLine("Parte real = " + re);
            Console.WriteLine("Parte imaginária = " + im);
        }

        // métodos
    }
}
