using System;
using System.Collections.Generic;
using System.Text;

namespace PalavraSecreta
{
    class Palavra
    {
        public string PalavraSecreta;
        public string Descricao;

        public void AdivinheAPalavraSecreta()

        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\nTentativa " + (i + 1) + " Informe a palavra  secreta:");
                string tentativa = (Console.ReadLine().ToLower());

                if (tentativa == PalavraSecreta.ToLower())
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

        
