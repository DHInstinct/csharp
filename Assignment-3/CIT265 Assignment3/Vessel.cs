using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT265_Assignment3
{
    abstract class Vessel
    {
        public Vessel(string Name = "", float Speed = 0)
        {
            this.name = Name;
            this.speed = Speed;
        }
        private float speed;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public virtual void Move() { }
        

    }
}
