using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Define a cultura para garantir que o programa lide com vírgulas e pontos em números
        CultureInfo cultura = new CultureInfo("pt-BR");

        // Solicita ao usuário que insira a temperatura em Celsius
        Console.Write("Digite a temperatura em graus Celsius: ");

        // Lê a entrada do usuário e converte para um número decimal (double)
        double celsius = double.Parse(Console.ReadLine(), cultura);

        // Aplica a fórmula de conversão: F = (9 * C + 160) / 5
        double fahrenheit = (9 * celsius + 160) / 5;

        // Apresenta o resultado formatado
        Console.WriteLine("\n--- Conversão de Temperatura ---");
        Console.WriteLine($"{celsius.ToString("F2", cultura)}°C equivalem a {fahrenheit.ToString("F2", cultura)}°F.");
    }
}