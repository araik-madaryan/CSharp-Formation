using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PIERRE | FEUILLE | CISEAUX");
            Console.WriteLine("Ce jeu va se dérouler en 3 manches. Vous devrez saisir lors de chacune d'entre elle, un chiffre compris entre 1 et 3.");
            Console.WriteLine("Pierre (1) - Feuille (2) - Ciseaux (3)");
            Console.WriteLine(Environment.NewLine);

            string[] array = new string[] { "Pierre", "Feuille", "Ciseaux" };
            int number;
            int playerScore = 0;
            int computerScore = 0;
            int i = 1;

            while (i <= 3)
            {
                int random = new Random().Next(0, 3);
                string saisie = Console.ReadLine();

                if (Int32.TryParse(saisie, out number) && number <= 3 && number > 0)
                {
                    Console.WriteLine($"Manche n° { i }.");
                    if (number == 1 && random == 2 || number == 2 && random == 1 || number == 3 && random == 2)
                    {
                        Console.WriteLine($"Vous avez choisi { array[number - 1] } contre { array[random] } - Gagné");
                        playerScore++;
                    }
                    else
                    {
                        Console.WriteLine($"Vous avez choisi { array[number - 1] } contre { array[random] } - Perdu");
                        computerScore++;
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine("Saisie incorrect : veuillez saisir un chiffre compris entre 1 et 3.");
                }
            }

            Console.WriteLine(Environment.NewLine);

            if (playerScore > computerScore)
            {
                Console.WriteLine($"Bravo, vous avez gagné - { playerScore } (vous) contre { computerScore } (ordinateur).");
            }
            else
            {
                Console.WriteLine($"Dommage, vous avez perdu - { playerScore } (vous) contre { computerScore } (ordinateur).");
            }
        }
    }
}
