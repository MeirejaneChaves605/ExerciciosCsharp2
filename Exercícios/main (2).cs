using System;

class Program
{
    static void Main(string[] args)
    {
        // a) Leia o nome
        Console.WriteLine("Digite o seu nome:");
        string nome = Console.ReadLine();

        // b) Leia o sobrenome
        Console.WriteLine("Digite o seu sobrenome:");
        string sobrenome = Console.ReadLine();

        // c) Concatene o nome com o sobrenome
        string nomeCompleto = nome + " " + sobrenome;

        // d) Apresente o nome completo
        Console.WriteLine("\nNome completo: " + nomeCompleto);
    }
}