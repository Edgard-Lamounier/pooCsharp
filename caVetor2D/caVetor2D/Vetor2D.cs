using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVetor2D
{
    internal class Vetor2D
    {
        // atributos
        public double x;
        public double y;

        // métodos
        public Vetor2D() // construtor default - aridade 0
        {
            x = 0;
            y = 0;
        }

        public Vetor2D(double _x, double _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public Vetor2D(string str)
        {
            Console.WriteLine(str);
            Console.WriteLine("Entre o valor do x = ");
            x = double.Parse(Console.ReadLine());  // x = Convert.ToDouble(Console.Readline());
            Console.WriteLine("Entre o valor do y = ");
            y = double.Parse(Console.ReadLine());
        }

        public double ProdutoEscalar(Vetor2D obj)
        {
            return(this.x * obj.x + this.y * obj.y);
        }

        public Vetor2D Soma(Vetor2D obj)
        {
            Vetor2D temp = new Vetor2D();
            temp.x = this.x + obj.x;
            temp.y = this.y + obj.y;

            return (temp);
        }

        public static Vetor2D Soma2(Vetor2D obj1, Vetor2D obj2) 
        {
            Vetor2D temp = new Vetor2D();
            temp.x = obj1.x + obj2.x;
            temp.y = obj1.y + obj2.y;

            return (temp);
        }

        public void Imprime()
        {
            Console.WriteLine("Abscissa do vetor: " + x);
            Console.WriteLine("Ordenada do vetor: " + y);
            Console.WriteLine("(" + x + "; " + y + ")");
        }
    } // fim da classe Vetor2D
}
