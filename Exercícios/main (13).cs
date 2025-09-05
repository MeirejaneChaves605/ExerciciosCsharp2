using System;

class TrocaDeValores
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Troca de Valores entre Variáveis ---");
        
        // 1. Lê o valor inicial para a variável A
        Console.Write("Digite um valor para a variável A: ");
        int a = int.Parse(Console.ReadLine());

        // 2. Lê o valor inicial para a variável B
        Console.Write("Digite um valor para a variável B: ");
        int b = int.Parse(Console.ReadLine());

        // Apresenta os valores ANTES da troca
        Console.WriteLine($"\nValores ANTES da troca: A = {a} e B = {b}");

        // 3. Realiza a troca de valores usando uma variável temporária
        int temp = a;
        a = b;
        b = temp;

        // 4. Apresenta os valores DEPOIS da troca
        Console.WriteLine($"\nValores DEPOIS da troca: A = {a} e B = {b}");
    }
}