using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Repetition.Parameters
{
    class IndexParameters
    {
        public void IndexMainRun()
        {
            //Console.WriteLine(AddNum(15, 25));
            //// Named Parameters
            //Console.WriteLine(AddNum(firstNum: 15, secondNum: 25));
            //Console.WriteLine(AddNum(firstNum: 15, 25));
            //Console.WriteLine(AddNum(15, secondNum: 25));

            Rectangles r1 = new Rectangles();
            r1.Width = 5;
            r1.Height = 10;
            //Overwrite the property does not work because we have defined a setter for this property
            //r1.Area = 5;
            Console.WriteLine("Area of r1 is " + r1.Area);
        }

        static int AddNum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
