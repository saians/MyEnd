using System;
using System.Collections.Generic;

namespace EnumAndColl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> duckList = new List<Duck>()
                                   {
                                       new Duck(){Name = "dell",Kind = KindofDuck.metro},
                                       new Duck(){Name = "asus", Kind = KindofDuck.heloo}
                                      
                                   };
            Console.WriteLine();
            Console.ReadKey();
        }
    }



    public class Duck
    {
        public string Name;

        public KindofDuck Kind;
    }


    public enum KindofDuck
    { metro, heloo, dydu }

}
