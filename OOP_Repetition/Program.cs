using System;

namespace OOP_Repetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an Object of the class car 
            // Creating an instance of the class Car (Different way to describe it)
            Car audi = new Car("A3", "Audi", false);
            Car bmv = new Car("i7", "BMW", true);

            //Console.WriteLine("Please enter the Brand name");
            //// "SETTING BRAND"
            //audi.Brand = Console.ReadLine();

            // GETTING BRAND
            Console.WriteLine("Brand is " + audi.Brand);
            Console.WriteLine("Brand is " + bmv.Brand);

            //Console.WriteLine("Press Enter to exit the program...");
            //Console.ReadLine(); // Wait for the user to press Enter
            Console.ReadKey(); //  A single key press
        }
    }
}
