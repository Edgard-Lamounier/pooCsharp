// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("**** Cálculo do Fatorial ****");

Console.WriteLine("Entre um número natural:");

string n = Console.ReadLine();

int n1 = int.Parse(n);

int fat = 1;

for (int i = 1; i <= n1; i++)
    fat = fat * i;

Console.WriteLine("O fatorial de " + n1 + " é: " +  fat);