using System;
using System.Collections.Generic;
using System.Text;

namespace GamePOO
{
    public static class De
    {
        private static Random random = new Random();

        public static int LanceLeDe() => random.Next(1, 7);

        public static int LanceLeDe(int valeur) => random.Next(1, valeur);
    }
}
