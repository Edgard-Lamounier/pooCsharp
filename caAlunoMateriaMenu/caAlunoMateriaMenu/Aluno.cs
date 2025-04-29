using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoMateriaMenu
{
    internal class Aluno
    {
        // atributos
        private string  nome;
        private string  nroMatricula;
        private int     periodo;

        // métodos
        public Aluno()
        {
            nome = string.Empty;
            nroMatricula = string.Empty;
            periodo = 0;
        }

        public Aluno( string _nome, string _nroMatricula, int _periodo )
        {
            nome = _nome;
            nroMatricula= _nroMatricula;
            periodo = _periodo; 
        }

        // getters & setters
        public string Nome { get => nome; set => nome = value; }
        public string NroMatricula { get => nroMatricula; set => nroMatricula = value; }
        public int Periodo { get => periodo; set => periodo = value; }

    } // fim da classe Aluno
}
