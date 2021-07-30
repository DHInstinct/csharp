using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class main
    {
        static void Main(string[] args)
        {
            /*
                Daniel Hartley
                Assignment 1
                Due: 09/07/20
                Completed: 09/07/20
             */


            Line myLine;
            myLine = new Line();

            Line mySecondLine;
            mySecondLine = new Line();

            myLine.setA(4);
            myLine.setB(10);
            myLine.setC(12);

            mySecondLine.setA(4);
            mySecondLine.setB(10);
            mySecondLine.setC(12);

            Console.Out.WriteLine($"The value of A: {myLine.getA()}");
            Console.Out.WriteLine($"The value of B: {myLine.getB()}");
            Console.Out.WriteLine($"The value of C: {myLine.getC()}");
            Console.Out.WriteLine($"Equation: {myLine.getA()} x + {myLine.getB()} y = {myLine.getC()}");

            Console.Out.WriteLine($"Returning X: {myLine.ReturnX(0)}");
            Console.Out.WriteLine($"Returning Y: {myLine.ReturnY(0)}");

            Console.Out.WriteLine($"Slope: {myLine.Slope()}");

            myLine.isParallel(myLine, mySecondLine);

            myLine.isPerpendicular(myLine, mySecondLine);

            Console.Out.WriteLine(myLine.intercept(myLine, mySecondLine));

        }


    }

    
}
