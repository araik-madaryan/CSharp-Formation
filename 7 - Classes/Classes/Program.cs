using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne unePersonne;
            unePersonne = new Personne("pap", "nicolas", 21);
            unePersonne.age = 24;
            Console.WriteLine(unePersonne.Affichage());
            Console.WriteLine(unePersonne.age); // On récupère la valeur "age".
        }
    }
}
