using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaPessoaFisica_Juridica
{
    internal class PessoaFisica : Pessoa
    {
        // atributos
        private string cpf;
        private int qteFilhos;
        double salario;

        // métodos
        public PessoaFisica() : base()
        {
            
        }

        public PessoaFisica(string _nome, string  _cidade, string _cpf,
                   int _qtdFilhos, double _salario) : base(_nome, _cidade)
        {
            cpf = _cpf;
            qteFilhos = _qtdFilhos;
            salario = _salario;
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public int QteFilhos { get => qteFilhos; set => qteFilhos = value; }
        public double Salario { get => salario; set => salario = value; }

        public override double CalcCred()
        {
            return Salario * 12 - QteFilhos * 10;
        }
    } // fim da classe PessoaFisica
}
