// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int quociente(int numerador, int denominador)
{
    return (numerador / denominador);
}

int num, den = 0;


try
{
    
    Console.WriteLine("Entre o numerador : ");
    num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Entre o denominador : ");
    den = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Quociente: " + quociente(num, den));
    Console.ReadLine();
}

catch(DivideByZeroException)
{
    Console.WriteLine("Divisão por by zero.", den);
}

catch (FormatException)
{
    Console.WriteLine("Formato by diferente.", den);
}
