using System;

namespace Planner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Building godzillaHouse = new Building("1 Godzilla Lane")
            {
              Name = "Godzilla's House",
              Stories = 100,
              Width = 10000,
              Depth = 10000
            };

            City Monsterville = new City("Monsterville")
            {
              Mayor = "Joe Bob Briggs",
              YearFounded = 1983
            };

            godzillaHouse.Purchase("Mechagodzilla");

            Monsterville.AddBuilding(godzillaHouse);

            Monsterville.PrintBuildings();
        }

        
    }
}