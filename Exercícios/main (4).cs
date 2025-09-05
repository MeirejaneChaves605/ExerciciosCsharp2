using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Usa a cultura para lidar com vírgula ou ponto em números decimais
        CultureInfo cultura = new CultureInfo("pt-BR");

        // Lê o nome do aluno
        Console.Write("Digite o nome do aluno: ");
        string nomeAluno = Console.ReadLine();

        // Lê a nota da primeira prova
        Console.Write("Digite a nota da primeira prova: ");
        double nota1 = double.Parse(Console.ReadLine(), cultura);

        // Lê a nota da segunda prova
        Console.Write("Digite a nota da segunda prova: ");
        double nota2 = double.Parse(Console.ReadLine(), cultura);

        // Lê a nota da terceira prova
        Console.Write("Digite a nota da terceira prova: ");
        double nota3 = double.Parse(Console.ReadLine(), cultura);

        // Calcula a média aritmética
        double media = (nota1 + nota2 + nota3) / 3.0;

        // Exibe o nome do aluno e a sua média
        Console.WriteLine("\n--- Resultado ---");
        Console.WriteLine($"Nome do Aluno: {nomeAluno}");
        Console.WriteLine($"Média Final: {media.ToString("F2", cultura)}");
    }
}