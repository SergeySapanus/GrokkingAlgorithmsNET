using System;

namespace _03_01_RecursionCountdown
{
    public class RecursionCountdown
    {
        public static void Countdown(int i)
        {
            Console.WriteLine(i);

            if (i <= 0)
                return;

            Countdown(--i);
        }
    }
}
