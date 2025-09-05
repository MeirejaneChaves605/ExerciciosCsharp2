 using System;

class ClassificadorAtleta
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Classificação de Atletas por Idade ---");
        
        // 1. Solicita o nome do atleta
        Console.Write("Digite o nome do atleta: ");
        string nomeAtleta = Console.ReadLine();

        // 2. Solicita a idade do atleta
        Console.Write("Digite a idade do atleta: ");
        int idade = int.Parse(Console.ReadLine());

        string categoria;

        // 3. Usa a estrutura condicional para determinar a categoria
        if (idade >= 5 && idade <= 10)
        {
            categoria = "Infantil";
        }
        else if (idade >= 11 && idade <= 15)
        {
            categoria = "Juvenil";
        }
        else if (idade >= 16 && idade <= 20)
        {
            categoria = "Junior";
        }
        else if (idade >= 21 && idade <= 25)
        {
            categoria = "Profissional";
        }
        else
        {
            // Categoria para idades fora das faixas especificadas
            categoria = "Idade não classificada";
        }

        // 4. Imprime o resultado
        Console.WriteLine("\n--- Dados do Atleta ---");
        Console.WriteLine($"Nome: {nomeAtleta}");
        Console.WriteLine($"Idade: {idade} anos");
        Console.WriteLine($"Categoria: {categoria}");
    }
}