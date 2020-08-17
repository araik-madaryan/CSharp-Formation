using System;

namespace Fonctions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Méthode
            direBonjour("femme");
            direBonjourPlusieursFois("homme");
            // Le mot-clé void signifie vide, que le retour ou return va être vide.
            void direBonjour(string sexe)
            {
                Console.WriteLine($"Bonjour jeune {sexe} !");
            }

            void direBonjourPlusieursFois(string sexe)
            {
                direBonjour(sexe);
                direBonjour(sexe);
                direBonjour(sexe);
                direBonjour(sexe);
            }
            #endregion

            #region Fonction
            Console.WriteLine(AireRectangleInt(4, 8));
            // Utilisation du type int pour déclarer la fonction.
            int AireRectangleInt(int longueur, int largeur)
            {
                int aire = longueur * largeur;
                return aire;
            }

            Console.WriteLine(AireRectangleStr(2, 7));
            // Utilisation du type string pour déclarer la fonction.
            string AireRectangleStr(int longueur, int largeur) => $"L'aire du rectangle est { longueur * largeur }";
            #endregion 
        }
    }
}
