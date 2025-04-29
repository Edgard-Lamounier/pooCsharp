using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caEmpregadoGerente
{
    internal class ListaEmpregados
    {
        Empregado[] listaEmpregados = new Empregado[100];
        int conta_empregados;

        public ListaEmpregados()
        {
            conta_empregados = 0;
        }

        public void adicionaEmpregado(Empregado e)
        {
            listaEmpregados[conta_empregados] = e;
            conta_empregados++;
        }

        public void imprimeLista()
        {
            for (int i = 0; i < conta_empregados; i++)
                listaEmpregados[i].imprimeDados();
        }
    }
}
