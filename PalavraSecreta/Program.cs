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
            string descrição = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"A descrição da palavra secreta é: {descrição }");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nTentativa " +   (i+1) + " Informe a palavra  secreta:");
                string tentativa = (Console.ReadLine().ToLower());

                if (tentativa == palavraSecreta)
                {
                    Console.WriteLine("Parabéns, Você acertou a palavra secreta");
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine("Suas tentativas terminaram, o jogo acabou!");
                }
                else
                {
                    Console.WriteLine("Você errou, tente novamente!");
                }

            }

        } 
    }
}
