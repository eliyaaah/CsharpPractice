using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        private static void BubbleSort(int[] array)
        {
            bool finish = false;
            while(!finish)
            {
                finish = true;
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (array[i+1]<array[i])
                    {
                        int temp = array[i+1];
                        array[i+1] = array[i];
                        array[i] = temp;
                        finish = false; 
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[] {1,6,54,3,6,87,2};
            BubbleSort(arr);
            foreach (int i in arr)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }
    }
}
