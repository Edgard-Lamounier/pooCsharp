using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aux = 1;
            while (aux != 0)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção do menu :\n");
                Console.WriteLine(" [1] - Cadastrar um aluno");
                Console.WriteLine(" [2] - Cadastrar uma matéria");
                Console.WriteLine(" [3] - Associar uma matéria a um aluno");
                Console.WriteLine(" [4] - Imprimir relatório");
                Console.WriteLine(" [5] - Sair");

                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.ReadLine();
                        break;

                    case "2":
                        /* Comandos */
                        Console.ReadLine();
                        break;
                    case "3":
                        /* Comandos */
                        Console.ReadLine();
                        break;

                    case "4":
                        /* Comandos */

                        Console.ReadLine();
                        break;

                    case "5":
                        /* Comandos */
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Favor selecionar uma das opções mostradas no menu");
                        Console.ReadLine();
                        break;
                } // fim do switch

            }  // fim do while




            ////////// VERSÃO INICIAL ///////////////////////////
            //Aluno a1 = new Aluno("Maria Silva", "irenre122", 5);
            //Aluno a2 = new Aluno("Joao Batista", "fgereref", 8);

            //Materia m1 = new Materia("POO", "PPGEB02");
            //Materia m2 = new Materia("ED", "PPGEB05");
            //Materia m3 = new Materia("ESOG", "FEELT54");

            //// Maria Silva cursa POO e ED
            //a1.associaMateria(m1);
            //a1.associaMateria(m2);

            //// Joao Batista cursa ED e ESOF
            //a2.associaMateria(m2);
            //a2.associaMateria(m3);
            ////////// VERSÃO INICIAL ///////////////////////////
        }
    }
}
