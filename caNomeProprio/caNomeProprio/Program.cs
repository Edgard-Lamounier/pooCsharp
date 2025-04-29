using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNomeProprio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // char[] nome_proprio = new char[20];
            string nome_proprio;

            nome_proprio = Console.ReadLine();
            Console.WriteLine("Nome = " + nome_proprio);
            Console.ReadLine();

            for(int i = 0; i < nome_proprio.Length; i++)
                Console.WriteLine(nome_proprio[i]);
            Console.ReadLine();

        }
    }
}
