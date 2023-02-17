using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingSeries
{
    internal class FlipCoinProgram
    {
        public static void FlipCoin()
        {
            int head = 0;
            int tail = 0;
            Console.WriteLine("Please insert the value You Want TO Play The Geme :");
            int num = Convert.ToInt32(Console.ReadLine());
            Random radom = new Random();
            for (int i = 0; i < num; i++)
            {
                int check_value = radom.Next(2);
                if (check_value == 0)
                {
                    head += 1;
                }
                else
                {
                    tail += 1;
                }
            }
            Console.WriteLine("Point Of Head is : " + head);
            Console.WriteLine("Point Of Tail : " + tail);
        }
        /*...........................Second Program.......................
        public string name;
        public void flip()
        {
            info();
            GetName();
            Random();
        }
        public void info()
        {
            Console.WriteLine("Welcome to my Coin Toss Game!");
            Console.WriteLine();
            Console.WriteLine("My program will flip a coin for you and then you will try to guess which side the coin lands on. You will have 20 tries.");
            Console.WriteLine();
            Console.WriteLine("If you guess correctly 6 or more times, you win.");
            Console.WriteLine("If you guess correctly 5 times, you play again.");
            Console.WriteLine("If you guess correctly less than 5 times, you lose.");
            Console.WriteLine();
        }
        void GetName()
        {
            Console.WriteLine("Please input your name:");
            name = Console.ReadLine();
        }
        public void Random()
        {
            int rand;
            int choice;
            int success = 0;
            Random randoms = new Random();

            for (int i = 1; i <= 10; i++)
            {



                Console.WriteLine(name + " : 0 is for Heads and 1 is for Tails.");
                Console.WriteLine("Please guess Heads or Tails :..");
                choice = int.Parse(Console.ReadLine());
                rand = randoms.Next(0, 2);


                if (rand == choice)
                {

                    Console.WriteLine(" You got it, " + name + "!!!");
                    Console.WriteLine(" Result  is : " + rand + "Contiue.. ");
                    success = success + 1;
                }
                else
                {
                    Console.WriteLine(" Sorry, " + name + "!!!");
                    Console.WriteLine(" Rand is " + rand + "Please try....");
                }
                Console.WriteLine(" You are in part " + i + " of the loop.");
            }
            if (success >= 6)
            {
                Console.WriteLine(" Congratz!!! " + name + ", you won! You had " + success + " successes.");
                Console.ReadLine();
            }
            if (success == 5)
            {
                Console.WriteLine(" Sorry... " + name + ", please play again!");
                Console.ReadLine();
                Random();
            }
            if (success < 5)
            {
                Console.WriteLine(" Sorry!!! " + name + ", you lost!");
                Console.ReadLine();
            }
        
        }*/
    }
    
}
