using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaEmpregadoCLT_HORISTA
{
    internal class Empregado
    {
        protected string primeiroNome;
        protected string segundoNome;
        protected string cpf;

        public string PrimeiroNome { get => primeiroNome; set => primeiroNome = value; }
        public string SegundoNome { get => segundoNome; set => segundoNome = value; }
        public string Cpf { get => cpf; set => cpf = value; }

        public Empregado()
        {
            primeiroNome = string.Empty;
            segundoNome = string.Empty;
            cpf = string.Empty;
        }

        public Empregado(string primeiroNome, string segundoNome, string cpf)
        {
            this.primeiroNome = primeiroNome;
            this.segundoNome = segundoNome;
            this.cpf = cpf;
        }

        public virtual double getSalLiquido() 
        { return 0.0; }
    }
}
