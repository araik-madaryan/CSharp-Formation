using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePOO
{
    static class De
    {
        static Random random = new Random();

        static public int LanceLeDe() => random.Next(1, 7);

        static public int LanceLeDe(int valeur) => random.Next(1, valeur);
    }
}
