using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    public class CalculatePercentage
    {
        static void Main(string[] args)
        {
            int iFirst = 98;
            int iSecond = 89;
            int iThird = 88;
            int iFourth = 97;
            int iFifth = 94;

            double iTotal = (iFirst + iSecond + iThird + iFourth + iFifth) / 5;

            Console.WriteLine($"Percentage of Five Subject is {iTotal}");
        }
    }
}
