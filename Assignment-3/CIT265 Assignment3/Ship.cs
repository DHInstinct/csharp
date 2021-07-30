using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CIT265_Assignment3
{
    class Ship : Vessel, IRefillable
    {

        public Ship(string Name = "", float Speed = 0, int Fuel = 0, int maxFuel = 0)
        {
            this.Name = Name;
            this.Speed = Speed;
            this.fuel = Fuel;
            if(Fuel <= maxFuel)
                this.maxFuel = maxFuel;

        }
        private int fuel;
        private int maxFuel;

        public int MaxFuel
        {
            get { return maxFuel; }
            set { maxFuel = value; }
        }

        public int Fuel
        {
            get { return fuel; }
            set { 
                if(fuel <= maxFuel)
                {
                    fuel = value; 
                }
            }
        }

        public float FuelPercentage
        {
            get => (float)Fuel / MaxFuel;
        }

        public override void Move()
        {
            if(Fuel != 0)
            {
                Console.WriteLine($"{Name}'s speed is: {Speed}");
            }
            else
            {
               Console.WriteLine($"{Name} has no Fuel!");
            }

        }

        public void Refill(int amt)
        {
            if(amt > 0 && amt < MaxFuel - amt)
                Fuel += amt;
        }
    }
}
