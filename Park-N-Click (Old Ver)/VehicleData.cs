using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParkingApp
{

    public class VehicleData
    {
        public string typeA { get; set; }
        public string timeInA { get; set; }
        public string plateNumberA { get; set; }
        public int numberA { get; set; }
        public string brandA { get; set; }

        public VehicleData(int number, string type, string timeIn, string plateNumber, string brandA)
        {
            this.numberA = number;
            this.typeA = type;
            this.timeInA = timeIn;
            this.plateNumberA = plateNumber;
            this.brandA = brandA;
        }

        public List<VehicleData> Details;
        public VehicleData()
        {
            Details = new List<VehicleData>();
        }
    }

}