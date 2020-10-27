using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionComplexe
{
    class Piscine
    {
        public String Couleur { get; set; }

        public String Revetement { get; set; }
        public int Prix { get; set; }
        public DateTime ConstructionDate { get; set; }
        public int Taille { get; set; }

        public Piscine()
        {

        }
        public Piscine(string couleur, string revetement, int prix, int taille, DateTime construction)
        {
            this.Couleur = couleur;
            this.Revetement = revetement;
            this.Prix = prix;
            this.Taille = taille;
            this.ConstructionDate = construction;
        }
    }
}
