using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePOO
{
    public class MonstreFacile
    {
        private const int degats = 10;

        public bool EstVivant { get; private set; }

        public MonstreFacile() => EstVivant = true;

        public virtual void Attaque(Joueur joueur) => joueur.SubitDegats(degats);

        public bool SubitDegats() => !EstVivant;
    }
}
