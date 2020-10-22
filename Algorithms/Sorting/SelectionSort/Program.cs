using System;

namespace SelectionSort
{
    class Program
    {
        private static void SelectionSort(int[] array) 
        {
            int n = 0;
            int smallestIndex = 0;
            for (int i=0; i < array.Length; i++)
            {
                for (int j = n; j < array.Length; j++)
                {
                    if(array[j] < array[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }
                int temp = array[n];
                array[n] = array[smallestIndex];
                array[smallestIndex] = temp;
                n++;
                smallestIndex = n;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[] {1,6,54,3,6,87,2};
            SelectionSort(arr);
            foreach (int i in arr)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }
    }
}
