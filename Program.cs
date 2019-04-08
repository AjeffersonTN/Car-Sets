using System;
using System.Collections.Generic;

namespace carSets
{
    class Program
    {
        static void Main(string[] args)
        {
           HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Chevelle");
            Showroom.Add("M6");
            Showroom.Add("Escalade");
            Showroom.Add("H1");

            // foreach (string model in Showroom)
            // {
            //     Console.WriteLine(model);
            // }

            Showroom.Add("Escalade");

            HashSet<string> UsedLot = new HashSet<string>();
            Showroom.Add("Escape");
            Showroom.Add("Silverado");

            Showroom.UnionWith(UsedLot);

            // foreach (string model in Showroom)
            // {
            //     Console.WriteLine(model);
            // }

            Showroom.Remove("H1");

            //  foreach (string model in Showroom)
            // {
            //     Console.WriteLine(model);
            // }

            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Fiat");
            Junkyard.Add("5 Series");
            Junkyard.Add("MKZ");
            Junkyard.Add("Chevelle");
            Junkyard.Add("M6");
            Junkyard.Add("Escalade");

          HashSet<string> clone = new HashSet<string>(Showroom);
          clone.IntersectWith(Junkyard);


            //  foreach (string model in clone)
            // {
            //     Console.WriteLine(model);
            // }

            Showroom.UnionWith(Junkyard);

            //   foreach (string model in Showroom)
            // {
            //     Console.WriteLine(model);
            // }

            Showroom.Remove("Fiat");
            Showroom.Remove("MKZ");

              foreach (string model in Showroom)
            {
                Console.WriteLine(model);
            }


        }
    }
}
