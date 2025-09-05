using System;
using System.Globalization;

class CalculadoraMenu
{
    static void Main(string[] args)
    {
        // Define a cultura para garantir o uso correto de vírgulas ou pontos em números
        CultureInfo cultura = new CultureInfo("pt-BR");

        Console.WriteLine("--- Calculadora Simples ---");
        
        // 1. Solicita um número real
        Console.Write("Digite um número real: ");
        double numero = double.Parse(Console.ReadLine(), cultura);

        // 2. Exibe o menu de opções
        Console.WriteLine("\nSelecione uma opção de cálculo:");
        Console.WriteLine("101 - Raiz quadrada");
        Console.WriteLine("102 - A metade");
        Console.WriteLine("103 - 10% do número");
        Console.WriteLine("104 - O dobro");
        Console.Write("Sua opção: ");

        // 3. Lê a opção do usuário
        int opcao = int.Parse(Console.ReadLine());

        // Variável para armazenar o resultado
        double resultado;

        // 4. Usa a estrutura 'switch' para realizar o cálculo
        switch (opcao)
        {
            case 101:
                resultado = Math.Sqrt(numero);
                Console.WriteLine($"\nA raiz quadrada de {numero} é: {resultado.ToString("F2", cultura)}");
                break;

            case 102:
                resultado = numero / 2;
                Console.WriteLine($"\nA metade de {numero} é: {resultado.ToString("F2", cultura)}");
                break;

            case 103:
                resultado = numero * 0.10;
                Console.WriteLine($"\n10% de {numero} é: {resultado.ToString("F2", cultura)}");
                break;

            case 104:
                resultado = numero * 2;
                Console.WriteLine($"\nO dobro de {numero} é: {resultado.ToString("F2", cultura)}");
                break;

            default:
                Console.WriteLine("\nOpção inválida. Por favor, escolha um dos códigos do menu.");
                break;
        }
    }
}