using System;
using System.Runtime.InteropServices;

namespace NumericTypes_2._5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            string input;

            Console.WriteLine("What is the length of the retangle?");
            input = Console.ReadLine();
            length = double.Parse(input);

            Console.WriteLine("What is the width of the retangle?");
            input = Console.ReadLine();
            width = double.Parse(input);

            area = length * width;
            Console.WriteLine("The area of the retangle is: " + area);
            Console.ReadLine();
        }
    }
}
