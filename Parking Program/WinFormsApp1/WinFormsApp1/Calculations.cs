using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1;

internal class Calculations
{
    public DateTime TimeIn { get; set; }
    public DateTime TimeOut { get; set; }
    public int FlagDown { get; set; }
    public int Rate { get; set; }
    public int totalHours { get; set; }
    public int tAmount { get; set; }

    public TimeSpan Duration()
    {
        return TimeOut.Subtract(TimeIn);
    }

    public int TotalAmount()
    {
        TimeSpan total = Duration();
        int th = total.Hours;
        if (total.Minutes > 30)
        {
            th++;
        }
        int totalAmount = th * Rate + FlagDown;
        totalHours = th;
        tAmount = totalAmount;
        return totalAmount;
    }
}
