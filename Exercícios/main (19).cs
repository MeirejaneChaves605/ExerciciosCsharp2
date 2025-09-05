 using System;
using System.Globalization;

class CalculadoraMediaAluno
{
    static void Main(string[] args)
    {
        // Define a cultura para garantir o uso correto de vírgulas ou pontos em números decimais.
        CultureInfo cultura = new CultureInfo("pt-BR");

        Console.WriteLine("--- Calculadora de Média do Aluno ---");

        // 1. Lê as três notas
        Console.Write("Digite a nota da primeira prova: ");
        double nota1 = double.Parse(Console.ReadLine(), cultura);

        Console.Write("Digite a nota da segunda prova: ");
        double nota2 = double.Parse(Console.ReadLine(), cultura);

        Console.Write("Digite a nota da terceira prova: ");
        double nota3 = double.Parse(Console.ReadLine(), cultura);

        // 2. Calcula a média aritmética
        double media = (nota1 + nota2 + nota3) / 3.0;

        // 3. Exibe a média e a situação do aluno
        Console.WriteLine($"\nMédia do aluno: {media.ToString("F2", cultura)}");

        if (media >= 7.0)
        {
            Console.WriteLine("Situação: Aprovado");
        }
        else if (media >= 4.0)
        {
            Console.WriteLine("Situação: Em prova final");
        }
        else // media < 4.0
        {
            Console.WriteLine("Situação: Reprovado");
        }
    }
}