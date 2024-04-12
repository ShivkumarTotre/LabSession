using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    public class AreaOfCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Radius");
            int iRadius = Convert.ToInt32(Console.ReadLine());

            float pi = 3.14F;

            double area = pi * iRadius * iRadius;

            Console.WriteLine($"Area of Circle is {area}");
        }
    }
}
