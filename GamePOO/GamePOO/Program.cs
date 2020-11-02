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

            if (consoleKeyInfo.Key == ConsoleKey.D1)
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
            Personnage personnage = new Personnage(150);

            int monstresFacilesTues = 0;
            int monstresDifficilesTues = 0;
            int total;

            Console.WriteLine("Presser une touche pour lancer le jeu de dés.");

            while (personnage.PointsDeVie > 0)
            {
                Console.ReadKey(true);
                Console.WriteLine(Environment.NewLine);

                MonstreFacile monstre = MonstreAleatoire();
                int dePersonnage = personnage.LanceLeDe();
                int deMonstre = monstre.LanceLeDe();

                Console.WriteLine($"Points de vie : { personnage.PointsDeVie }");
                Console.WriteLine($"Joueur : { dePersonnage } | Monstre : { deMonstre} ");

                if (dePersonnage >= deMonstre)
                {
                    if (monstre is MonstreDifficile)
                    {
                        Console.WriteLine("Un monstre plus corriace apparaît !");
                        monstresDifficilesTues++;
                    }
                    else
                    {
                        monstresFacilesTues++;
                    }
                    personnage.Attaque(monstre);
                    Console.WriteLine("Vous avez tué le monstre !");
                }
                else
                {
                    if (monstre is MonstreDifficile)
                    {
                        Console.WriteLine("Le monstre coriace vous attaque !");
                    }
                    else
                    {
                        Console.WriteLine("Le monstre vous attaque !");
                    }
                    monstre.Attaque(personnage);
                }

            }
            total = monstresFacilesTues + (monstresDifficilesTues * 2);
            Console.WriteLine("Vous êtes mort.");
            Console.WriteLine($"Bravo, vous avez tué { monstresFacilesTues } monstres faciles et { monstresDifficilesTues } monstres difficiles. Vous avez { total } points.");
        }

        private static MonstreFacile MonstreAleatoire()
        {
            MonstreFacile monstreFacile = new MonstreFacile();
            MonstreDifficile monstreDifficile = new MonstreDifficile();

            Random random = new Random();
            int randonMonster = random.Next(0, 2);

            if (randonMonster == 0)
            {
                return monstreFacile;
            }
            return monstreDifficile;
        }

        static void DeuxiemeJeu()
        {
            Personnage personnage = new Personnage(150);
            Boss boss = new Boss(250);

            Console.WriteLine("Presser une touche pour lancer le jeu de dés.");

            while (personnage.PointsDeVie > 0 && boss.EstVivant)
            {
                Console.ReadKey(true);
                Console.WriteLine(Environment.NewLine);

                personnage.Attaque(boss);
                Console.WriteLine("Vous infligez des dégâts.");

                if (boss.EstVivant)
                {
                    Console.WriteLine("Le boss vous inflige des dégâts.");
                    boss.Attaque(personnage);
                }
                Console.WriteLine($"Joueur : { personnage.PointsDeVie } pv. | Boss : { boss.PointsDeVie } pv.");
            }
            if (personnage.PointsDeVie > 0)
            {
                Console.WriteLine("Bravo, vous avez vaincu le boss !");
            }
            else
            {
                Console.WriteLine("Perdu, le boss vous a broyé avec ses muscles.");
            }
        }
    }
}
