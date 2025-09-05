using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Define a cultura para garantir que o programa lide com vírgulas e pontos em números
        CultureInfo cultura = new CultureInfo("pt-BR");

        // a) Obtém o valor para a variável HT (Horas Trabalhadas)
        Console.Write("Digite o número de horas trabalhadas no mês: ");
        double horasTrabalhadas = double.Parse(Console.ReadLine(), cultura);

        // b) Obtém o valor para a variável VH (Valor Hora)
        Console.Write("Digite o valor da hora trabalhada: ");
        double valorHora = double.Parse(Console.ReadLine(), cultura);

        // c) Obtém o valor para a variável PD (Percentual de Desconto)
        Console.Write("Digite o percentual de desconto (ex: 15 para 15%): ");
        double percentualDesconto = double.Parse(Console.ReadLine(), cultura);

        // d) Calcula o Salário Bruto (SB)
        double salarioBruto = horasTrabalhadas * valorHora;

        // e) Calcula o Total de Desconto (TD)
        double totalDesconto = (percentualDesconto / 100) * salarioBruto;

        // f) Calcula o Salário Líquido (SL)
        double salarioLiquido = salarioBruto - totalDesconto;

        // g) Apresenta os valores
        Console.WriteLine("\n--- Resumo Salarial ---");
        Console.WriteLine($"Horas Trabalhadas: {horasTrabalhadas.ToString("F2", cultura)}");
        Console.WriteLine($"Salário Bruto: {salarioBruto.ToString("C2", cultura)}");
        Console.WriteLine($"Desconto ({percentualDesconto}%): {totalDesconto.ToString("C2", cultura)}");
        Console.WriteLine($"Salário Líquido: {salarioLiquido.ToString("C2", cultura)}");
    }
}

        