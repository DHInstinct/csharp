using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Assignment3
{
    class main
    {
        static void Main(string[] args)
        {
            Ship SSMartian = new Ship("SSMartian", 20, 10, 100);
            Ship TheDrunkenTortuga = new Ship("The Drunken Tortuga", 100, 1000, 5000);
            Ship TheMayflowerGhost = new Ship("The Mayflower Ghost", 900, 100, 500);
            Ship TheHowlingSeaRovers = new Ship("The Howling Sea Rovers", 2, 100500, 5000000);

            Boat Unsinkable = new Boat("Unsinkable",5, 2);
            Boat AlottaOcean = new Boat("AlottaOcean", 54, 20);
            Boat Vamoose = new Boat("Vamoose", 42, 32);
            Boat BigNauti = new Boat("Big Nauti", 50, 200);

            Cat MrKitty = new Cat("Mr. Kitty", 66, 100);

            Vessel[] vessels = { SSMartian, Unsinkable, TheDrunkenTortuga, AlottaOcean, TheMayflowerGhost, Vamoose, TheHowlingSeaRovers, BigNauti };

            //1):
            Unsinkable.Move();
            SSMartian.Move();

            Console.WriteLine("");
            Console.WriteLine("");

            // 2):
            foreach (var vessel in vessels)
                vessel.Move();

            //3):
            Console.WriteLine(TheDrunkenTortuga.FuelPercentage);
            TheDrunkenTortuga.Refill(10000);
            Console.WriteLine(TheDrunkenTortuga.Fuel);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine($"{MrKitty.FuelPercentage}");
            MrKitty.Refill(20);
            Console.WriteLine($"{MrKitty.Name}'s hunger is: {MrKitty.Hunger}");
        }
    }
}
