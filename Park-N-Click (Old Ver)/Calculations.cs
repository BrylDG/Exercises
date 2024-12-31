using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
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
            int th = total.Hours + (total.Days * 24);
            if (total.Minutes > 30)
            {
                th++;
            }
            int totalAmount = th * Rate + FlagDown;
            return totalAmount;
        }
        public int TotalHours()
        {
            TimeSpan total = Duration();
            int totalHours = total.Hours + (total.Days * 24);
            if (total.Minutes >= 30)
            {
                totalHours++;
            }
            return totalHours;
        }
    }
}
