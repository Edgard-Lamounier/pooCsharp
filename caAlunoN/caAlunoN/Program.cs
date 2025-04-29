using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá");
            Aluno aluno1 = new Aluno(); // construtor default

            Aluno aluno2 = new Aluno("Maria", 12345, "(34)99548-3220");

            aluno1.imprime();
            aluno2.imprime();
            Console.ReadLine();
        }
    }
}
