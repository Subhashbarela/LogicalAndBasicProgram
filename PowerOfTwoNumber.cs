using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingSeries
{
    internal class PowerOfTwoNumber
    {
        /* ..............Find the power of two ...............
          public static void PowerOfTwo()
         {
             int no;
             int remainder;
             Console.WriteLine("Enter a no to check");
             no = Convert.ToInt32(Console.ReadLine());
             if (no == 1)
                 Console.Write("It is power of 2.");
             else
             {
                 while (no > 1)
                 {
                     remainder = no % 2;
                     if (remainder != 0)
                         break;
                     no /= 2;
                 }
                 if (no == 1)
                     Console.WriteLine("It is a power of 2");
                 else
                     Console.WriteLine("It is not a power of 2");
             }
         }*/
        //...................display the power of any number...........
        public void Power(double x, int n)
        {
            double Result = 1;
            int n1 = n;

            while (n1 > 0)
            {
                Result = Result * x;
                n1--;
            }
            Console.WriteLine(x + " raised to the power " + n + " = " + Result);
        }


    }
}
