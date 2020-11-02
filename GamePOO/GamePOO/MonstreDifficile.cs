using System;
using System.Collections.Generic;
using System.Text;

namespace GamePOO
{
    public class MonstreDifficile : MonstreFacile
    {
        private int attaqueMagique = 5;

        public override void Attaque(Personnage personnage) {
            base.Attaque(personnage);
            personnage.SubitDegats(AttaqueMagique());
        }

        public int AttaqueMagique()
        {
            int deMonstreDifficle = de.LanceLeDe();
            if (deMonstreDifficle != 6)
            {
                Console.WriteLine("Le monstre coriace lance une attaque magique !");
                return deMonstreDifficle * attaqueMagique;
            }
            return 0;
        }
    }
}
