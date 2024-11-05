using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Repetition.Mix
{
    internal class Customer
    {
        // Static field to hold the next ID available
        private static int nextId = 0;

        // Read-only instance field initialized from the constructor
        private readonly int _id;

        // Backing field for write-only property
        private string _password;

        // Write-Only property
        public string Password { 
            set { _password = value; }
            //get { return _password; }
        }

        // Read Only Property | Start
        // Implemented a getter which will return this ID here
        public int Id {
            get { return _id; } 
        }

        // | End

        public string Name {  get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        //Default Constructor
        public Customer()
        {
            _id = nextId++;
            Name ="Default Name";
            Address = "Unknown";
            ContactNumber = "Not available";
        }

        // Custom Constructor => Sonstructor Snippet: ctor
        // Constructor with 3 Parameters
        //public Customer(string name, string address, string contactNumber)
        //{
        //    Name = name;
        //    Address = address;
        //    ContactNumber = contactNumber;
        //}

        // Default/ Optional parameter address and contactNumber
        // Custom constructor
        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // Default Parameter ContactNumber
        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details about the customer: " 
                + $"Name is {Name} " 
                + $"and Id is {_id}" 
                //+ $" and the password is {Password}"
                );
        }


        // The static keyword indicates
        // that we don't need to call it on an object,
        // we can call the method without creating an customer object
        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("I'm doing some customer stuff");
        }

    }
}
