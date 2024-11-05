using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Repetition.Parameters
{
    internal class Rectangles
    {

        public double Width { get; set; }
        public double Height { get; set; }

        // Computed property 

        // Read only Prop because it has only get 
        public double Area
        {
            get { return Width * Height; }

        }
    }
}
