using System;
using System.Globalization;

class VerificadorVestibular
{
    static void Main(string[] args)
    {
        // Define a cultura para garantir o uso correto de vírgulas ou pontos em números decimais.
        CultureInfo cultura = new CultureInfo("pt-BR");

        // a) Obter o nome e as notas do candidato.
        Console.WriteLine("--- Análise de Candidato a Vestibular ---");

        Console.Write("Digite o nome do candidato: ");
        string nomeCandidato = Console.ReadLine();

        Console.Write("Digite a nota de Português: ");
        double notaPortugues = double.Parse(Console.ReadLine(), cultura);

        Console.Write("Digite a nota de Matemática: ");
        double notaMatematica = double.Parse(Console.ReadLine(), cultura);

        Console.Write("Digite a nota de Conhecimentos Gerais: ");
        double notaConhecimentosGerais = double.Parse(Console.ReadLine(), cultura);

        // b) Calcular a média do candidato.
        double media = (notaPortugues + notaMatematica + notaConhecimentosGerais) / 3.0;

        // c) Verificar aprovação e exibir as informações.
        Console.WriteLine("\n--- Relatório do Candidato ---");
        Console.WriteLine($"Nome: {nomeCandidato}");
        Console.WriteLine($"Notas:");
        Console.WriteLine($"  - Português: {notaPortugues.ToString("F1", cultura)}");
        Console.WriteLine($"  - Matemática: {notaMatematica.ToString("F1", cultura)}");
        Console.WriteLine($"  - Conhecimentos Gerais: {notaConhecimentosGerais.ToString("F1", cultura)}");
        Console.WriteLine($"Média: {media.ToString("F2", cultura)}");

        // Lógica de aprovação
        bool aprovadoPorMedia = media > 7.0;
        bool semNotasBaixas = notaPortugues >= 5.0 && notaMatematica >= 5.0 && notaConhecimentosGerais >= 5.0;

        if (aprovadoPorMedia && semNotasBaixas)
        {
            Console.WriteLine("\nSituação: APROVADO!");
        }
        else
        {
            Console.WriteLine("\nSituação: REPROVADO.");
            if (!aprovadoPorMedia)
            {
                Console.WriteLine("Motivo: Média abaixo de 7.0.");
            }
            if (!semNotasBaixas)
            {
                Console.WriteLine("Motivo: Apresentou nota(s) abaixo de 5.0.");
            }
        }
    }
}