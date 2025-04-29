using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoMateriaMenu
{
    internal class Materia
    {
        // atributos 
        private string nome;
        private string codigo;

        // métodos
        public Materia() { }

        public Materia(string _nome, string _codigo)
        {
            nome = _nome;
            codigo = _codigo;
        }

        // getters & setters
        public string Nome { get => nome; set => nome = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        
    } // fim da classe Materia
}
