using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Repetition.Constructors
{
    internal class Customer
    {
        public string Name {  get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Custom Constructor => Sonstructor Snippet: ctor
        // Constructor with 3 Parameters
        public Customer(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // Constructor with 1 Parameter
        public Customer(string name)
        {
            Name=name;
        }

        // Default Constructor
        public Customer()
        {
            Name ="Default Name";
            Address = "Unknown";
            ContactNumber = "Not available";
        }



    }
}
