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
            int deMonstreDifficle = LanceLeDe();
            if (deMonstreDifficle != 6)
            {
                Console.WriteLine("Le monstre coriace lance une attaque magique !");
                Console.WriteLine(deMonstreDifficle * attaqueMagique);

                return deMonstreDifficle * attaqueMagique;
            }
            return 0;
        }
    }
}
