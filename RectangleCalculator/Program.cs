using System;

namespace RectangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! This program will help you find the area of a rectangle.");
            Console.WriteLine("First, please enter the width of the rectangle as a whole number:");
            string x = Console.ReadLine();
            Console.WriteLine("Okay, looks like the rectangle is " + x + " units wide. Now please enter the height of the rectangle as a whole number:");
            string y = Console.ReadLine();

            int xint = int.Parse(x);
            int yint = int.Parse(y);
            int z = xint * yint;

            Console.WriteLine("Okay, looks like the rectangle is " + y + " units tall. Now we know that the area of the rectangle is " + z + " units.");
            Console.ReadLine();
        }
    }
}
