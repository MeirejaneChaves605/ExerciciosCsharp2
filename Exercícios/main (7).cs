using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Define a cultura para garantir a correta leitura de números com vírgula ou ponto.
        CultureInfo cultura = new CultureInfo("pt-BR");

        // Solicita o tempo gasto na viagem.
        Console.Write("Digite o tempo gasto na viagem (em horas): ");
        double tempoGasto = double.Parse(Console.ReadLine(), cultura);

        // Solicita a velocidade média da viagem.
        Console.Write("Digite a velocidade média durante a viagem (em Km/h): ");
        double velocidadeMedia = double.Parse(Console.ReadLine(), cultura);

        // Calcula a distância percorrida.
        double distancia = tempoGasto * velocidadeMedia;

        // Calcula a quantidade de litros de combustível, considerando 12 Km/litro.
        const int consumoPorLitro = 12; // Valor constante para o consumo do carro.
        double litrosUsados = distancia / consumoPorLitro;

        // Apresenta todos os resultados.
        Console.WriteLine("\n--- Resumo da Viagem ---");
        Console.WriteLine($"Velocidade Média: {velocidadeMedia.ToString("F2", cultura)} Km/h");
        Console.WriteLine($"Tempo Gasto: {tempoGasto.ToString("F2", cultura)} horas");
        Console.WriteLine($"Distância Percorrida: {distancia.ToString("F2", cultura)} Km");
        Console.WriteLine($"Litros de Combustível Utilizados: {litrosUsados.ToString("F2", cultura)} litros");
    }
}