using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {        
        var first_info = CultureInfo.InvariantCulture;
        string date1 = Console.ReadLine();
        string date2 = Console.ReadLine();
        var c1 = date1.Split(' ').Last().Length;
        var c2 = date2.Split(' ').Last().Length;
        var dt1 = DateTime.ParseExact(date1, "d M " + new string('y', c1), first_info);
        var dt2 = DateTime.ParseExact(date2, "d M " + new string('y', c2), first_info);
        int fine = 0;
        if (dt1 > dt2)
        {
            if (dt1.Year == dt2.Year)
            {
                if (dt1.Month == dt2.Month)
                    fine = 15 * (int)(dt1 - dt2).TotalDays;
                else if (dt1.Month > dt2.Month)
                    fine = 500 * (dt1.Month - dt2.Month);
            }
            else fine = 10000;
        }
        Console.WriteLine(fine);
    }
}
