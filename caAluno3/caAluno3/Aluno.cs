using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno3
{
    internal class Aluno
    {
        // o que um aluno tem? -- atributos
        private string numero_matricula;
        private int periodo;
        private string nome;

        public string Numero_matricula { get => numero_matricula; set => numero_matricula = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public string Nome { get => nome; set => nome = value; }

        // o que um aluno faz? -- métodos
        public Aluno()
        {

        }


        public Aluno(string a, int b, string c)
        {
            numero_matricula = a;
            periodo = b;
            nome = c;
        }

        public void setNome(string x)
        {
            nome = x;
        }

        public string getNome()
        {
            return nome;
        }


        public void setPeriodo(int p)
        {
            periodo = p;
        }

        public int getPeriodo()
        {
            return periodo;
        }

    }
}
