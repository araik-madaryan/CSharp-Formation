using System;

namespace DaysAndHours
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Date = DateTime.Now;

            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday) // SI le jour est égal à samedi OU dimanche
            {
                Weekend(); // AFFICHER bon week-end.
            }
            else if ((Date.Hour >= 18 && Date.DayOfWeek == DayOfWeek.Friday) || (Date.Hour < 9 && Date.DayOfWeek == DayOfWeek.Monday)) // SINON SI le jour est égal à vendredi à partir de 18H+ OU le jour est égal à lundi à moins de 9H
            {
                Weekend(); // AFFICHER bon week-end.
            }
            else if (Date.Hour >= 9 && Date.Hour < 18) // SINON SI l'heure est inclu entre 9H ET 18H
            {
                Bonjour(); // AFFICHER bonjour.
            }
            else // SINON
            {
                Bonsoir(); // AFFICHER bonsoir.
            }
        }

        static void Bonjour() => Console.WriteLine($"Bonjour { Environment.UserName } !");
        static void Bonsoir() => Console.WriteLine($"Bonsoir { Environment.UserName } !");
        static void Weekend() => Console.WriteLine($"Bon week-end { Environment.UserName } !");
    }
}
