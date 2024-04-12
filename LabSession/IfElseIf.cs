using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    public class IfElseIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write First Number");
            int iNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write Second Number");
            int iNo2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write Third Number");
            int iNo3 = Convert.ToInt32(Console.ReadLine());

            if(iNo > iNo2 && iNo > iNo3)
            {
                Console.WriteLine("First Number is Big from All");
            }
            else if (iNo2 > iNo3 && iNo2 > iNo) 
            {
                Console.WriteLine("Second Number is Big From All");
            }
            else 
            {
                Console.WriteLine("Third Number is Big From All");
            }
        }
    }
}
