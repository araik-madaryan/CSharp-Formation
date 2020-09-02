using System;
using System.Collections.Generic;

namespace LoopsAndCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            SommeEntiers(1, 10); // Output : 55;
            SommeEntiers(1, 100); // Output : 5050

            List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6 };
            MoyenneListe(liste); // Output : 5.76

            List<int> listeDesMultiplesDeTrois = new List<int>();
            List<int> listeDesMultiplesDeCinq = new List<int>();

            Multiples(listeDesMultiplesDeTrois, listeDesMultiplesDeCinq); // Récupère les multiples de 3 et 5, puis les ajoute dans leurs tableaux respectifs
            SommeDesMultiplesCommuns(listeDesMultiplesDeTrois, listeDesMultiplesDeCinq); // Output : 630

        }
        #region Calcul de la somme des entiers
        static int SommeEntiers(int debut, int fin)
        {
            int somme = 0;
            for (int nombre = debut; nombre <= fin; nombre++)
            {
                somme += nombre;
            }
            return somme; 
        }
        #endregion

        #region Calcul de la moyenne d'une liste
        static double MoyenneListe(List<double> liste)
        {
            double somme = 0;
            for (int nombre = 0; nombre < liste.Count; nombre++)
            {
                somme += liste[nombre];
            }
            return somme / liste.Count;
        }
        #endregion

        #region Calcul de multiples
        static void Multiples(List<int> listeDesMultiplesDeTrois, List<int> listeDesMultiplesDeCinq)
        {
            for (int nombre = 0; nombre <= 100; nombre++)
            {
                if (nombre % 3 == 0)
                {
                    listeDesMultiplesDeTrois.Add(nombre);
                }
                if (nombre % 5 == 0)
                {
                    listeDesMultiplesDeCinq.Add(nombre);
                }
            }
        }

        static int SommeDesMultiplesCommuns(List<int> listeDesMultiplesDeTrois, List<int> listeDesMultiplesDeCinq)
        {
            int somme = 0;
            for (int i = 0; i < listeDesMultiplesDeTrois.Count; i++)
            {
                for (int f = 0; f < listeDesMultiplesDeCinq.Count; f++)
                {
                    if (listeDesMultiplesDeTrois[i] == listeDesMultiplesDeCinq[f])
                    {
                        somme += listeDesMultiplesDeTrois[i] + listeDesMultiplesDeCinq[f];
                    }
                }
            }
            return somme;
        }
        #endregion
    }
}
