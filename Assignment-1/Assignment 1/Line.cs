using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Line
    {
        private float a;
        private float b;  
        private float c;

        public Line(float a = 0, float b = 0, float c = 0) // using constructor & default parameters
        { 
            // using the current instance to assign values given to through the parameters of when making a new object. 
            this.a = a;
            this.b = b;
            this.c = c;
        
        }
        
        public float Slope()
        {
            if (b != 0)
            {
                return -a / b;
            }

            return -1;
        }

        public float ReturnX(float y)
        {
            return (c - b*y) / a;
        }

        public float ReturnY(float x)
        {
            return (c - a*x) / b;
        }

        public void isParallel(Line l1, Line l2)
        {
            if(l1.Slope() == l2.Slope())
            {
                Console.Out.WriteLine("Lines are parallel");
            }
            else
            {
               Console.Out.WriteLine("Lines are not Parallel");
            }
        }

        public void isPerpendicular(Line l1, Line l2)
        {
            float temp = l1.Slope() * l2.Slope();
            if (temp == -1)
            {
                Console.Out.WriteLine("The lines are perpendicular");
            }
            else
            {
                Console.Out.WriteLine("The lines are not perpendicular");
            }
        }   
       
        public string intercept(Line l1, Line l2)
        {
            if(l1.Slope() == l2.Slope())
            {
                return "Lines are parallel, No point of intersection";
            }
            string intercept = "";

            float x = ((l1.getC() * l2.getB()) - (l2.getC() * l1.getB() /((l1.getA() * l2.getB()) - l2.getA() * l1.getB())));
            float y = ReturnY(x);
            intercept = "(" + x + ", " + y + ")";

            return intercept;

        }
      
        public float getA()
        {
            return a;
        }
        public float getB()
        {
            return b;
        }
        public float getC() 
        {
            return c;
        }

        //setter functions
        public void setA(float newA)
        {
            a = newA;
        }
        public void setB(float newB)
        {
            b = newB;
        }
        public void setC(float newC)
        {
            c = newC;
        }
    }
}
