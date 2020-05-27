using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Building FiveOneTwoEighth = new Building("512 8th Ave")
            {
                Width = 30.25,
                Depth = 40,
                Stories = 5
            };
            Building TwoFiveOneDekalb = new Building("251 Dekalb Pike")
            {
                Width = 70.25,
                Depth = 40,
                Stories = 10
            };
            Building OneFiveTwoNineGreen = new Building("1529 Green St")
            {
                Width = 25.25,
                Depth = 30,
                Stories = 3
            };
            Building SixSixThreeFiveMccallum = new Building("6635 Mccallum St")
            {
                Width = 30.25,
                Depth = 40,
                Stories = 5
            };

            FiveOneTwoEighth.Construct();
            TwoFiveOneDekalb.Construct();
            OneFiveTwoNineGreen.Construct();
            SixSixThreeFiveMccallum.Construct();

            FiveOneTwoEighth.Purchase("Joe Goldberg");
            TwoFiveOneDekalb.Purchase("Jonathan Simmons");
            OneFiveTwoNineGreen.Purchase("Jon Marks");
            SixSixThreeFiveMccallum.Purchase("Aleshia Hickson");

            List<Building> buildingCollection = new List<Building>()
            {
                FiveOneTwoEighth,
                TwoFiveOneDekalb,
                OneFiveTwoNineGreen,
                SixSixThreeFiveMccallum
            };

            foreach (Building localBuilding in buildingCollection)
            {
                Console.WriteLine(localBuilding.ProvideAddress());
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Designed by {localBuilding.ProvideDesigner()}");
                Console.WriteLine($"Constructed on {localBuilding.ProvideBuildDate()}");
                Console.WriteLine($"Owned by {localBuilding.ProvideOwner()}");
                Console.WriteLine($"{localBuilding.Volume} cubic meters of space");
                Console.WriteLine();
            }
        }
    }
}