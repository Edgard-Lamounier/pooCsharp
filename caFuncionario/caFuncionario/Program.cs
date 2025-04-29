using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Funcionario");
            // criando um objeto da classe Funcionario
            Funcionário func1 = new Funcionário(); // construtor default

            // objeto func1 executa método imprimeDados()
            func1.imprimeDados();

            // criando outro objeto da classe Funcionário
            Funcionário func2 = new Funcionário("João Silva", 3500.00, "Analista"); // construtor com parâmetros
            func2.imprimeDados();

            func2.alteraSalario(4500.00);
            Console.WriteLine("Salario Liquido do func2 = " + func2.salarioLiquido());
            func2.imprimeDados();

            Funcionário func3 = new Funcionário("Maria das Dores", "Gerente");
            func3.imprimeDados();

            func3.alteraSalario(5000.00);
            func3.imprimeDados();
            Console.ReadLine();
        }
    }
}
