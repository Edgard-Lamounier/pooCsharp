using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaPessoaFisica_Juridica
{
    internal class Pessoa
    {
        // atributos
        protected string nome;
        protected string cidade;

        // métodos
        public Pessoa() { }

        public Pessoa(string _nome, string _cidade)
        {
            nome = _nome;
            cidade = _cidade;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }

        public virtual double CalcCred()
        {
            return 0.0;
        }



    } // fim da classe Pessoa
}
