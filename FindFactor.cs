using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingSeries
{
    internal class FindFactor
    {
        public static void Factor()
        {
            Console.WriteLine("Enter the number to find factor : ");
            int num=Convert.ToInt32(Console.ReadLine());
            int fact;
            for(fact=1;fact<num;fact++)
            {
                if(num%fact == 0)
                {
                    Console.Write(fact + ",");
                }
            }
        }
    }
}
