using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            int destination, direction, start;

            for (int x = 1; x <= 5; x++)
            {
                //condition will be true on odd-num runs
                if (!(x % 2 == 0))
                {
                    direction = 1;
                    start = 1;
                    destination = 11; //11 instead of 10 due to for-loop flow

                } else {
                    direction = -1;
                    start = 10;
                    destination = 0; //0 instead of 1 due to for-loop flow
                }

                //run for loop with above-decided numbers
                for (int i = start; i!= destination; i += direction)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
