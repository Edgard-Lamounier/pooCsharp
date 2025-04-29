using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoMateria
{
    internal class Materia
    {
        // atributos
        private string nome;
        private string codigo;

        // métodos
        public Materia() 
        {
            nome = string.Empty;
            codigo = string.Empty;
        }

        public Materia(string _nome, string _codigo)
        {
            nome = _nome;
            codigo = _codigo;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    } // fim da classe Materia
}
