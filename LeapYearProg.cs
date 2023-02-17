using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingSeries
{
    internal class LeapYearProg
    {
        public static void LeapYear()
        {
          
            
                {
                    Console.WriteLine("Enter  The Year : ");
                    int Year = int.Parse(Console.ReadLine());
                    if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                    {
                        Console.WriteLine("{0} is a Leap Year.", Year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a Leap Year.", Year);
                    }
                   
                }
                //.....................................Second Program using nested if concept....................

              /*  int year;
                Console.WriteLine("Enter any year: ");
                year = Convert.ToInt32(Console.ReadLine());
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                        {
                            Console.WriteLine("The year given is a leap year");
                        }
                        else
                        {
                            Console.WriteLine("The year given is not a leap year");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This year given is a leap year");
                    }
                }
                else
                {
                    Console.WriteLine("This year is not a leap year");
                }
                Console.ReadLine();
            }*/
        }
    }
    
}
