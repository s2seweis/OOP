using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Repetition.Static
{

    // Its internal, which means that
    // it can only be accesseed from
    // within the same assembly

    //The class is defined as our blueprint
    //and each time we create an object of it;
    //it follows the rules that we defined in this blueprint/class
    internal class Car
    {
        // Static field/variable here, its not a private member variable
        // so no underscore like _numberOfCars needed 
        // instead we use an capital letter
        // Its public so that I can access it from outside the car class
        public static int NumberOfCars = 0;

        // member variable
        // private hides the variable from other classes
        // Backing Field of the Model property
        private string _model = "";

        private string _brand = "";

        //private bool _isLuxury;

        // Property, 
        public string Model { get => _model; set => _model= value; } // simplified version

        //public string Model // more complicate version
        //{
        //    get
        //    {
        //        return _model;
        //    }
        //    set
        //    {
        //        _model
        //    }
        //}

        public string Brand { 

            // Is a getter method
            get
            {
                if (IsLuxury)
                //if (_isLuxury)
                {
                    return _brand + " - Luxury Edition";
                }else
                {
                    return _brand;
                }
            }

            set { 
                    if(string.IsNullOrEmpty(value))
                        {
                            //Part of encapsulation where you define specifically;
                            //what the condition should be when somebody tries to access your variables
                             Console.WriteLine("You entered NOTHING!");
                             _brand = "DEFAULT VALUE";
                             }else
                             {
                             _brand = value;
                             }
                        }
                }

        public bool IsLuxury { get; set; }

        //public bool IsLuxury { get => _isLuxury; 
        //    set => _isLuxury=value; }

        // Constructor, not has a return type, will be executed when ever a new object of car is created
        // Custom Constructor
        public Car(string model, string brand, bool isLuxury)
        {
            NumberOfCars++;

            Model = model;
            Brand = brand;

            //Console.WriteLine("An object of Car has been created!");
            Console.WriteLine($"A {brand} of the model " +
                $"{model} has been created.");
            IsLuxury = isLuxury;
        }

        public Car()
        {
            NumberOfCars++;
        }

        public void Drive()
        {
            //Console.WriteLine("I am driving!");
            Console.WriteLine($"I'm a {Model} and I'm driving");
        }

        //// Default Constructor for Car
        //public Car()
        //{
           
        //}


    }
}
