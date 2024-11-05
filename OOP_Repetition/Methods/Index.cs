using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OOP_Repetition.Methods;

namespace OOP_Repetition.Methods
{
    internal class IndexMethods
    {
        public void IndexMainRun()
        {
            // Part: 1
            //Car myAudi = new Car("A3", "Audi", false);
            //myAudi.Drive();

            //Car myBmv = new Car("i7", "BMW", true);
            //myBmv.Drive();

            // Part: 2
            Customer myCustomer = new Customer();
            Customer earl = new Customer("Earl");

            myCustomer.SetDetails("Frank", "Mainstreet 2", "555121312");

            Console.WriteLine("My customer is: " + myCustomer.Name + " and he lives in " + myCustomer.Address);
            Console.WriteLine("My friends name is: " + earl.Name + " and he lives in " + earl.Address);

        }

    }
}


// Functions do the same thing like methods but they are not in the scope of a class