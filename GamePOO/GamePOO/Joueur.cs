using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePOO
{
    public class Joueur
    {
        public int PointsDeVie { get; private set; }

        public bool EstVivant { get => (PointsDeVie > 0); }

        public Joueur() => PointsDeVie = 150;

        public void Attaque(MonstreFacile monstre) {
            Console.WriteLine("Vous avez tué le monstre !");
            monstre.SubitDegats();
        }
        
        public void AttaqueBoss(BossDeFin boss) => boss.SubitDegats(De.LanceLeDe(26));

        public int SubitDegats(int degats)
        {
            if (De.LanceLeDe() <= 2)
            {
                Console.WriteLine("Votre bouclier vous a protégé.");
                return PointsDeVie;
            }
            Console.WriteLine("Vous vous faîtes attaquer !");
            return PointsDeVie -= degats;
        }
    }
}
