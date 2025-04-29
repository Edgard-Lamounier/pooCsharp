using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregadoGerente
{
    internal class Empregado
    {
        protected string nome;
        protected string secao;
        protected double salario;

        public Empregado() 
        {
            nome = string.Empty;
            secao = string.Empty;
            salario = 0.0;
        }

        public Empregado(string  _nome, string _secao, double _salario)
        {
            nome = _nome;
            secao = _secao;
            salario = _salario;
        }


        public string Nome { get => nome; set => nome = value; }
        public string Secao { get => secao; set => secao = value; }
        public double Salario { get => salario; set => salario = value; }

        public virtual void imprimeDados()
        {
            Console.WriteLine("Nome = " +  nome);
            Console.WriteLine("Seção = " + secao);
            Console.WriteLine("Salário = " + salario);
        }

        public virtual void aumentaSalario(double  aumento) // tem implementacao na classe base
                                                            // abstract -- nao tem implementacao na classe base
        {
            salario = salario * (1 + (aumento / 100.0)); 
        }
    }
}
