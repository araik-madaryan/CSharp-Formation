using System;
using System.Collections.Generic;

namespace Dictionnaires
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Déclaration d'un dictionnaire avec des nombres.
            Dictionary<int, string> nombres = new Dictionary<int, string>()
            {
                { 1, "un" },
                { 2, "deux" },
                { 3, "trois" }
            };

            nombres.Add(4, "quatre");

            foreach(KeyValuePair<int, string> element in nombres)
            {
                Console.WriteLine($"{element.Key} - {element.Value}");
            }
            #endregion

            Console.WriteLine("\n----------\n");

            #region Déclaration d'un dictionnaire avec des textes.
            Dictionary<string, string> auteurs = new Dictionary<string, string>()
            {
                { "Annie et Jean-Pierre Mahé", "Histoire de l'Arménie des origines à nos jours" },
                { "Joasiah Ober", "L'énigme grecque" },
                { "Hélène Montardre", "La mythologie grecque" }
            };

            foreach (KeyValuePair<string, string> element in auteurs)
            {
                Console.WriteLine($"{element.Key} - {element.Value}");
            }
            #endregion
        }
    }
}
