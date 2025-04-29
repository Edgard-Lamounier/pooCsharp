using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunaMateria
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
                        // criar um objeto da classe Aluno
                        Aluno a = new Aluno();

                        // atribuir valores para os atributos do objeto
                        Console.WriteLine("Entre o nome do Aluno: ");
                        a.Nome = Console.ReadLine();
                        Console.WriteLine("Entre a matrícula do Aluno: ");
                        a.NroMatricula = Console.ReadLine();
                        Console.WriteLine("Entre o período do Aluno: ");
                        a.Periodo = Convert.ToInt32(Console.ReadLine());

                        // adicionar o objeto criado ao array de Alunos
                        arrayAlunos[contAlunos] = a;
                        contAlunos++;
                        Console.ReadLine();
                        break;

                    case "2":
                        /* Comandos */
                        Console.ReadLine();
                        break;
                    case "3":
                        /* Comandos */
                        // Apresentar a lista de alunos e solicita o número de matricula
                        Console.WriteLine("Escolha o número do aluno abaixo");
                        imprimeListaAlunos(arrayAlunos, contAlunos);
                        string num_aluno_escolhido = Console.ReadLine();

                        // Apresentar a lista de matérias e solicita o código de matricula
                        // Associar o aluno à materia
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

        } // fim do Main
    }
}
