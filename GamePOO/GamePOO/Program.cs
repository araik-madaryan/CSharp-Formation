using System;

namespace GamePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            PremierJeu();
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
                int dePersonnage = personnage.de.LanceLeDe();
                int deMonstre = monstre.de.LanceLeDe();

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
    }
}
