using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Circustrein
{

    public class Wagon
    {
        public List<Dier> Dieren { get; set; }

        public Wagon()
        {
            Dieren = new List<Dier>();
        }

        public int berekenPunten()
        {
            int totaalPunten = 0;
            foreach (var Dier in Dieren)
            {
                switch (Dier._grootte)
                {
                    case Dier.Grootte.Klein:
                        totaalPunten += 1;
                        break;

                    case Dier.Grootte.Middel:
                        totaalPunten += 3;
                        break;

                    case Dier.Grootte.Groot:
                        totaalPunten += 5;
                        break;
                }
            }
            return totaalPunten;
        }


        public bool kanDierToevoegen(Dier dier)
        {
            if (Dieren.Count == 0)
            {
                return true;
            }
            if (!Dieren.Any(existingDier => existingDier._dieet == Dier.Dieet.Vlees && existingDier._grootte >= dier._grootte) || dier._dieet == Dier.Dieet.Vlees)
            {

                int punten = berekenPunten();

                switch (dier._grootte)
                {
                    case Dier.Grootte.Klein:
                        punten += 1;
                        break;

                    case Dier.Grootte.Middel:
                        punten += 3;
                        break;

                    case Dier.Grootte.Groot:
                        punten += 5;
                        break;
                }
                return punten <= 10;
            }

            return false;
        }
    }
}
