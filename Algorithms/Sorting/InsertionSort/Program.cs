using System;

namespace InsertionSort
{
    class Program
    {
        private static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                  }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[] {1,6,54,3,6,87,2};
            InsertionSort(arr);
            foreach (int i in arr)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }
    }
}
