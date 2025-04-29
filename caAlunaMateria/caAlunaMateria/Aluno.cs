using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunaMateria
{
    internal class Aluno
    {
        // atributos
        private string nome;
        private string nroMatricula;
        private int periodo;
        private Materia[] lista_materias = new Materia[8];
        private int qteMaterias;  // controla o indice do array de Materias do Aluno

        // métodos

        /*****   construtores *****/
        public Aluno()
        {
            nome = string.Empty;
            nroMatricula = string.Empty;
            periodo = 0;
            qteMaterias = 0;
        }

        public Aluno(string nome, string nroMatricula, int periodo)
        {
            Nome = nome; // nome = _nome
            NroMatricula = nroMatricula;
            Periodo = periodo;
            qteMaterias = 0;
        }

        /*****   getters & setters *****/
        public string Nome { get => nome; set => nome = value; }
        public string NroMatricula { get => nroMatricula; set => nroMatricula = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public int QteMaterias { get => qteMaterias; set => qteMaterias = value; }
        internal Materia[] Lista_materias { get => lista_materias; set => lista_materias = value; }
    
    } // fim da classe Aluno
}
