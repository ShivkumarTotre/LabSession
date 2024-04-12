using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    public class TerneryOperatorExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Number");
            int iNo = Convert.ToInt32(Console.ReadLine());

            string iResult = (iNo > 0) ? "Positive" : (iNo < 0 ? "Negative" : "Zero");

            Console.WriteLine($"Result is {iResult}");
        }
    }
}
