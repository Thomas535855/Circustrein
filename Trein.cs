using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Trein
    {
        public List<Wagon> wagons { get; set; }

        public Trein() 
        {
            wagons = new List<Wagon>();
        }

        public void dierToevoegen(Dier dier)
        {
            Wagon wagon = wagons.FirstOrDefault(w => w.kanDierToevoegen(dier));

            if (wagon == null)
            {
                wagon = new Wagon();
                wagons.Add(wagon);
            }

            var groteVleeseters = wagon.Dieren.Where(existingDier => existingDier._dieet == Dier.Dieet.Vlees && existingDier._grootte >= dier._grootte).ToList();

            if (groteVleeseters.Any() || dier._dieet == Dier.Dieet.Vlees)
            {
                var nieuweWagon = new Wagon();
                nieuweWagon.Dieren.Add(dier);
                wagons.Add(nieuweWagon);
            }
            else
            {
                wagon.Dieren.Add(dier);
            }
        }
    }
}
