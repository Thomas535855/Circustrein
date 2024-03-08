using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
  
    public class Dier
    {
        public enum Dieet
        {
            Planten,
            Vlees
        }
        public enum Grootte
        {
            Klein = 1,
            Middel = 3,
            Groot = 5
        }
        public Grootte _grootte {  get; set; }
        public Dieet _dieet { get; set; }

        public Dier(Grootte grootte, Dieet dieet)
        {
            _dieet = dieet;
            _grootte = grootte;
        }
    }
}
