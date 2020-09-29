using System;

namespace MoreOrLess
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombreAleatoire = new Random().Next(0, 101);
            int tentative = 1;

            Console.WriteLine(nombreAleatoire);

            string titre = "|-- Le jeu du plus ou moins --|";
            Console.SetCursorPosition((Console.WindowWidth - titre.Length) / 2, Console.CursorTop);
            Console.WriteLine(titre.ToUpper() + Environment.NewLine);
            Console.WriteLine("Veuillez saisir un nombre compris entre 0 et 100, puis valider avec la touche entrée :");

            int nombreSaisie;
            bool nombreTrouve = false;

            while (!nombreTrouve)
            {
                string saisie = Console.ReadLine();

                if (int.TryParse(saisie, out nombreSaisie))
                {
                    if (nombreSaisie == nombreAleatoire)
                    {
                        nombreTrouve = true;
                        if (tentative > 1)
                        {
                            Console.WriteLine($"Bravo, vous avez trouvé le juste nombre avec { tentative } tentatives.");
                        }
                        else
                        {
                            Console.WriteLine($"Bravo, vous avez trouvé le juste nombre avec { tentative } tentative.");
                        }
                    }
                    else
                    {
                        if (nombreSaisie < 0 || nombreSaisie > 100)
                        {
                            Console.WriteLine("Votre valeur doit être comprise entre 0 et 100.");
                        }
                        else if (nombreSaisie < nombreAleatoire)
                        {
                            Console.WriteLine("C'est plus.");
                        }
                        else
                        {
                            Console.WriteLine("C'est moins.");
                        }
                        tentative += 1;
                    }
                }
                else
                {
                    Console.WriteLine("Votre saisie semble incorrect. Réessayez.");
                }
            }
        }
    }
}
