using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using ParkingProgram;
using System.ComponentModel.Design;

namespace Pprogram
{
    class Proggram
    { 
        static void Main(String[] args)
        {
            bool parkAgain = true;

            while (parkAgain)
            {
                int choice = 0;
                string plateNo = null, brand = null, type = null;
                DateTime timeOut, timeIn = DateTime.Now;

                //TIMEIN
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
                Console.WriteLine("Time In: {0}", timeIn);
                Console.WriteLine();

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
                while (true)
                {
                    Console.WriteLine("Enter Vehicle Brand: ");
                    brand = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(brand))
                    {
                        Console.WriteLine("Enter Valid Vehicle Brand");
                    }
                    else break;
                }
                while (true)
                {
                    Console.WriteLine("Enter Time Out (follow this format: month/date/year hour:minute:seconds (AM/PM))");
                    try
                    {
                        string timeInput = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(timeInput))
                        {
                            throw new FormatException("ERROR: No input.");
                        }
                        if (!timeInput.Contains("/") || !timeInput.Contains(":"))
                        {
                            throw new FormatException("ERROR: Invalid format. Please include both date and time.");
                        }

                        timeOut = DateTime.Parse(timeInput);

                        if (timeOut.Date == timeOut && timeOut.TimeOfDay == TimeSpan.Zero)
                        {
                            throw new FormatException("ERROR: No Date.");
                        }
                        else if (timeOut.Date == DateTime.MinValue.Date)
                        {
                            throw new FormatException("ERROR: No Time.");
                        }
                        else if (timeOut <= timeIn)
                        {
                            Console.WriteLine("ERROR: Invalid Time.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                Vehicle vehicle = new Vehicle { PlateNumber = plateNo, Type = type, Brand = brand };
                Calculations calculations = new Calculations { TimeIn = timeIn, TimeOut = timeOut, FlagDown = FlagDown(type), Rate = Rate(type) };

                Console.WriteLine("=====================================================");
                Console.WriteLine("Plate No: {0}", vehicle.PlateNumber);
                Console.WriteLine("Vehicle type: {0}", vehicle.Type);
                Console.WriteLine("Brand: {0}", vehicle.Brand);
                Console.WriteLine("Time in: {0}", calculations.TimeIn);
                Console.WriteLine("Time out: {0}", calculations.TimeOut);
                Console.WriteLine("Hour(s): {0}", calculations.TotalHours());
                Console.WriteLine("Total: {0}", calculations.TotalAmount());
                Console.WriteLine("=====================================================");
                while (true)
                {
                    Console.WriteLine("Do you want to park again? (yes/no): ");
                    try
                    {
                        string response = Console.ReadLine().ToLower();
                        if (response == "yes" || response == "y")
                        { parkAgain = true; break; }
                        else if (response == "no" || response == "n")
                        { parkAgain = false; break; }
                        else throw new FormatException("Enter Valid Response");
                    }
                    catch (FormatException a)
                    {
                        Console.WriteLine(a.Message);
                    }
                }
            }
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