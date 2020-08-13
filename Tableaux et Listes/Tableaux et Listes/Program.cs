using System;
using System.Collections.Generic;
using System.Linq;

namespace Tableaux_et_Listes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tableau de nombres
            int[] nombres = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // On récupère la première occurence de notre tableau.
            Console.WriteLine(nombres[0]);
            // On récupère la dernière occurence avec la méthode Count.
            Console.WriteLine(nombres[nombres.Count() - 1]);
            #endregion

            #region Tableau des jours de la semaine
            // On précise directement la longueur du tableau, puis on spécifie la valeur de chaque occurence.
            string[] jours = new string[7];
            jours[0] = "Lundi";
            jours[1] = "Mardi";
            jours[2] = "Mercredi";
            jours[3] = "Jeudi";
            jours[4] = "Vendredi";
            jours[5] = "Samedi";
            jours[6] = "Dimanche";
            Console.WriteLine(jours[4]);
            #endregion

            #region Liste de matières
            List<string> matiere = new List<string>();
            matiere.Add("Français");
            matiere.Add("Histoire");
            matiere.Add("Technologies");
            matiere.Add("EPS");
            matiere.Remove("EPS");
            Console.WriteLine(matiere[2]);
            #endregion
        }
    }
}
