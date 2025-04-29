using System;

namespace awfRegistroEscolar.Modelos
{
    public class Curso
    {
        private string _nome;
        private string _codigo;

        public string Nome => this._nome;
        public string Codigo => this._codigo;

        public Curso(string nome, string codigo)
        {
            this._nome = nome;
            this._codigo = codigo;
        }

        public override string ToString()
        {
            return $".Nome: {this.Nome} .\tCódigo: {this.Codigo}";
        }
    }
}
