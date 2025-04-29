using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoMateriaX
{
    internal class Program
    {
        public static void imprimeListaAlunos(Aluno[] arrayAlunos, int contAlunos)
        {
            Console.WriteLine("= = = RELATÓRIO LISTA DE ALUNOS = = =");
            for (int i = 0; i < contAlunos; i++)
            {
                Console.WriteLine("Nome do Aluno = " + arrayAlunos[i].Nome);
                Console.WriteLine("Número de Matrícula = " + arrayAlunos[i].Numero_matricula);
                Console.WriteLine("Período = " + arrayAlunos[i].Periodo);
            }
        }

        public static void imprimeListaMaterias(Materia[] arrayMaterias, int contMaterias)
        {
            Console.WriteLine("= = = RELATÓRIO LISTA DE MATÉRIAS = = =");
            for (int i = 0; i < contMaterias; i++)
            {
                Console.WriteLine("Nome da Materia = " + arrayMaterias[i].Nome);
                Console.WriteLine("Código da Matéria = " + arrayMaterias[i].CodMateria);
            }
        }

        public static Aluno EncontraAluno(string num_aluno_escolhido, Aluno[] arrayAlunos)
        {
            for (int t = 0; t <= arrayAlunos.Length; t++)
            {
                if (arrayAlunos[t].Numero_matricula == num_aluno_escolhido)
                {
                    return arrayAlunos[t];
                }
            }

            return null;
        }


        public static Materia EncontraMateria(string cod_materia_escolhida, Materia[] arrayMaterias)
        {
            for (int t = 0; t <= arrayMaterias.Length; t++)
            {
                if (arrayMaterias[t].CodMateria == cod_materia_escolhida)
                {
                    return arrayMaterias[t];
                }
            }

            return null;
        }


        public static void AssociaDisciplinaAluno(string num_aluno_escolhido, Aluno[] arrayAlunos,
            string cod_materia_escolhida, Materia[] arrayMaterias)
        {
            Aluno a = EncontraAluno(num_aluno_escolhido, arrayAlunos);
            Materia m = EncontraMateria(cod_materia_escolhida, arrayMaterias);

            a.adicionaMateria(m);

            //a.Lista_materias[a.Cont_materia] = m;
            //a.Cont_materia++;
        }

        static void Main(string[] args)
        {
            Aluno[] arrayAlunos = new Aluno[100]; // array para armazenar 100 alunos
            Materia[] arrayMaterias = new Materia[100]; // array para armazenar 100 materias

            int contAlunos = 0;
            int contMaterias = 0;

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
                        Console.Clear(); // limpa a tela
                        Aluno a = new Aluno(); // cria um objeto da classe Aluno
                        Console.WriteLine("Entre o nome do aluno: ");
                        a.Nome = Console.ReadLine(); // instancia o atributo nome 
                        Console.WriteLine("Entre a matrícula do aluno: ");
                        a.Numero_matricula = Console.ReadLine(); // instancia o atributo matricula 
                        Console.WriteLine("Entre o período do aluno: ");
                        a.Periodo = Convert.ToInt32(Console.ReadLine()); // // instancia o atributo periodo 
                        arrayAlunos[contAlunos] = a;
                        contAlunos++;
                        Console.WriteLine("Aluno cadastrado com sucesso!");
                        Console.ReadLine();
                        break;

                    case "2":
                        /* Comandos */
                        Console.Clear();
                        Materia m = new Materia();
                        Console.WriteLine("Entre o nome da matéria: ");
                        m.Nome = Console.ReadLine();
                        Console.WriteLine("Entre o código da matéria: ");
                        m.CodMateria = Console.ReadLine();
                        arrayMaterias[contMaterias] = m;
                        contMaterias++;
                        Console.WriteLine("Matéria cadastrada com sucesso!");
                        Console.ReadLine();
                        break;
                    case "3":
                        /* Comandos */
                        Console.Clear();
                        Console.WriteLine("Escolha o número do aluno abaixo");
                        imprimeListaAlunos(arrayAlunos, contAlunos);
                        string num_aluno_escolhido = Console.ReadLine();

                        Console.WriteLine("Escolha o código da matéria abaixo");
                        imprimeListaMaterias(arrayMaterias, contMaterias);
                        string cod_materia_escolhida = Console.ReadLine();

                        AssociaDisciplinaAluno(num_aluno_escolhido, arrayAlunos,
                                              cod_materia_escolhida, arrayMaterias);
                        Console.ReadLine();
                        break;

                    case "4":
                        /* Comandos */
                        for (int y = 0; y < contAlunos; y++)
                        {
                            Console.WriteLine("\r\nAluno " + arrayAlunos[y].Nome + " :");
                            arrayAlunos[y].ImprimeMaterias();
                            Console.WriteLine("____________________________");
                        }


                        Console.ReadLine();
                        Console.Clear();
                        Console.Clear();
                        break;

                    case "5":
                        /* Comandos */
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("Favor selecionar uma das opções mostradas no menu\n");
                        break;
                } // fim do switch

            }  // fim do while

        } // fim da classe Main
    }
}
