using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.OOPPartTwo
{
    internal class Plane : Vehicle, IVehicle
    {
        public bool HasJetDrive { get; set; }

        public void Move()
        {
            Console.WriteLine("Die Räder befinden sich in der Luft. ");
        } 
        
        public virtual void Landing() // virtual sagt, dass du diese Methode überschreiben kannst
        {
            Console.WriteLine("Landeanflug beginnt mit Passagieren.");
        }
    }
}
