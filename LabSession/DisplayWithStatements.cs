using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession
{
    public class DisplayWithStatements
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 50; i++)
            {
                if(i % 3 == 0  && i % 5 == 0)
                {
                    Console.WriteLine(i+" Welcome to Pune");
                }
                else if(i % 3 == 0) 
                {
                    Console.WriteLine(i+" Pune");
                }
                else if(i % 5 == 0) 
                {
                    Console.WriteLine(i +" Welcome");
                }
            }
        }
    }
}
