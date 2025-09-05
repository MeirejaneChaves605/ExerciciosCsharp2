 using System;

class ComparadorNumerico
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Comparação de Dois Números ---");
        
        // Lê o primeiro número
        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        // Lê o segundo número
        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Verifica se os números são iguais ou diferentes
        if (numero1 == numero2)
        {
            Console.WriteLine("\nOs números são IGUAIS.");
            Console.WriteLine($"Valor: {numero1}");
        }
        else
        {
            Console.WriteLine("\nOs números são DIFERENTES.");

            // Determina e exibe o maior e o menor
            if (numero1 > numero2)
            {
                Console.WriteLine($"Maior: {numero1}");
                Console.WriteLine($"Menor: {numero2}");
            }
            else
            {
                Console.WriteLine($"Maior: {numero2}");
                Console.WriteLine($"Menor: {numero1}");
            }
        }
    }
}