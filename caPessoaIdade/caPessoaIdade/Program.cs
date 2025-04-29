using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPessoaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("João", 18);
            Pessoa p2 = new Pessoa("Maria", 45);
            Pessoa p3 = new Pessoa("José", 25);

            if((p1.idade >= p2.idade) && (p1.idade >= p3.idade))
            {
                Console.WriteLine("A pessoa " + p1.nome + " tem a maior idade = " + p1.idade);
            }
            else if ((p2.idade >= p1.idade) && (p2.idade >= p3.idade))
            {
                Console.WriteLine("A pessoa " + p2.nome + " tem a maior idade = " + p2.idade);
            }
            else if ((p3.idade >= p1.idade) && (p3.idade >= p2.idade))     
            {
                Console.WriteLine("A pessoa " + p3.nome + " tem a maior idade = " + p3.idade);
            }

            Console.ReadLine();
        }
    }
}
