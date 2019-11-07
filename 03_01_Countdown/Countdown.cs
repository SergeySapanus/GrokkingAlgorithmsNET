using System;

namespace _03_01_Countdown
{
    public class Countdown
    {
        public static void CountdownMethod(int i)
        {
            Console.WriteLine(i);

            if (i <= 0)
                return;

            CountdownMethod(--i);
        }
    }
}
