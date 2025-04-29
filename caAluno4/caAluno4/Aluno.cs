using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno4
{
    internal class Aluno
    {
        // atributos 
        private string nome;
        private string matricula;
        private int periodo;
        private Materia[] lista_materias = new Materia[8];
        private int cont_materia;

        // métodos
        public Aluno() // ARIDADE 0
        {
            cont_materia = 0;
        }

        public Aluno(string _nome, string _matricula, int _periodo) // ARIDADE 3
        {
            nome = _nome;
            matricula = _matricula;
            periodo = _periodo;
            cont_materia = 0;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public int Cont_materia { get => cont_materia; set => cont_materia = value; }
        internal Materia[] Lista_materias { get => lista_materias; set => lista_materias = value; }


        public void associaMateria(Materia m)
        {
            lista_materias[cont_materia] = m;
            cont_materia++; // cont_materia = cont_materia + 1;
        }
    }
}
