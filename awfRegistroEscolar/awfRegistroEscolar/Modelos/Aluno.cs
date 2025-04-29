using System;
using System.Text;

namespace awfRegistroEscolar.Modelos
{
    public class Aluno
    {
        private string _nome;
        private string _cpf;
        private string _matricula;

        private List<Materia> _materias;
        private Curso _curso;

        public string Nome { get => _nome; set => _nome = value; }
        public string CPF { get => _cpf; set => _cpf = value;  }
        public string Matricula { get => _matricula; set => _matricula = value; }

        public Materia[] Materias => this._materias.ToArray();
        public Curso Curso { get => _curso; set => _curso = value; }


        public Aluno(string nome, string cpf, string nMatricula, Curso curso)
        {
            this._nome = nome;
            this._cpf = cpf;
            this._matricula = nMatricula;

            this._curso = curso;
            this._materias = new List<Materia>();
        }

        public void VincularMateria(Materia materia)
        {
            if (!this.Materias.Contains(materia))
                this._materias.Add(materia);
        }

        public void RemoverMateria(Materia materia)
        {
            this._materias.Remove(materia);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            int qtd = this._materias.Count;
            for(int i = 0; i < qtd; i++)
            {
                sb.Append($" ({this._materias[i].Codigo}) ");
            }

            return $".Nome: {this.Nome} \t.CPF: {this.CPF} \t.Matricula: {this.Matricula} \n" +
                $"\t.Código Curso: {this.Curso.Codigo} \n" +
                $"\t.Matérias: {sb.ToString()}";
        }
    }
}
