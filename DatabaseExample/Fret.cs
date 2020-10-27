using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseExample
{
    public class Fret
    {
        /**
         * Le nom de la personne enregistrant le fret
         */
        public string Name { get; set; }
        /**
         * Date d'enregistrement du Fret
         */
        public DateTime RegisterDate { get; set; }
        /**
         * Nombre de paquet associé a ce fret
         */
        public int NombrePaquet { get; set; }
        /**
         * Volume de ce fret
         */
        public int Volume { get; set; }
        /**
         * Le Total Hors Taxe de la ligne de Fret
         */
        public int TotalHT { get; set; }
        /**
         * Le status de la ligne de fret
         * 0 : Non Payée
         * 1 : Payée
         **/
        public int Status { get; set; }

        /**
         * Gamme de tarification
         * 0 : Grand public 
         * 1 : Professionnel
         * 2 : Pays
         */
        public int Tarification { get; set; }
        /** 
         * Le Voyage associé à ce Fret
         */
        public Voyage Voyage { get; set; }

        public Fret()
        {

        }
    }

}
