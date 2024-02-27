using System;

namespace PalavraSecreta
{
    class Program
    {
        static void Main(string[] args)
        {
            Palavra Palavra = new Palavra();

            Console.WriteLine("Informe a palavra secreta: ");
            Palavra.PalavraSecreta = Console.ReadLine();
            Console.WriteLine("Informe a descricção da palavra secreta: ");
            Palavra.Descricao = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"A descrição da palavra secreta é: {Palavra.Descricao }");




            Palavra.AdivinheAPalavraSecreta();
        }

    }
}
