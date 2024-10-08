using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOPPartTwo
{
    // : Vehicle, bedeutet erbt von Vehicle
    // Die Elemente von Vehicle sind da aber nicht für uns sichtbar
    // Die Eigenschaften von Vehicles ist durch die Vererbung im Kontext der Klasse Car verfügbar
    internal class Car : Vehicle, IVehicle
    {
        public void Move()
        {
            Console.WriteLine("Vier Räder haben Bodenkontakt.");
        }
    }
}
