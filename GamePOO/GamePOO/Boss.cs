using System;
using System.Collections.Generic;
using System.Text;

namespace GamePOO
{
    public class Boss
    {
        public int PointsDeVie { get; private set; }

        public bool EstVivant { 
            get { 
                return PointsDeVie > 0; 
            } 
        }

        public Boss(int pointsDeVie) => PointsDeVie = pointsDeVie;

        public int LanceLeDe(int lance) => De.LanceLeDe(lance);

        public int Attaque(Personnage personnage) => personnage.SubitDegats(LanceLeDe(26));

        public void SubitDegats(int degats) => PointsDeVie -= degats;
    }
}
