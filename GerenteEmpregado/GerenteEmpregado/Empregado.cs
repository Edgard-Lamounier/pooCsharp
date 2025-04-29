using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenteEmpregado
{
    internal class Empregado
    {
        // atributos
        protected string nome;
        protected string secao;
        protected double salario;

        // métodos

        public Empregado() 
        {
            nome = string.Empty;
            secao = string.Empty;
            salario = 0.0;
        }

        public Empregado(string _nome, string _secao, double _salario)
        {
            nome = _nome;
            secao = _secao;
            salario = _salario;
        }

        protected string Nome { get => nome; set => nome = value; }
        protected string Secao { get => secao; set => secao = value; }
        protected double Salario { get => salario; set => salario = value; }

        public virtual void imprimeDados()
        {
            Console.WriteLine("Nome = " + nome);
            Console.WriteLine("Seção = " + secao);
            Console.WriteLine("Salário = " + salario);
        }

        public virtual void aumentaSalario(double aumento)
        {
            salario = salario * (1 + (aumento / 100.0));
        }
    }
}
