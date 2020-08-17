using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region STRING
            string helloWorld = "Hello World !";
            // Affiche la chaîne Hello World !
            Console.WriteLine(helloWorld);

            #region L'utilité des slash ("\") dans une chaîne de caractères.
            string slash = "Les Hommes ne sont pas tous des \"hommes\" !";
            // Le slash (« \ ») permet d’ignorer des guillemets dans une chaîne de caractères.
            Console.WriteLine(slash);

            string slashN = "Ligne 1\nLigne 2\nLigne 3";
            // Le slash n (« \n ») permet de sauter une ligne dans chaîne de caractères.
            Console.WriteLine(slashN);

            string slashT = "List:\n\t - Element 1\n\t - Element 2";
            // Le slash t (« \t ») permet de faire une tabulation dans une chaîne de caractères.
            Console.WriteLine(slashT);
            #endregion
            #endregion

            #region INT
            int annee = 1998;
            // Affiche l'année 1998.
            Console.WriteLine(annee);

            int note = 20;
            int moyenne;
            moyenne = (note + 15) / 2;
            // Affiche 17.
            Console.WriteLine(moyenne);

            #region Incrémentation et décrémentation
            int monAge = 21;
            Console.WriteLine($"J'ai {monAge} ans.");

            monAge = monAge + 1;
            // Ou bien, pour réaliser une soustraction :  monAge = monAge - 1
            Console.WriteLine($"J'ai {monAge} ans.");

            monAge += 1;
            // Ou bien, pour réaliser une soustraction : monAge -= 1;
            Console.WriteLine($"J'ai {monAge} ans.");

            monAge++;
            // Ou bien, pour réaliser une soustraction : monAge--
            Console.WriteLine($"J'ai {monAge} ans.");
            #endregion
            #endregion

            #region BOOL
            // Ces variables sont davantage utilisées dans les conditions.

            bool isTrue = true;
            // Affiche true.
            Console.WriteLine(isTrue);

            bool isFalse = false;
            // Affiche false.
            Console.WriteLine(isFalse);
            #endregion
        }
    }
}
