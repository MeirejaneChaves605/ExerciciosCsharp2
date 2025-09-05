using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Define a cultura para usar ponto ou vírgula corretamente em números
        CultureInfo cultura = new CultureInfo("pt-BR");

        // a) Lê o nome do vendedor
        Console.Write("Digite o nome do vendedor: ");
        string nomeVendedor = Console.ReadLine();

        // b) Lê o salário fixo
        Console.Write("Digite o salário fixo: ");
        double salarioFixo = double.Parse(Console.ReadLine(), cultura);

        // c) Lê o total de vendas
        Console.Write("Digite o total de vendas (em dinheiro): ");
        double totalVendas = double.Parse(Console.ReadLine(), cultura);

        // d) Calcula a comissão (15% sobre as vendas)
        double comissao = totalVendas * 0.15;
        double salarioTotal = salarioFixo + comissao;

        // e) Informa os dados do vendedor e seu salário final
        Console.WriteLine("\n--- Relatório de Salário ---");
        Console.WriteLine($"Nome do Vendedor: {nomeVendedor}");
        Console.WriteLine($"Salário Fixo: {salarioFixo.ToString("C2", cultura)}");
        Console.WriteLine($"Total de Vendas: {totalVendas.ToString("C2", cultura)}");
        Console.WriteLine($"Salário Final (com comissão): {salarioTotal.ToString("C2", cultura)}");
    }
}