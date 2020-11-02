using System;
using System.Collections.Generic;
using System.Text;

namespace GamePOO
{
    public class MonstreFacile
    {
        private const int Degats = 10;

        public bool EstVivant { get; private set; }

        public MonstreFacile() => EstVivant = true;

        public int LanceLeDe() => De.LanceLeDe();

        public virtual void Attaque(Personnage personnage) => personnage.SubitDegats(Degats);

        public void SubitDegats() => EstVivant = false;
    }
}
