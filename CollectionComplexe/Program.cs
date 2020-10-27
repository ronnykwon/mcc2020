using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CollectionComplexe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Rotopol!");
            Piscine laPiscineDeRonny = new Piscine("Rose", "Bois", 750000, 60, DateTime.Now);
            


            Console.WriteLine("La piscine de Ronny est " + laPiscineDeRonny.Couleur);

            Piscine laPiscineDeToto = new Piscine("Rouge", "carton", 500, 4, DateTime.Now);
            Console.WriteLine("la piscine de toto est : " + laPiscineDeToto.Couleur);


            List<Piscine> piscines = new List<Piscine>();
            piscines.Add(laPiscineDeToto);
            piscines.Add(laPiscineDeRonny);

        }
    }




    public class Person
    {
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public int Age { get; set; }
        public DateTime DateNaissance { get; set; }

        public Person(string nom, string prenom, DateTime datenaissance)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = datenaissance;
            this.Age = DateTime.Now.AddYears(-datenaissance.Year).Year;
        }

        public void SePresenter()
        {
            Console.WriteLine("Bonjour je m'appelle {0} {1}, j'ai {2} ans, je suis né(e) le {3}", this.Prenom, this.Nom, this.Age, this.DateNaissance.ToString("dd/MM/yyyy"));

        }
    }
}
