using System;

class VerificadorDeFaixa
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");

        // Lê a entrada do usuário e converte para um número inteiro
        int n = int.Parse(Console.ReadLine());

        // Verifica as condições e imprime a string correspondente
        if (n <= 10)
        {
            Console.WriteLine("F1");
        }
        else if (n > 10 && n <= 100)
        {
            Console.WriteLine("F2");
        }
        else // n > 100
        {
            Console.WriteLine("F3");
        }
    }
}