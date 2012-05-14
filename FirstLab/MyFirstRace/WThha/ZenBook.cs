using System;


namespace LeftOvers
    {
    class ZenBook
        {
        private int a = 10;
        private int b = 24;

        public  void Test()
         {
             Console.WriteLine(a>b ? "a is big" : "b is big");
         }

        public  static  void Main()
        {
            ZenBook something =
            new ZenBook();
             
            something.Test();
            Console.ReadLine();
        }
        }
    }
