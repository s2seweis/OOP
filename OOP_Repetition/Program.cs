using System;
using OOP_Repetition.Constructors;
using OOP_Repetition.Methods;
using OOP_Repetition.Parameters;
using OOP_Repetition.Static;
using OOP_Repetition.Mix;

namespace OOP_Repetition
{
    class Program
    {
        static void Main()
        {
            // Part:1 | Constructors
            //IndexConstructor indexForConstructorExample = new IndexConstructor();
            //indexForConstructorExample.IndexMainRun();  // Calls the Run method in Index

            // Part:2 | Methods
            //IndexMethods indexForMethodExample = new IndexMethods();
            //indexForMethodExample.IndexMainRun();

            // Part:3 | Parameters
            //IndexParameters indexForParameterExample = new IndexParameters();
            //indexForParameterExample.IndexMainRun(); 

            // Part:4 | Static
            //IndexStatic indexForStaticExample = new IndexStatic();
            //indexForStaticExample.IndexMainRun();

            // Part:5 | Mix
            IndexMix indexForMixExample = new IndexMix();
            indexForMixExample.IndexMainRun();


            Console.ReadKey(); //  A single key press
        }
    }
}
