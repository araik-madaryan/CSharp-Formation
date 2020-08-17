using System;
using System.Collections.Generic;

namespace Boucles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> joursListe = new List<string> { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            string[] joursTableau = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };

            #region Boucle for
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Nous sommes le jour {i}.");
            }
            // On boucle sur une liste
            for (int i = 0; i < joursListe.Count; i++)
            {
                Console.WriteLine($"Nous sommes {joursListe[i]}.");
            }
            // On boucle sur un tableau
            for (int i = 0; i < joursTableau.Length; i++)
            {
                Console.WriteLine($"Nous sommes {joursListe[i]}.");
            }
            #endregion

            #region Boucle foreach
            foreach (string jour in joursListe)
            {
                Console.WriteLine($"{jour} a {jour.Length} lettres.");
            }
            #endregion

            #region Boucle while
            Console.WriteLine("Appuyez sur la touche \"A\"");
            while (Console.ReadKey(true).Key != ConsoleKey.A)
            {
                Console.WriteLine("Appuyez sur la touche \"A\"");
            }
            Console.WriteLine("Vous avez appuyé sur la touche \"A\"");
            Console.ReadKey(true);
            #endregion
        }
    }
}
