using System;

namespace Ex1problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, rev = 0, tem, t;
            Console.WriteLine("Enter number:");
            number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                tem = number % 10;
                rev = rev * 10 + tem;
                number /= 10;
            }
            Console.WriteLine(rev);
            if (2 < rev - 1)
            {
                if (rev % 2 == 0)
                {
                    Console.WriteLine("not prime");
                }
                else { Console.WriteLine("prime"); }
            }
                if (rev == 2)
                {
                    Console.WriteLine("prime");
                }
            }
            

            
        }
    }

