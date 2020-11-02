using System;
using System.Collections.Generic;
using System.Text;

namespace GamePOO
{
    public class De
    {
        private Random random = new Random();

        public int LanceLeDe() => random.Next(1, 7);
    }
}
