using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string messageFromSale = "";
            Console.WriteLine("\n" + messageFromSale + "\n"); // evil code line
            //                  ^^ 
            // If you delete these both characters, the error module goes apeshit and loops forever until the RAM is full and the computer freezes up.
            // Sometimes it has a different trigger, but these characters work every time.
        }
    }
}
