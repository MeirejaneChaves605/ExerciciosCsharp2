using System;

class ComparadorDeSoma
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Comparador de Soma ---");
        
        // Lê o valor de A
        Console.Write("Digite o valor de A: ");
        int a = int.Parse(Console.ReadLine());

        // Lê o valor de B
        Console.Write("Digite o valor de B: ");
        int b = int.Parse(Console.ReadLine());

        // Lê o valor de C
        Console.Write("Digite o valor de C: ");
        int c = int.Parse(Console.ReadLine());

        // Calcula a soma de A e B
        int somaAB = a + b;

        // Compara a soma com C e exibe a mensagem correspondente
        if (somaAB < c)
        {
            Console.WriteLine($"\nA soma de A e B ({somaAB}) é MENOR que C ({c}).");
        }
        else if (somaAB > c)
        {
            Console.WriteLine($"\nA soma de A e B ({somaAB}) é MAIOR que C ({c}).");
        }
        else // somaAB == c
        {
            Console.WriteLine($"\nA soma de A e B ({somaAB}) é IGUAL a C ({c}).");
        }
    }
}