 using System;
using System.Globalization;

class CalculadoraHotel
{
    static void Main(string[] args)
    {
        // Define a cultura para formatação monetária (opcional, mas boa prática)
        CultureInfo cultura = new CultureInfo("pt-BR");
        
        const double valorDiaria = 60.00;

        Console.WriteLine("--- Calculadora de Conta de Hotel ---");
        
        // 1. Obter o nome do cliente
        Console.Write("Digite o nome do cliente: ");
        string nomeCliente = Console.ReadLine();

        // 2. Obter o número de diárias
        Console.Write("Digite o número de diárias: ");
        int numeroDiarias = int.Parse(Console.ReadLine());

        double taxaServicos;

        // 3. Determinar a taxa de serviço com base nas regras
        if (numeroDiarias > 15)
        {
            taxaServicos = 5.50;
        }
        else if (numeroDiarias == 15)
        {
            taxaServicos = 6.00;
        }
        else // numeroDiarias < 15
        {
            taxaServicos = 8.00;
        }

        // 4. Calcular o total da conta
        double totalDiarias = valorDiaria * numeroDiarias;
        double totalTaxaServicos = taxaServicos * numeroDiarias;
        double totalConta = totalDiarias + totalTaxaServicos;

        // 5. Apresentar o resultado
        Console.WriteLine("\n--- Resumo da Conta ---");
        Console.WriteLine($"Cliente: {nomeCliente}");
        Console.WriteLine($"Número de Diárias: {numeroDiarias}");
        Console.WriteLine($"Taxa de Serviço por Diária: {taxaServicos.ToString("C2", cultura)}");
        Console.WriteLine($"Total da Conta: {totalConta.ToString("C2", cultura)}");
    }
}