using System;

namespace _03_03_RecursionFactorial
{
    public class RecursionFactorial
    {
        public static int Factorial(int num)
        {
            if (num <= 1)
                return num;

            return num * Factorial(--num);
        }
    }
}
