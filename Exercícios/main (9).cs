using System;

class CompararTresNumeros
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n--- Comparação de Três Números ---");

        Console.Write("Digite o valor de a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de c: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine($"Valores lidos: a={a}, b={b}, c={c}");

        if (a > b && a > c)
        {
            Console.WriteLine($"{a} é o maior.");
        }
        else if (b > a && b > c)
        {
            Console.WriteLine($"{b} é o maior.");
        }
        else
        {
            Console.WriteLine($"{c} é o maior.");
        }
    }
}