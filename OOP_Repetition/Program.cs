using System;
using OOP_Repetition.Constructors;
using OOP_Repetition.Methods;
using OOP_Repetition.Parameters;

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
            IndexParameters indexForParameterExample = new IndexParameters();
            indexForParameterExample.IndexMainRun();

            Console.ReadKey(); //  A single key press
        }
    }
}
