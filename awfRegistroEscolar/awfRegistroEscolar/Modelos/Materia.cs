using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awfRegistroEscolar.Modelos
{
    public class Materia
    {
        private string _nome;
        private string _codigo;

        private Curso _curso;

        public string Nome => this._nome;
        public string Codigo => this._codigo;

        public Curso Curso => this._curso;

        public Materia(string nome, string codigo, Curso curso)
        {
            this._nome = nome;
            this._codigo = codigo;
            this._curso = curso;
        }

        public override string ToString()
        {
            return $".Nome: {this.Nome} \t.Código: {this.Codigo} \t.Código Curso: {this.Curso.Codigo}";
        }
    }
}
