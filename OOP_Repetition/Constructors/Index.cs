using System;

namespace OOP_Repetition.Constructors
{
    internal class IndexConstructor
    {
        public void IndexMainRun()
        {
            // ### Part:1 - Start ###
            //Car audi = new Car("A3", "Audi", false);
            //Car bmw = new Car("i7", "BMW", true);

            //Console.WriteLine("Please enter the Brand name:");
            //audi.Brand = Console.ReadLine();

            //Console.WriteLine("Brand is " + audi.Brand);
            //Console.WriteLine("Brand is " + bmw.Brand);

            //Console.WriteLine("Press Enter to continue...");
            //Console.ReadLine();
            // ### Part:1 - End ###

            // ### Part:2 - Start ###
            //Customer earl = new Customer("Earl");
            //Customer frank = new Customer("Frank", "Mainstreet 1", "55-125-56");

            //Console.WriteLine("Name of Customer is " + earl.Name);
            //Console.WriteLine("Name of Customer is: " + frank.Name +
            //                  ", Address of customer is: " + frank.Address +
            //                  ", Contact Number of the customer is " + frank.ContactNumber);

            Customer myCustomer = new Customer();
            Console.WriteLine("Please enter the customer's Name:");
            myCustomer.Name = Console.ReadLine();

            Console.WriteLine("Details about customer: " + myCustomer.Name +
                              $", Address is: {myCustomer.Address}" +
                              $", Contact Number is: {myCustomer.ContactNumber}");
            // ### Part:2 - End ###
        }
    }
}
