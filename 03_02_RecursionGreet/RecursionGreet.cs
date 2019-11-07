using System;

namespace _03_02_RecursionGreet
{
    public class RecursionGreet
    {
        public static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
            Greet2(name);
            Console.WriteLine("Getting ready to say bye...");
            Bye();
        }

        private static void Bye()
        {
            Console.WriteLine("Ok, bye!");
        }

        private static void Greet2(string name)
        {
            Console.WriteLine($"How are you, {name}?");
        }
    }
}
