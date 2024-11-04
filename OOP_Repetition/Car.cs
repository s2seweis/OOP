using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Repetition
{

    // Its internal, which means that
    // it can only be accesseed from
    // within the same assembly

    //The class is defined as our blueprint
    //and each time we create an object of it;
    //it follows the rules that we defined in this blueprint/class
    internal class Car
    {

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
        public Car(string model, string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;

            IsLuxury = isLuxury;
            //Console.WriteLine("An object of Car has been created!");
            Console.WriteLine($"A {brand} of the model " +
                $"{model} has been created.");
            IsLuxury = isLuxury;
        }

    }
}
