using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOPPartTwo
{
    // Erstellt ein layout für eine andere Klasse
    // Erstellt keinen Code sondern eine Struktur
    // Es lässt keinen Spielraum zu, wenn eine Methode/Felder im Interface definiert wird, muss man diese auch mit implementieren
    interface IVehicle
    {
        public void Move();
        //Kein Rückgabewert
        
        //public void Signal();
        //Wenn nicht importiert in die Klassen, dann kommt es zu einer Fehlermeldung
    }
}
