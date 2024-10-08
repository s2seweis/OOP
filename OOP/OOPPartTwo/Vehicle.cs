using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOPPartTwo
{
    // Keyword abstract sorgt dafür dass du von Vehicle keine Objekt Instanz erstellen kannst,
    // new Vehicle funktioniert nicht
    // Was bedeutet Vererbung? Base Klasse vererbt alle ihre Felder und Methoden an die abgeleitete Klasse. 
    abstract class Vehicle
    {

        public float Speed { get; set; }
        public float Acceleration { get; set; }
        public float BreakSpeed { get; set; }
        public int DoorCount { get; set; }

        public void LogInformation()
        {
            Console.WriteLine("Das Fahrzeug fährt mit " + Speed + "km/h.");
        }

    }
}
