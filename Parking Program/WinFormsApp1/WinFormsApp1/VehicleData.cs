using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{

    public class VehicleData
    {
       // public class Dt 
        //{
            public string typeA { get; set; } 
            public string timeInA { get; set; }
            public string timeOutA { get; set; }
            public int numberA { get; set; }

            public VehicleData(int number, string type, string timeIn, string timeOut)
            { 
                this.numberA = number;
                this.typeA = type;
                this.timeInA = timeIn;
                this.timeOutA = timeOut;
            }
        //}

        /*public string plateNo { get; set; }
        public string brand { get; set; }
        public string type { get; set; }
        public string Amount { get; set; }
        public DateTime timeIn { get; set; }
        public DateTime timeOut { get; set; } */

        public List<VehicleData> Details;
        public VehicleData()
        { 
        Details = new List<VehicleData>();
        Details.Add(new VehicleData(1, "Honda", DateTime.Now.ToString(), DateTime.Now.ToString()));
        }
    }

}
