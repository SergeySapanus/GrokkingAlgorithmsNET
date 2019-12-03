using System;
using System.Collections.Generic;

namespace GrokkingAlgorithmsNET
{
    public static class Extensions
    {
        public static string AsString(this IEnumerable<int> enumerable)
        {
            return string.Join(", ", enumerable);
        }
    }
}