using System;

namespace GarbageCollector
{
    public class Program
    {

        public static void Main() 
        {

            Play romeoAndJuliet = new Play("Romeo and Juliet", "William Shakespeare", "Tragedies", 1562);
            romeoAndJuliet.ShowPlay();

            Console.WriteLine("------------------------------------------------------------");

            Shop abibas = new Shop("Abibas", "Evergreen terrace 742", "footwear");
            abibas.ShowStore();
            abibas.Dispose();


            //Завдання 3: 

            //Додайте до першого завдання реалізацію інтерфейсу IDisposable.

            //Додайте до другого завдання реалізацію деструктора. 

            //Напишіть код для тестування нових можливостей.
        }

    }


}
