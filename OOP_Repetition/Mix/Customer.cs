﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Repetition.Static
{
    internal class Customer
    {
        public string Name {  get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        //Default Constructor
        public Customer()
        {
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
        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
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

        // The static keyword indicates
        // that we don't need to call it on an object,
        // we can call the method without creating an customer object
        public static void DoSomeCustomerStuff()
        {
            Console.WriteLine("I'm doing some customer stuff");
        }

    }
}
