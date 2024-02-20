using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParkingProgram
{
    internal class Calculations
    {
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public int FlagDown { get; set; }
        public int Rate { get; set; }

        public TimeSpan Duration()
        {
            return TimeOut.Subtract(TimeIn);
        }
        public int TotalAmount()
        {
            TimeSpan total = Duration();
            int totalHours = total.Hours;
            if (total.Minutes >= 30)
            {
                totalHours++;
            }
            int totalAmount = totalHours * Rate + FlagDown;
            return totalAmount;
        }
        public int TotalHours()
        {
            TimeSpan total = Duration();
            int totalHours = total.Hours;
            if (total.Minutes >= 30)
            {
                totalHours++;
            }
            return totalHours;
        }
    }
}

