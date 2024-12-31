using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ParkingApp
{

    public class Program123
    {
        public int Hours { get; set; }
        public string plateNo { get; set; }
        public string brand { get; set; }
        public string type { get; set; }
        public int Amount { get; set; }
        public DateTime timeIn { get; set; }
        public DateTime timeOut { get; set; }

        public int TotalAmount()
        {
            Calculations calculations = new Calculations
            {
                TimeIn = timeIn,
                TimeOut = timeOut,
                FlagDown = FlagDown(type),
                Rate = Rate(type),
            };

            Vehicle vehicle = new Vehicle
            {
                PlateNumber = plateNo,
                Type = type,
                Brand = brand
            };

            VehicleData VD = new VehicleData();
            {
                type = type;
                timeIn = timeIn;
                timeOut = timeOut;
            };

            Amount = calculations.TotalAmount();
            return Amount;
        }
        public int TotalHours()
        {
            Calculations calculations = new Calculations
            {
                TimeIn = timeIn,
                TimeOut = timeOut,
                FlagDown = FlagDown(type),
                Rate = Rate(type),
            };

            Vehicle vehicle = new Vehicle
            {
                PlateNumber = plateNo,
                Type = type,
                Brand = brand
            };

            VehicleData VD = new VehicleData();
            {
                type = type;
                timeIn = timeIn;
                timeOut = timeOut;
            };

            Hours = calculations.TotalHours();
            return Hours;
        }

        public static int FlagDown(string type)
        {
            switch (type)
            {
                case "MotorBike": return 20;
                case "SUV": return 40;
                case "Van": return 40;
                case "Sedan": return 30;
                default: return 0;
            }
        }

        public static int Rate(string type)
        {
            switch (type)
            {
                case "MotorBike": return 5;
                case "SUV": return 20;
                case "Van": return 20;
                case "Sedan": return 15;
                default: return 0;
            }
        }
    }
}