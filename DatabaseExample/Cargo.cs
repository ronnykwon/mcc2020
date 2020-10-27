using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseExample
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public List<Voyage> Voyages { get; set; }

        public Cargo()
        {
            this.Voyages = new List<Voyage>();
        }
    }
}
