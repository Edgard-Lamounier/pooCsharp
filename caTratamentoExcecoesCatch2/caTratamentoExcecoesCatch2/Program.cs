using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTratamentoExcecoesCatch2
{
    internal class Program
    {
        public static int quociente(int numerador, int denominador)
        
        {
            return (numerador / denominador);
        }
        static void Main(string[] args)
        {
            bool continueLoop = true;
            do
            { // TRATAMENTO DE EXCECOES
                try  // "tente" rodar o codigo abaixo
                {
                    Console.WriteLine("Entre o numerador: ");
                    int numerador = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Entre o denominador: ");
                    int denominador = Convert.ToInt32(Console.ReadLine());

                    int resultado = quociente(numerador, denominador);
                    Console.WriteLine("Quociente: " + resultado);
                    continueLoop = false;
                    Console.ReadLine();
                } // fim do try


                catch (ArithmeticException arithmeticException)
                {
                    Console.WriteLine("Ocorreu uma excecao aritimetica: ",
                             arithmeticException);
                    Console.WriteLine("Nao existe divisao por zero. Tente de novo.\n");
                } // fim do catch

                catch (FormatException formatException)
                {
                    Console.WriteLine("Ocorreu uma excecao de formato: ",
                             formatException);
                    Console.WriteLine("Precisa ser um numero inteiro. Tente de novo.\n");
                } // fim do catch



            } while (continueLoop); // fim da instrução do...while

        } // fim do void Main
    }
}
