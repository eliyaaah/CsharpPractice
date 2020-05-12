using System;
using System.Collections.Generic;

namespace HashTable2
{
    class Program
    {
        static int FindFirstRecurring(int[] arr)
        {
            var dict = new Dictionary<int, bool>();
            int length = arr.Length;
            
            for (int i=0; i < length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    return arr[i];
                }
                else
                {
                    dict.Add(arr[i], true);
                }
            }

            return 0;
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] {2,5,1,2,3,5,1,2,4};
            int[] arr2 = new int[] {2,1,1,2,3,5,1,2,4};
            int[] arr3 = new int[] {2,3,4,5};
            
            Console.WriteLine(FindFirstRecurring(arr1));
        }
    }
}
