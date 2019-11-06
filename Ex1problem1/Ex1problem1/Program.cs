using System;

namespace Ex1problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            int month;
            int day;
            Console.WriteLine("Please Enter Year:");
            year =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Please Enter Month:");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter day:");
            day = Convert.ToInt32(Console.ReadLine());

            if(year>=1971 && year <= 2019)
            {
                if(month>=1 && month <= 12)
                {
                    if ((day >= 1 && day <= 31) && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)) { }
                    else if ((day >= 1 && day <= 30) && (month == 4 || month == 6 || month == 9 || month == 11)) { }
                    else if ((day >= 1 && day <= 28) && (month == 2)) { }
                    else { Console.WriteLine("Date is invalid"); }
                        }
                else
                {
                    Console.WriteLine("Month is not valid");
                }
                    }
            else
            {
                Console.WriteLine("Year is not valid");
            }

            DateTime value = new DateTime(month);

            Console.WriteLine("Correct Date is:" + day + "-"+value.ToString("MMM") + "-" + year);

                }

            }

        }
    

