using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePOO
{
    public class MonstreDifficile : MonstreFacile
    {
        private const int degats = 5;

        public override void Attaque(Joueur joueur)
        {
            Console.WriteLine("Un monstre difficile apparaît.");
            base.Attaque(joueur);
            joueur.SubitDegats(AttaqueMagique());
        }

        private int AttaqueMagique()
        {
            int valeur = De.LanceLeDe();
            if (valeur != 6)
            {
                Console.WriteLine("Le monstre vous lance une attaque magique !");
                return valeur * degats;
            }
            return 0;
        }
    }
}
