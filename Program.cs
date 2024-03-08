using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            var trein = new Trein();

            Console.WriteLine("Hoeveel planteneters wil je sorteren?");
            int aantalPlanteneters = int.Parse(Console.ReadLine());

            Console.WriteLine("Hoevel vleeseters wil je sorteren?");
            int aantalVleeseters = int.Parse(Console.ReadLine());

            Console.WriteLine("Hoeveel vleeseters zijn groot?");
            int aantalGroteVleeseters = int.Parse(Console.ReadLine());

            Console.WriteLine("Hoeveel vleeseters zijn middelgroot?");
            int aantalMiddelgroteVleeseters = int.Parse(Console.ReadLine());

            Console.WriteLine("Hoeveel vleeseters zijn klein?");
            int aantalKleineVleeseters = int.Parse(Console.ReadLine());

            Console.WriteLine("Hoeveel planteneters zijn groot?");
            int aantalGrotePlanteneters = int.Parse(Console.ReadLine());

            Console.WriteLine("Hoeveel planteneters zijn middelgroot?");
            int aantalMiddelgrotePlanteneters = int.Parse(Console.ReadLine());

            Console.WriteLine("Hoeveel planteneters zijn klein?");
            int aantalKleinePlanteneters = int.Parse(Console.ReadLine());


            for (int i = 0; i < aantalGroteVleeseters; i++)
            {
                trein.dierToevoegen(new Dier(Dier.Grootte.Groot, Dier.Dieet.Vlees));
            }

            for (int i = 0; i < aantalMiddelgroteVleeseters; i++)
            {
                trein.dierToevoegen(new Dier(Dier.Grootte.Middel, Dier.Dieet.Vlees));
            }

            for (int i = 0; i < aantalKleineVleeseters; i++)
            {
                trein.dierToevoegen(new Dier(Dier.Grootte.Klein, Dier.Dieet.Vlees));
            }

            for (int i = 0; i < aantalGrotePlanteneters; i++)
            {
                trein.dierToevoegen(new Dier(Dier.Grootte.Groot, Dier.Dieet.Planten));
            }

            for (int i = 0; i < aantalMiddelgrotePlanteneters; i++)
            {
                trein.dierToevoegen(new Dier(Dier.Grootte.Middel, Dier.Dieet.Planten));
            }

            for (int i = 0; i < aantalKleinePlanteneters; i++)
            {
                trein.dierToevoegen(new Dier(Dier.Grootte.Klein, Dier.Dieet.Planten));
            }

            Console.WriteLine("Verdeling: ");
            for (int i = 0; i < trein.wagons.Count; i++)
            {
                Console.WriteLine($"Wagon {i + 1}:");
                foreach (var dier in trein.wagons[i].Dieren)
                {
                    Console.WriteLine($"- {dier._grootte}, {dier._dieet}");
                }
                Console.WriteLine($"Totale punten: {trein.wagons[i].berekenPunten()}\n");
            }

            Console.WriteLine("Klik op een toets om te sluiten");
            Console.ReadKey();
            
        }
    }
}
