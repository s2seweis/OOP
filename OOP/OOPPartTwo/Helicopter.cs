using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOPPartTwo
{
    internal class Helicopter : Plane
    {
        // Mit override kann man die Methode von Plane überschreiben
        // base kommt von override 

        public override void Landing()
        {
            //base.Landing();

            Console.WriteLine("Der Helicopter sinkt langsam.");
        }

    }
}
