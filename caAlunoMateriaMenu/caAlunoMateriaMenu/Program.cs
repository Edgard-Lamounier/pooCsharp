using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoMateriaMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aluno[] arrayAlunos = new Aluno[100]; // array para armazenar 100 alunos
            //Materia[] arrayMaterias = new Materia[100]; // array para armazenar 100 matérias

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

        }
    }
}
