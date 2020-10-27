using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReparationPhone.Metier
{
    
    public class Business
    {
        public static ObservableCollection<Reparation> Reparations { get; }

        static Business()
        {
            Reparations = new ObservableCollection<Reparation>();
            Business.Reparations.Add(new Reparation("Kohu", "Bars","87878787", "kohu@bars.com", "iPhone 9", "écran cassée au niveau de la caméra, bouton home ne fonctionne plus"));
            Business.Reparations.Add(new Reparation("KWON", "Ronny","87305445", "ronny@kwon.com", "Xiao Mi Mi 9", "écran fissuré"));
            Business.Reparations.Add(new Reparation("Ana", "Bak","87787980", "ana@bak.com", "Samsung J9", "Chargeur ne fonctionne plus"));
        }
    }
}
