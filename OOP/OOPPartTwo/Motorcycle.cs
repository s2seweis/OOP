using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOPPartTwo
{
    // : Vehicle, bedeutet erbt von Vehicle
    // Die Elemente von Vehicle sind da, aber nicht für uns sichtbar
    // Die Eigenschaften von Vehicles ist durch die Vererbung im Kontext der Klasse Car verfügbar
    // Motorcyle erbt auch das Interface, Null Toleranz Schwelle/ kein platz für fehler

    internal class Motorcycle : Vehicle, IVehicle
    {
        public void Move()
        {
            Console.WriteLine("Zwei Räder haben Bodenkontakt.");
        }
    }
}
