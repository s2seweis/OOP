using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Repetition.Mix
{
    internal class IndexMix
    {
        public void IndexMainRun()
        {
            //Part: 1 Write only Properties

            //Customer customer1 = new Customer();
            //// if you hover over the new Object:
            //// new Customer() => you can see multiple overloads
            //// => e.g. "(+ 1 overload) means that there are multiple constructors that we can use
            //Customer customer2 = new Customer("John Doe");
            //Customer customer3 = new Customer();

            //customer1.GetDetails();
            //customer2.GetDetails();

            //Console.WriteLine("Customer 3 id is " + customer3.Id);

            //Part: 2 Read only Properties, not possible to access the value without a get accessor
            // 
            //customer3.Password = "1234567";
            //// After the password is defined the method will be called
            //customer3.GetDetails();
            //Console.WriteLine(customer3.Password);

            // Part:3 Const and ReadOnly

            Rectangles rectangle1 = new Rectangles("Red");
            Rectangles rectangle2 = new Rectangles("Blue");

            rectangle1.DisplayDetails();
            rectangle2.DisplayDetails();
        }
    }
}
