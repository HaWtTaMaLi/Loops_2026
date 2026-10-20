using System;

namespace Loops_2026
{
    internal class Program
    {
        static int start;
        static int end;
        static void Main()
        {
            start = 1;
            end = 10;

            Console.WriteLine($"\nCount form {start} to {end}");

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }

            //bool isGameOver = false;
            //int count = 0;

            //while (isGameOver == false)
            //{
            //    count++;
            //}

        }
    }
}
