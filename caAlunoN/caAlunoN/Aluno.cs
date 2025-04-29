using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoN
{
    internal class Aluno
    {
        // atributos
        private string nome;
        private int    numero_matricula;
        private string telefone;

        // métodos
        public Aluno() // construtor default
        {
            nome = string.Empty;
            numero_matricula = 0;
            telefone = string.Empty;
        }

        public Aluno(string nome, int numero_matricula, string telefone)
        {
            this.nome = nome;
            this.numero_matricula = numero_matricula;
            this.telefone = telefone;
        }

        public void imprime()
        {
            Console.WriteLine("Nome = " + nome);
            Console.WriteLine("Número Matrícula = " +  numero_matricula);
            Console.WriteLine("Telefone = " +  telefone);
        }
    }
}
