﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno4
{
    internal class Materia
    {
        private string nome;
        private string codigo;

        public Materia() { }

        public Materia(string _nome, string _codigo)
        {
            nome = _nome;
            codigo = _codigo;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
