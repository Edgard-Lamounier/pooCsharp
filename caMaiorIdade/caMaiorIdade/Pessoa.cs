using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caMaiorIdade
{
    internal class Pessoa
    {
        // atributos
        private string nome;
        private int idade;

        // métodos

        public Pessoa()
        {
            nome = string.Empty;
            idade = 0;
        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;  
        }

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }

        public void ExibeDados()
        {
            Console.WriteLine("Nome = " + Nome);
            Console.WriteLine("Idade = " + Idade);
        }

    } // fim da classe Pessoa
}
