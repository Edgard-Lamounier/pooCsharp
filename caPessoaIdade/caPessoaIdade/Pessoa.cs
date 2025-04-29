using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caPessoaIdade
{
    internal class Pessoa
    {
        // atributos 
        public string nome;
        public int idade;

        // métodos
        public Pessoa() 
        {
            nome = " ";
            idade = 0;
        }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome = " + nome);
            Console.WriteLine("Idade = " + idade);
        }
    }
}
