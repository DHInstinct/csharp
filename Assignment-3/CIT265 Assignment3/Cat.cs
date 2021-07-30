using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Assignment3
{
    class Cat : IRefillable
    {
        public Cat(string Name = "", int Hunger = 0, int MaxHunger = 100)
        {
            this.maxHunger = MaxHunger;
            this.name = Name;
            if(Hunger <= MaxHunger)
                this.hunger = Hunger;
        }

        private int hunger;
        private int maxHunger;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int MaxHunger
        {
            get { return maxHunger; }
            set { maxHunger = value; }
        }

        public int Hunger
        {
            get { return hunger; }
            set { hunger = value; }
        }

        public float FuelPercentage
        {
            get => (float)Hunger / MaxHunger;
        }

        public void Refill(int amt)
        {
            if (amt > 0 && amt < MaxHunger - amt)
                Hunger += amt;
            else Console.WriteLine("Please enter a valid amount");
        }
    }
}
