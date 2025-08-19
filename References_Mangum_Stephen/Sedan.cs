using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Mangum_Stephen
{
    internal class Sedan : IAutomobile // The Sedan class implements the IAutomobile interface and represents a sedan with specific properties and behaviors.
    {
        public double Speed { get; private set; } // Speed of the sedan

        public int Wheels { get; private set; } // Number of wheels on the sedan

        public string LicensePlate { get; private set; } // License plate number of the sedan

        public Sedan(double speed) // Constructor for the Sedan class that initializes the speed and sets the number of wheels to 4 and a default license plate.
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-06";
        }

        public void Stringify() // Method to output the sedan's details in a formatted string.
        {
    Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels with a License Plate # of {LicensePlate}.");
        }
        public void IncreaseSpeed() // Method to increase the speed of the sedan by 5 units.
        {
    Speed += 5;
}

public void DecreaseSpeed() // Method to decrease the speed of the sedan by 5 units.
        {
    Speed -= 5;
}
    }
}
