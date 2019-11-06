using System;

namespace prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            int diag1=0, diag2=0;
            int[,] arr = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                     
                    if (i == j)
                        diag1 += arr[i, j];

                    
                    if (i == 4 - j - 1)
                        diag2 += arr[i, j];
                }
            }
            Console.WriteLine("answer is: "+ (diag1+diag2));
        }
    }
}
