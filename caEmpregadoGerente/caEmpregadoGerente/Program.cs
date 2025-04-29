// See https://aka.ms/new-console-template for more information
using caEmpregadoGerente;

ListaEmpregados l1 = new ListaEmpregados();

Empregado  e1 = new Empregado("José", "Almoxarifado", 1000.00);

Empregado  g1 = new Gerente("Mané", "Financeiro", 1000.00, "Maria");

l1.adicionaEmpregado(e1);
l1.adicionaEmpregado(g1);

e1.aumentaSalario(10.0);
g1.aumentaSalario(10.0);



l1.imprimeLista();



Console.ReadLine();


/*
listaEmpregados[0] = e1;
listaEmpregados[1] = g1;

Gerente g2 = new Gerente("Mané", "Financeiro", 1000.00, "Maria");

Empregado g3 = new Empregado();



listaEmpregados[2] = g2;

g3 = listaEmpregados[2];

g2.Secretaria = "Tunica";
listaEmpregados[2].Secretaria = "Tunica";


case listaEmpregados[i].GetTypeof() == "Gerente":
    ((Gerente))listaEmpregados[i].Secretaria







for (int i = 0; i <= 1; i++)
{
    listaEmpregados[i].imprimeDados();
    listaEmpregados[i].aumentaSalario(20);
    listaEmpregados[i].imprimeDados();
    Console.WriteLine();
}

Console.ReadLine();
*/