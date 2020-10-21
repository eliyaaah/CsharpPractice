using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[] {1,6,54,3,6,87,2};
            Array.Sort(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
