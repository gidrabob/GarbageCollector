using GarbageCollector;
using System;

namespace GarbageCollector
{
    public class Program
    {
        public static void TestPlay()
        {
            Play romeoAndJuliet = new Play("Romeo and Juliet", "William Shakespeare", "Tragedies", 1562);
            romeoAndJuliet.ShowPlay();
        }
        public static void TestShop()
        {
            Shop abibas = new Shop("Abibas", "Evergreen terrace 742", "footwear");
            abibas.ShowStore();
        }
        public static void Main() 
        {
            //TestPlay();
            //GC.Collect();
            //Console.Read();

            //Play romeoAndJuliet = new Play("Romeo and Juliet", "William Shakespeare", "Tragedies", 1562);
            //romeoAndJuliet.ShowPlay();
            //romeoAndJuliet.Dispose();

            TestShop();
            GC.Collect();
            Console.Read();

            Shop abibas = new Shop("Abibas", "Evergreen terrace 742", "footwear");
            abibas.ShowStore();
            abibas.Dispose();
        }
    }
}
