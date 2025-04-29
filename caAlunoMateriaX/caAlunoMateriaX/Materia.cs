using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAlunoMateriaX
{
    internal class Materia
    {
        // atributos
        private string nome;
        private string codMateria;

        // métodos
        public Materia()
        {
            nome = string.Empty;
            codMateria = string.Empty;
        }

        public Materia(string nome, string codMateria)
        {
            Nome = nome;
            CodMateria = codMateria;
        }



        /*****   getters & setters *****/
        public string Nome { get => nome; set => nome = value; }
        public string CodMateria { get => codMateria; set => codMateria = value; }




    } // fim da classe Materia
}
