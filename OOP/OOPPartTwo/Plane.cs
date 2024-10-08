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
    }
}
