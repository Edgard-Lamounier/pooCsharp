using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caFuncionario
{
    internal class Funcionário
    {
        // atributos
        private string nome;
        private double salario;
        private string cargo;

        // métodos
        public void imprimeDados()
        {
           Console.WriteLine("Nome = " +  nome);
           Console.WriteLine("Salário = " + salario);
           Console.WriteLine("Cargo = " + cargo);
        }

        public Funcionário() // construtor default
        {
            nome = " ";
            salario = 0.0;
            cargo = " ";
        }
        
        public Funcionário(string n, double s, string  c) // construtor
        {
            nome = n;
            salario = s;
            cargo = c;
        }

        public Funcionário(string n, string c) // construtor
        {
            nome = n;
            cargo= c;
        }


        public void alteraSalario(double novoSalario) 
        { 
            salario = novoSalario;
        }

        // para calcular o salario liquido, descontar 15%
        public double salarioLiquido()
        { 
            return salario * 0.85; // desconto de 15%
        }
    }
}
