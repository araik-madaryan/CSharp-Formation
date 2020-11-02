using System;
using System.Collections.Generic;
using System.Text;

namespace GamePOO
{
    public class Personnage
    {
        public int PointsDeVie { get; private set; }

        public Personnage(int pointsDeVie) => PointsDeVie = pointsDeVie;

        public int LanceLeDe() => De.LanceLeDe();

        public int LanceLeDe(int valeur) => De.LanceLeDe(valeur);

        public void Attaque(MonstreFacile monstre) => monstre.SubitDegats();

        public void Attaque(Boss boss) => boss.SubitDegats(LanceLeDe(26));


        public int SubitDegats(int degats)
        {
            if (!Bouclier())
            {
                return PointsDeVie = PointsDeVie - degats;
            }
            return 0;
        }

        private bool Bouclier()
        {
            int deBouclier = LanceLeDe();
            if (deBouclier <= 2)
            {
                Console.WriteLine("Votre bouclier vous a protégé.");
                return true;
            }
            return false;
        }
    }
}
