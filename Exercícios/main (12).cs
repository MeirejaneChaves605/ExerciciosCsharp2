using System;

class VerificadorDeIntervalo
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");

        // Lê a entrada do usuário e converte para um número inteiro
        int numero = int.Parse(Console.ReadLine());

        // Verifica se o número está no intervalo entre 100 e 200
        if (numero >= 100 && numero <= 200)
        {
            Console.WriteLine($"O número {numero} está no intervalo entre 100 e 200.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO está no intervalo entre 100 e 200.");
        }
    }
}