using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    public class Swapping2Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int iFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int iSecond = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping");
            Console.WriteLine("First Number is : {0} and Second Number is : {1}", iFirst, iSecond);

            int iTemp = iFirst;

            iFirst = iSecond;
            iSecond = iTemp;

            Console.WriteLine("After Swapping");
            Console.WriteLine("First Number is : {0} and Second Number is : {1}",iFirst,iSecond);
        }
    }
}
