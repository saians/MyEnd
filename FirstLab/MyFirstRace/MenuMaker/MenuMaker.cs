using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuMaker
    {
    class MenuMaker
        {
        public Random Randomizer;

        public string[] Meats = { "kebab", "nihari", "karahi" };
        public string[] Veg = { "spring roll", "noodles", "rice" ,"aalo k samsosay"};
        public string[] Dessert = { "fruits", "custurd","golaganda","gol gappay" };

        public string GetMenu()
            {
            string RandomMeat = Meats[Randomizer.Next(Meats.Length)];
            string RandomVeg = Veg[Randomizer.Next(Veg.Length)];
            string RandomDessert = Dessert[Randomizer.Next(Dessert.Length)];

            return RandomMeat + " with " + RandomVeg + " and " + RandomDessert;
            }
        }
    }
