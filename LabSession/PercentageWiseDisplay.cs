using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    public class PercentageWiseDisplay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write First Subject Marks");
            int iFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write Second Subject Marks");
            int iSecond = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write Third Subject Marks");
            int iThird = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write Fourth Subject Marks");
            int iFourth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write Fifth Subject Marks");
            int iFifth = Convert.ToInt32(Console.ReadLine());

            int iPer1 = iFirst / 100;
            int iPer2 = iSecond / 100;
            int iPer3 = iThird / 100;
            int iPer4 = iFourth / 100;
            int iPer5 = iFifth / 100;

            if(iPer1 > iPer2 && iPer1 > iPer3 && iPer1 > iPer4 && iPer1 > iPer5) 
            {
                Console.WriteLine("First Subject Percentage is Greatest from Others");
            }
            else if (iPer2 > iPer1 && iPer2 > iPer4 && iPer2 > iPer5 && iPer2 > iPer3)
            {
                Console.WriteLine("Second Subject Percentage is Greatest from Others");
            }
            else if (iPer3 > iPer1 && iPer3 > iPer2 && iPer3 > iPer4 && iPer3 > iPer5)
            {
                Console.WriteLine("Third Subject Percentage is Greatest from Others");
            }
            else if (iPer4 > iPer1 && iPer4 > iPer2 && iPer4 > iPer3 && iPer4 > iPer5)
            {
                Console.WriteLine("Fourth Subject Percentage is Greatest from Others");
            }
            else
            {
                Console.WriteLine("Fifth Subject Percentage is Greatest from Others");
            }
        }
    }
}
