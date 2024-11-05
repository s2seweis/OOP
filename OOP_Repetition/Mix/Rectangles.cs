using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Repetition.Mix
{
    internal class Rectangles
    {

        // ### const and readonly ###
        // In C#, const and readonly are two keywords used to define non-modifiable fields, 
        // but they differ in terms of when they are initialized and their usage contexts.
        // Unterstanding the diferences between these two can help in deciding which one 
        // to use based on specific requirements

        // declaration of field => const that is going to be the same for every rectangle that we are going to create
        public const int NumberOfCorners = 4;
        // declaration of field => can be different for every single rectangle that we are creating
        public readonly string Color = "Blue";

        // Readonly field: A unique identifier for each rectangle instance. 
        //private readonly string _id;

        public Rectangles(string color)
        {
            Color = color;
        }

        // Method to display the details of the rectangle
        public void DisplayDetails()
        {

            Console.WriteLine($"Color: {Color}, Width: {Width}, " 
                + $"Height: {Height}, Area: {Area}, Number of Corners: {NumberOfCorners}");
        }

        public double Width { get; set; }
        public double Height { get; set; }


        public double Area
        {
            get { return Width * Height; }

        }
    }
}
