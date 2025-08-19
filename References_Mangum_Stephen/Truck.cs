using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Mangum_Stephen
{
    internal class Truck : IAutomobile // The Truck class implements the IAutomobile interface and represents a truck with specific properties and behaviors.
    {
        public double Speed { get; private set; } // Speed of truck

        public int Wheels { get; private set; } // Number of wheels on the truck

        public string LicensePlate { get; private set; } // License plate number of the truck

        public double weight { get; } // Weight of the truck, used to determine the number of wheels

        public Truck(double speedParam, double weightParam, string licenseNum) // Constructor for the Truck class that initializes speed, weight, and license plate number.
        {
            Speed = speedParam;
            weight = weightParam;
            LicensePlate = licenseNum;

            if(weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }


        public void Stringify() // Method to output the truck's details in a formatted string.
        {
            Console.WriteLine($"The truck is traveling at a speed of {Speed} on {Wheels} wheels with a License Plate # of {LicensePlate}");
        }
        public void IncreaseSpeed() // Method to increase the speed of the truck by 5 units.
        {
            Speed += 5;
        }

        public void DecreaseSpeed() // Method to decrease the speed of the truck by 5 units.
        {
            Speed -= 5;
        }
    }
}
