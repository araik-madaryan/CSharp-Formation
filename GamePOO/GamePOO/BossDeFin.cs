using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePOO
{
    public class BossDeFin
    {
        public int PointsDeVie { get; private set; }

        public bool EstVivant { get => (PointsDeVie > 0); }

        public BossDeFin() => PointsDeVie = 250;

        public int Attaque(Joueur joueur) => joueur.SubitDegats(De.LanceLeDe(26));

        public int SubitDegats(int degats) => PointsDeVie -= degats;
    }
}
