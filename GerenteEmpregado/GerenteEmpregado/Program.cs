using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace GerenteEmpregado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEmpregados l1 = new ListaEmpregados();

            Empregado e1 = new Empregado("José", "Almoxarifado", 1000.00);
            Empregado e2 = new Gerente("Mané", "Financeiro", 1000.00, "Maria");

            l1.adicionaEmpregado(e1);
            l1.adicionaEmpregado(e2);

            e1.aumentaSalario(10);
            e2.aumentaSalario(10);

            l1.imprimeLista();

            Console.ReadLine();
        }
    }
}
