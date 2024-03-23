using System;

namespace PalavraSecreta
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Informe a palavra secreta: ");
            string palavraSecreta = Console.ReadLine();
            Console.WriteLine("Informe a descricção da palavra secreta: ");
            string descricao = Console.ReadLine();
            Console.Clear();

            Palavra Palavra = new Palavra(palavraSecreta, descricao);
            Console.WriteLine(Palavra);

            




            Palavra.AdivinheAPalavraSecreta();
        }

    }
}
