using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ParkingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            string plateNo = "", brand = "", type = "";
            DateTime timeOut;

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

            while (true)
            {
                Console.WriteLine("Enter Plate Number: ");
                plateNo = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(plateNo))
                {
                    Console.WriteLine("Enter Valid Plate Number");
                }
                else break;
            }

            while (true)
            {
                Console.WriteLine("Enter Vehicle Type (1.MotorBike 2.SUV/Van 3.Sedan): ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid choice.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        type = "MotorBike";
                        break;
                    case 2:
                        type = "SUV/Van";
                        break;
                    case 3:
                        type = "Sedan";
                        break;
                    default:
                        Console.WriteLine("Enter valid choice.");
                        continue;
                }
                break;
            }

            Console.WriteLine("Enter Vehicle Brand: ");
            brand = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Enter Time Out (follow this format: month/date/year hour:minute:seconds (AM/PM))");
                try
                {
                    timeOut = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter Valid Date and Time");
                }
            }

            Vehicle vehicle = new Vehicle { PlateNumber = plateNo, Type = type, Brand = brand };

            Calculations calculations = new Calculations
            {
                TimeIn = DateTime.Now,
                TimeOut = timeOut,
                FlagDown = FlagDown(type),
                Rate = Rate(type)
            };

            Console.WriteLine("=====================================================");
            Console.WriteLine("Plate No: {0}", vehicle.PlateNumber);
            Console.WriteLine("Vehicle type: {0}", vehicle.Type);
            Console.WriteLine("Brand: {0}", vehicle.Brand);
            Console.WriteLine("Time in: {0}", calculations.TimeIn);
            Console.WriteLine("Time out: {0}", calculations.TimeOut);
            Console.WriteLine("Hour(s): {0}", calculations.Duration().Hours);
            Console.WriteLine("Total: {0}", calculations.TotalAmount());
            Console.ReadKey();
        }

        static int FlagDown(string type)
        {
            switch (type)
            {
                case "MotorBike": return 20;
                case "SUV/Van": return 40;
                case "Sedan": return 30;
                default: return 0;
            }
        }

        static int Rate(string type)
        {
            switch (type)
            {
                case "MotorBike": return 5;
                case "SUV/Van": return 20;
                case "Sedan": return 15;
                default: return 0;
            }
        }
    }
}
