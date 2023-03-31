using System;

namespace JogoAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int tentativas = 0;
            int palpite = 0;
            bool acertou = false;

            Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
            Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

            while (!acertou && tentativas < 10)
            {
                Console.Write("Digite o seu palpite: ");
                palpite = int.Parse(Console.ReadLine());
                tentativas++;

                if (palpite == numeroSecreto)
                {
                    acertou = true;
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior que o seu palpite.");
                }
                else
                {
                    Console.WriteLine("O número secreto é menor que o seu palpite.");
                }
            }

            if (acertou)
            {
                Console.WriteLine("Parabéns! Você acertou em " + tentativas + " tentativas.");
            }
            else
            {
                Console.WriteLine("Você não conseguiu adivinhar o número secreto. O número era: " + numeroSecreto);
            }

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
