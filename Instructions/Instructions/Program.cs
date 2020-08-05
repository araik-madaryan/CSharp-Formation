using System;

namespace Instructions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IF
            int age = 20;
            if (age < 20)
            {
                Console.WriteLine("Vous n'avez pas l'âge requis.");
            }
            else
            {
                Console.WriteLine("Vous pouvez nous rejoindre.");
            }

            string prenom = "Araik";
            string nom = "Madaryan";
            if (prenom == "Yvon" && nom == "Fanchon" || prenom == "Araik" && nom == "Madaryan")
            {
                Console.WriteLine($"Bienvenue {prenom} {nom} !");
            }
            else
            {
                Console.WriteLine("Vous n'êtes pas autorisé à entrer.");
            }
            #endregion

            #region CASE
            string civilite = "M.";
            switch (civilite)
            {
                case "M.":
                    Console.WriteLine($"Bonjour {civilite}");
                    break;
                case "Mme.":
                    Console.WriteLine($"Bonjour {civilite}");
                    break;
                default:
                    Console.WriteLine("Civilité inconnue");
                    break;
            }
            #endregion
        }
    }
}
