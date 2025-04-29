using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caMaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrando as 3 Pessoas (criando 3 objetos da classe Pessoa)
            Pessoa p1 = new Pessoa();
            Console.WriteLine("Entre com o nome da 1a. pessoa: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com a idade da 1a. pessoa: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            p1.Nome = nome;
            p1.Idade = idade;

            Console.WriteLine("Entre com o nome da 2a. pessoa: ");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Entre com a idade da 2a. pessoa: ");
            int idade2 = Convert.ToInt32(Console.ReadLine());
            Pessoa p2 = new Pessoa(nome2, idade2);

            Console.WriteLine("Entre com o nome da 3a. pessoa: ");
            string nome3 = Console.ReadLine();
            Console.WriteLine("Entre com a idade da 3a. pessoa: ");
            int idade3 = Convert.ToInt32(Console.ReadLine());
            Pessoa p3 = new Pessoa(nome3, idade3);

            // Calcular a pessoa de maior idade

            Console.WriteLine("A pessoa de maior idade é:");
            if (p1.Idade > p2.Idade && p1.Idade > p3.Idade)
                p1.ExibeDados();
            else if (p2.Idade > p1.Idade && p2.Idade > p3.Idade)
                p2.ExibeDados();
            else
                p3.ExibeDados();

            Console.ReadLine();
                
        }
    }
}
