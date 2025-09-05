using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicita ao usuário para inserir um número
        Console.Write("Digite um número: ");

        // Lê a entrada do usuário e converte para um número inteiro
        int numero = int.Parse(Console.ReadLine());

        // Usa a estrutura 'if' para verificar se o número é maior que 10
        if (numero > 10)
        {
            // Se a condição for verdadeira, exibe a mensagem
            Console.WriteLine("O número digitado é maior que 10!");
        }
        else
        {
            // Opcional: Para qualquer outro caso (se o número for 10 ou menor)
            Console.WriteLine("O número digitado não é maior que 10.");
        }
    }
}