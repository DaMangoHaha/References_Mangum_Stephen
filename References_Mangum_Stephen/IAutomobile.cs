using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Mangum_Stephen
{
    internal interface IAutomobile
    {


        public double Speed { get; }

        public int Wheels {  get; }
         
        public string LicensePlate { get; }

        public void Stringify();
    }
}
