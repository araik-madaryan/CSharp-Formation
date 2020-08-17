using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Personne
    {
        private string nom;
        private string prenom;
        public int age { get; set; } // Accesseurs (getters) et mutateurs (setters).
        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom.ToUpper();
            this.prenom = prenom[0].ToString().ToUpper() + prenom.Substring(1, prenom.Length - 1);
            this.age = age;
        }

        public string Affichage()
        {
            return $"{prenom} {nom} a {age} ans.";
        }
    }
}
