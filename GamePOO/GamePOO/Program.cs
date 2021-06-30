using System;

namespace GamePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            AfficheMenu();
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);

            while (consoleKeyInfo.Key != ConsoleKey.D1 && consoleKeyInfo.Key != ConsoleKey.D2 && consoleKeyInfo.Key != ConsoleKey.NumPad1 && consoleKeyInfo.Key != ConsoleKey.NumPad2)
            {
                AfficheMenu();
                consoleKeyInfo = Console.ReadKey(true);
            }

            if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
            {
                PremierJeu();
            }
            else
            {
                DeuxiemeJeu();
            }
        }

        private static void AfficheMenu()
        {
            Console.Clear();
            Console.WriteLine("Veuillez choisir votre mode de jeu :");
            Console.WriteLine("\t1 : Contre les monstres");
            Console.WriteLine("\t2 : Contre le boss");
        }

        static void PremierJeu()
        {
            Joueur joueur = new Joueur();
            int monstresFacilesTues = 0;
            int monstresDifficilesTues = 0;

            while (joueur.EstVivant)
            {
                MonstreFacile monstre = MonstreAleatoire();
                int joueurLanceLeDe = De.LanceLeDe();
                int monstreLanceLeDe = De.LanceLeDe();

                Console.WriteLine("Presser une touche pour lancer le jeu de dés.");
                Console.ReadKey(true);
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine($"Joueur : { joueurLanceLeDe } | Monstre : { monstreLanceLeDe} ");

                if (joueurLanceLeDe >= monstreLanceLeDe)
                {
                    joueur.Attaque(monstre);
                    if (monstre is MonstreDifficile)
                    {
                        monstresFacilesTues++;
                    }
                    else
                    {
                        monstresDifficilesTues++;
                    }
                }
                else
                {
                    monstre.Attaque(joueur);
                    Console.WriteLine($"Il vous reste { joueur.PointsDeVie } points de vie.");
                }
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Vous avez tué { monstresFacilesTues } monstres faciles et { monstresDifficilesTues } monstres difficiles.");
            Console.WriteLine($"Votre score est de { monstresFacilesTues + (monstresDifficilesTues * 2) }.");
        }

        static void DeuxiemeJeu()
        {
            Joueur joueur = new Joueur();
            BossDeFin boss = new BossDeFin();

            while (joueur.EstVivant && boss.EstVivant)
            {
                Console.WriteLine("Presser une touche pour lancer le jeu de dés.");
                Console.ReadKey(true);
                Console.WriteLine(Environment.NewLine);

                joueur.AttaqueBoss(boss);
                Console.WriteLine($"Il reste { boss.PointsDeVie } points de vie au boss.");
                boss.Attaque(joueur);
                Console.WriteLine($"Il vous reste { joueur.PointsDeVie } points de vie.");
            }
            if (joueur.EstVivant)
            {
                Console.WriteLine("Bravo, vous avez tué le boss !");
            }
            else
            {
                Console.WriteLine("Dommage, vous avez perdu.");
            }
        }

        static MonstreFacile MonstreAleatoire()
        {
            if (De.LanceLeDe(3) == 1)
            {
                return new MonstreFacile();
            }
            return new MonstreDifficile();
        }
    }
}
