using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Repetition.Static
{
    internal class IndexStatic
    {
        public void IndexMainRun()
        {
            // Part:1 | Static Methods

            //// Can only be called here because its static
            //MyMethod();
            //// Not needed to call an object of customer class for call the method,
            //// we call it under Customer class because its where the method is
            //Customer.DoSomeCustomerStuff();

            //Customer customer = new Customer();

            //// The DoSomeCustomerStuff method is static and cannot be called on Ojects
            ////customer.DoSomeCustomerStuff();
            //customer.SetDetails("Dennis", "Main Street 1");

            //Console.WriteLine("The custome name is: " 
            //                    + customer.Name 
            //                    + " and the address of the customer is: " 
            //                    + customer.Address);

            // Part:2 | Static Fields

            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car("A3", "Audi", false);

            // accessing the public variable NumbersOfCars of the Car Class
            Console.WriteLine("Number of cars produced: " + Car.NumberOfCars);



        }

        // In C#, the static keyword is used to declare
        // members of a class that belong to the class itself
        // rather than to any specific instance of the class

        //static void MyMethod ()
        //{
        //    Console.WriteLine("Hello World from a Static Method!");
        //}
    }
}

// Information: The static keyword can also be used for classes, constructors, properties and fields
// Overall, static is a powerful keyword in C# that enables class-level functionality, making it suitable for scenarios
// where you need consistent behavior or data management that is common across all instances of a class.
