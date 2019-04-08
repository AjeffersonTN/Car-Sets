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

             foreach (string model in Showroom)
            {
                Console.WriteLine(model);
            }
        }
    }
}
