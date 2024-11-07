using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Assignment_1_4
{

    class Point //class no execute
    {
        //define variables
        //I need to go grocery shopping
        string fruit; //word option
        int myFruitamount; //number option in bowl /public double x;
        int myFruitleftover; //number option in bag /public double y;
                             //int mybananaamount;
                             //int mybananaleftover;
                             //int myorangeamount;
                             //int myorangeleftover;

        string answer1;
        string answer2;
        //Random lookie = new Random(); //glance at the bowl!

        static void Main(string[] args) // execute hither
        //do
        {
            //Point p1 = new Point(4, 5);
            //Point p2 = new Point(6, 7);
            //insert 2 data points here somewhere
            Console.WriteLine("What fruit is in the fruitbowl?");
            Console.WriteLine("");
            Console.WriteLine("I dont' know! Let's take a look.");
            Console.WriteLine("");

            DateTime Now = DateTime.Now;
            //Console.WriteLine(Now.TimeOfDay);
            //Can't help it, gotta play with new things

            TimeOnly time = TimeOnly.FromDateTime(Now);
            Console.WriteLine($"The clock on the wall says {time}!");
            Console.WriteLine("");
            //roll random number to see what fruit we see in bowl
            //if
            Point myFruit = new Point();
            myFruit.fruit = "Apple";
            int myFruitamount = 5;
            string answer1 = ($"There are {myFruitamount} {myFruit.fruit}'s in the bowl!");
            Console.WriteLine(answer1);
            Console.WriteLine($"There are still some {myFruit.fruit}'s in the bag!");

            /*Create a structure*(Creating a class instead)
            named “Point” and 2 data members:
            X and Y coordinate. Declare 2 points: P1 and P2. 
            Determine if P2 is to the right or left of P1 or on same axis, 
            by comparing the x xoordinates. (if p1.x is more than p2.x, 
            it is to the right)*/
        }

        //while amount > 0;
        //myFruitamount--;
        //Console.Readline();
        //Console.WriteLine($"Do you want to check again?(y/n)");
        //answer2 = Console.ReadLine();
        //while (answer2 == "y" || "Y");
        //myFruitleftover--;

        //Point p1 = new Point(3, 7);
        //Point p2 = new Point(2, 7);

    }   //if (p1.x > p2.x)

        //Console.WriteLine("p2 is to the right of p1");

        //else if (p1.x<p2.x)
}            
        //Console.WriteLine("p2 is to the left of p1");
            
            

        //public class point

        //public point(double xCoord, double yCoord);

        //x = xCoord;
        //y = yCoord;
   
        
