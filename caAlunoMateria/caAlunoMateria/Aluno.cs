using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoMateria
{
    internal class Aluno
    {
        // atributos
        private string nome;
        private string numero_matricula;
        private int periodo;
        private Materia[] lista_materias = new Materia[8];
        private int cont_materia;

        // métodos
        public Aluno ()
        {
            nome = string.Empty;
            numero_matricula = string.Empty;
            periodo = 0;
            cont_materia = 0;
        }

        public Aluno(string _nome, string _numero_matricula, int _periodo)
        {
            nome = _nome;
            numero_matricula = _numero_matricula;
            periodo = _periodo;
            cont_materia = 0;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Numero_matricula { get => numero_matricula; set => numero_matricula = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public int Cont_materia { get => cont_materia; set => cont_materia = value; }
        internal Materia[] Lista_materias { get => lista_materias; set => lista_materias = value; }

        public void adicionaMateria(Materia m)
        {
            lista_materias[cont_materia] = m;
            cont_materia++;
        }
        
        public void ImprimeMaterias()
        {

            for (int w = 0; w < cont_materia; w++)
            {
                Console.WriteLine("Materia " + (w + 1) + ": " + lista_materias[w].Nome);
            }
        }


    } // fim da classe Aluno
}
