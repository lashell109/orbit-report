using System;

namespace MoreOnNumericTypes_2._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gas;
            double milesPerGallon;
            string input;
            
            Console.WriteLine("How many miles you have driven?");
            input = Console.ReadLine();
            miles = double.Parse(input);

            Console.WriteLine("How many gallons of gas have you consumed?");
            input = Console.ReadLine();
            gas = double.Parse(input);

            milesPerGallon = miles / gas;
            Console.WriteLine("Your miles-per-gallon is: " + milesPerGallon);
            Console.ReadLine();

        }
    }
}
