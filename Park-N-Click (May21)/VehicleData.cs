using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkNClick
{
    internal class VehicleData
    {
        public string type { get; set; }
        public string brand { get; set; }
        public string plateNo { get; set; }
        public string timeIn { get; set; }
        public VehicleData(string type, string brand, string plateNo, string timeIn)
        {
            this.type = type;
            this.brand = brand;
            this.plateNo = plateNo;
            this.timeIn = timeIn;
        }
    }
}
