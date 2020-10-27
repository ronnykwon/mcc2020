using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseExample
{
    public class Voyage
    {
        public int Id { get; set; }
        public List<Fret> Frets { get; set; }

        public DateTime DateDepart { get; set; }
        public DateTime DateArrivee { get; set; }
        /**
         * Volume maximal accepté en Fret durant ce voyage
         */
        public int MaxVolumeFret { get; set; }
        public Voyage()
        {
            this.Frets = new List<Fret>();
        }
    }
}
