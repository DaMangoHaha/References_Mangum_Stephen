using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Mangum_Stephen
{
    internal interface IAutomobile // The IAutomobile interface defines the properties and methods that any automobile class must implement.
    {


        public double Speed { get; } // Speed of the automobile

        public int Wheels {  get; } // Number of wheels on the automobile

        public string LicensePlate { get; } // License plate number of the automobile

        public void Stringify(); // Method to output the automobile's details in a formatted string.
    }
}
