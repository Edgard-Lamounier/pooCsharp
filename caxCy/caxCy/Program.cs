using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caxCy
{
    internal class Program
    {
        public static int localizaIndiceC(string exp)
        {
            int i = 0;
           
            while (exp[i] != 'C')
            {
                i++;
            }

            return i;
        }

        public static bool ehIgual(int indice, string exp, Pilha p)
        {
            
            for (int j = indice + 1; j < exp.Length; j++)
            {
                if (exp[j] != p.remove())
                    return false;
            }

            return true;    
        }

        static void Main(string[] args)
        {
            // ler a string do teclado
            Console.WriteLine("Entre uma expressão do tipo 'xCy' = ");
            string exp = Console.ReadLine();

            // localizar indice do C
            int indice = localizaIndiceC(exp);
            Console.WriteLine("Indice do C: " + indice);
            Console.WriteLine("Tamanho da string: " + exp.Length);

            // percorre a string até o indice, jogando na Pilha
            Pilha pilha = new Pilha();
            for(int i = 0; i < indice; i++)
            {
                pilha.insere(exp[i]);
            }

            pilha.imprime();
            Console.ReadLine();

            bool isEqual = ehIgual(indice, exp, pilha);

            if (isEqual == true)
                Console.WriteLine("É o inverso");
            else 
                Console.WriteLine("Não é o inverso");

            Console.ReadLine();
        }

            
            
        
    }
}
