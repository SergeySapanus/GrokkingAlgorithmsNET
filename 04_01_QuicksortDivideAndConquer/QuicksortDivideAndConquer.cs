using System;

namespace _04_01_QuicksortDivideAndConquer
{
    public class QuicksortDivideAndConquer
    {
        public static int GetBiggestEvenlySize((int width, int height) size)
        {
            if (size.width == size.height)
                return size.width;

            int smaller;
            int bigger;

            if (size.width > size.height)
            {
                smaller = size.height;
                bigger = size.width;
            }
            else
            {
                smaller = size.width;
                bigger = size.height;
            }


            var rest = bigger % smaller;
            if (rest != 0)
                return GetBiggestEvenlySize((width: smaller, height: rest));

            return smaller;
        }
    }
}
