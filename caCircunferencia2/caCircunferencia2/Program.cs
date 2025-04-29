using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caCircunferencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo");
            Ponto p1 = new Ponto(); // p1 é um objeto da classe Ponto
            Ponto p2 = new Ponto(5, 8);

            Console.WriteLine("X do p1 " + p1.getX());
            Console.WriteLine("Y do p1 " + p1.getY());

            Console.WriteLine("X do p2 " + p2.getX());
            Console.WriteLine("Y do p2 " + p2.getY());

            p1.setX(10);
            p1.setY(20);
            
            p1.imprimir();

            Circunferencia c1 = new Circunferencia(10, p1); // c1 é um objeto da classe Circunferencia
            c1.imprimir();
            Console.WriteLine("Area do c1 " + c1.Area());
            Console.WriteLine("Comprimento do c1 " + c1.Comprimento());
            Console.ReadLine();

            c1.raio = 10;

            Console.WriteLine("Area do c1 " + c1.Area());
            Console.WriteLine("Comprimento do c1 " + c1.Comprimento());
            Console.ReadLine();
        } // fim do void Main
    }
}
