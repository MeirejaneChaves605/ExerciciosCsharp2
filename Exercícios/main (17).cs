 using System;

class ComparadorNumeros
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Qual é o maior número? ---");
        
        // Lê o primeiro número
        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        // Lê o segundo número
        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Compara os dois números para determinar qual é o maior
        if (numero1 > numero2)
        {
            Console.WriteLine($"\nO maior número é: {numero1}");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine($"\nO maior número é: {numero2}");
        }
        else // O caso em que os dois números são iguais
        {
            Console.WriteLine("\nOs números digitados são iguais.");
        }
    }
}