﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingSeries
{
    internal class HarmonicNumber
    {
        public static void HarmonicNum()
        {
        
            double s = 1.0;

           Console.Write("Input the number of terms : ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n", n, s);
        }
    
    }
}
