using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregadoGerente
{
    internal class Gerente : Empregado // Gerente é uma classe derivada de Empregado (Gerente herda de Empregado)
    {
        private string secretaria;

        public Gerente() : base() // construtor default
        { 
            secretaria = string.Empty;
        }

        public Gerente(string _nome, string _secao, double _salario, 
            string  _secretaria) : base(_nome, _secao, _salario)
        {
            secretaria = _secretaria;
        }
        
        public string Secretaria { get => secretaria; set => secretaria = value; }

        public override void imprimeDados()
        {
            base.imprimeDados();
            Console.WriteLine("Secretaria = " + secretaria);
        }

        public override void aumentaSalario(double aumento)
        {
            double novoAumento = aumento + 5.0;
            base.aumentaSalario(novoAumento);
        }
    }
}
