using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
          int maxInt= FindMaximumFromThree.MaximumIntegerNumber(4, 6, 4);
            Console.WriteLine("The maximum value is :" + maxInt);
          double maxFloat = FindMaximumFromThree.MaximumFloatNumber(4.4, 4.9, 5.2);
            Console.WriteLine("The maximum value is :" + maxFloat);

        }
    }
}
