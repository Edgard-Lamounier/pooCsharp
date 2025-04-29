using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Aluno a1 = new Aluno();

            Aluno a2 = new Aluno();

            a1.setNome("Joao");
            a1.Nome = "João";

            a2.setNome("Maria");

            Console.WriteLine("Nome = " + a1.Nome);

            a1.setPeriodo(1);

            a2.setPeriodo(5);

            Console.WriteLine("O aluno " + a2.getNome() + "  está no " + a2.getPeriodo() + " periodo");

            Aluno a3 = new Aluno("1eb24987", 5, "João da Silva");
            
            Console.ReadLine();

        }
    }
}
