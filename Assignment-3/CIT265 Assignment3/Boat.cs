using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Assignment3
{
    class Boat : Vessel
    {
        //Boat ctor
        public Boat(string Name = "", float Speed = 0, int Oars = 0)
        {
            this.Name = Name;
            this.Speed = Speed;
            this.oars = Oars;

        }

        private int oars;
        public int Oars
        {
            get { return oars; }
            set { oars = value; }
        }

        public override void Move()
        {
            Console.WriteLine($"{Name}'s  speed is: {Speed * Oars}");
        }

    }
}
