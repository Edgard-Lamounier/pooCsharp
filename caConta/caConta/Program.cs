using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caConta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Conta c1 = new Conta("Zé", "1235-85", 200.00);
            
            c1.Nome = "Zé da Silva";
            c1.setSaldo(800.00); 
            c1.imprimeDados();

            Console.WriteLine("Saldo da Conta c1 = " + c1.Saldo);
            Console.WriteLine("CPF da Conta c1 = " + c1.getCPF());
            */

            // 1. Criar um array com 3 contas:
            Conta[] arrayContas = new Conta[10]; // criando um array que poderá 
                                                 // conter 10 objetos da classe Conta

            for(int i = 0; i <= 2; i++)
            {
                Conta a = new Conta();
                Console.WriteLine("Criando a " + (1 + i) + " Conta:");
                Console.WriteLine("Entre o nome = ");
                a.Nome = Console.ReadLine();
                Console.WriteLine("Entre o CPF = ");
                a.Cpf = Console.ReadLine();
                Console.WriteLine("Entre o Saldo = ");
                a.Saldo = Convert.ToDouble(Console.ReadLine());
                arrayContas[i] = a; 
            }


            // 2. Imprimir os nomes de cada conta:
            for (int k = 0; k <= 2; k++)
            {
                Console.WriteLine("Imprimindo os nomes das contas:");
                Console.WriteLine("Conta " + (k + 1) + "Nome = " + arrayContas[k].Nome);
            }

            // 3. Imprimir o saldo da conta cujo nome é Maria
            for (int k = 0; k <= 2; k++)
            {
                if (arrayContas[k].Nome == "Maria")
                    Console.WriteLine("Saldo da Maria = " + arrayContas[k].Saldo);
            }

            Console.ReadLine();

        }
    }
}
