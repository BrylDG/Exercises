using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace WinFormsApp1;

class Program123
{
    public int totalhours;
    public string plateNo { get; set; }
    public string brand { get; set; }
    public string type {  get; set; }
    public string Amount { get; set; }
    public DateTime timeIn { get; set; }
    public DateTime timeOut { get; set; }

     public string rawr()
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

        Amount = calculations.TotalAmount().ToString();
        return Amount;
    }

    static int FlagDown(string type)
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

    static int Rate(string type)
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
