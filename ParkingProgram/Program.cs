using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("                       WELCOME!                      ");
            Console.WriteLine("=====================================================");
            Console.WriteLine("                    PARKING RATE                     ");
            Console.WriteLine("=====================================================");
            Console.WriteLine("Vehicle Type | Flag Down | Additional Amount Per Hour");
            Console.WriteLine(" Motor Bike  |   20.00   |           5.00");
            Console.WriteLine("  SUV/Van    |   40.00   |           20.00");
            Console.WriteLine("   Sedan     |   30.00   |           15.00");
            Console.WriteLine("=====================================================");

            Console.WriteLine("Enter Plate Number: ");
            string plateNo = Console.ReadLine();
            Console.WriteLine("Enter Vehicle Type (1.MotorBike 2.SUV/Van 3.Sedan ): ");
            int choice = Convert.ToInt16(Console.ReadLine());
            int flagDown = 0;
            string brand = "", type = "";

            switch (choice)
            {
                case 1:
                    type = "MotorBike";
                    flagDown = 1;
                    break;
                case 2:
                    type = "SUV/Van";
                    flagDown = 2;
                    break;
                case 3:
                    type = "Sedan";
                    flagDown = 3;
                    break;
                default:
                    Console.WriteLine("Enter valid choice.");
                    return;
            }

            Console.WriteLine("Enter Vehicle Brand: ");
            brand = Console.ReadLine();

            Console.WriteLine("Enter Time Out (follow this format: month/date/year hour:minute:seconds (AM/PM))");
            DateTime timeOut = DateTime.Parse(Console.ReadLine());

            Vehicle vehicle = new Vehicle { PlateNumber = plateNo, Type = type, Brand = brand };
            Calculations calculations = new Calculations
            {
                TimeIn = DateTime.Now,
                TimeOut = timeOut,
                FlagDown = FlagDown(type),
                Rate = Rate(type)
            };

            Console.WriteLine("=====================================================");
            Console.WriteLine($"Plate No: {vehicle.PlateNumber}");
            Console.WriteLine($"Vehicle type: {vehicle.Type}");
            Console.WriteLine($"Brand: {vehicle.Brand}");
            Console.WriteLine($"Time in: {calculations.TimeIn}");
            Console.WriteLine($"Time out: {calculations.TimeOut}");
            Console.WriteLine($"Hour(s): {calculations.Duration().Hours}");
            Console.WriteLine($"Total: {calculations.TotalAmount()}");

            Console.ReadKey();
        }
        static int FlagDown(string type)
        {
            switch (type) 
            {
                case "MotorBike": return 20; break;
                case "SUV/Van": return 40; break;
                case "Sedan": return 30; break;
                default: return 0; break;
            }
        }
        private static int Rate(string type)
        {
            switch (type)
            {
                case "MotorBike": return 5; break;
                case "SUV/Van": return 20; break;
                case "Sedan": return 15; break;
                default: return 0; break;
            }
        }
    }
}