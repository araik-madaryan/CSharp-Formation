using System;
using System.Collections.Generic;
using System.Text;

namespace GamePOO
{
    public class Personnage
    {
        public De de = new De();

        public int PointsDeVie { get; private set; }

        public Personnage(int pointsDeVie) => PointsDeVie = pointsDeVie;

        public void Attaque(MonstreFacile monstre) => monstre.SubitDegats();

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
            int deBouclier = de.LanceLeDe();
            if (deBouclier <= 2)
            {
                Console.WriteLine("Votre bouclier vous a protégé.");
                return true;
            }
            return false;
        }
    }
}
