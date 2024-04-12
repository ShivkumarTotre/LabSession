using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    public class AreaOfTraingle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base");
            int iBase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height");
            int iHeight = Convert.ToInt32(Console.ReadLine());

            float iArea = 0.5F * iBase * iHeight;

            Console.WriteLine($"Area of Traingle is {iArea}");
        }
    }
}
