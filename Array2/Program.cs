using System;

namespace Array2
{
    class Program
    {
        public static int[] mergeArrays(int[] arr1, int[] arr2)
        {
            int length1 = arr1.Length;
            int length2 = arr2.Length;
            int length3 = length1 + length2;
            int[] arr3 = new int[length3];

            int i = 0, j = 0, k = 0;

            // Traverse both array 
            while (i < length1 && j < length2)
            {
                // Check if current element  
                // of first array is smaller 
                // than current element 
                // of second array. If yes,  
                // store first array element  
                // and increment first array 
                // index. Otherwise do same  
                // with second array 
                if (arr1[i] < arr2[j])
                    arr3[k++] = arr1[i++];
                else
                    arr3[k++] = arr2[j++];
            }

            // Store remaining  
            // elements of first array 
            while (i < length1)
                arr3[k++] = arr1[i++];

            // Store remaining elements 
            // of second array 
            while (j < length2)
                arr3[k++] = arr2[j++];

            return arr3;
        }

        // Driver code 
        public static void Main()
        {
            int[] arr1 = { 1, 3, 5, 7 };
            int[] arr2 = { 2, 4, 6, 8, 9, 10 };

            int[] arr3 = mergeArrays(arr1, arr2);

            foreach (int i in arr3)
            {
                Console.Write(i + ", ");
            }
        }
    }
}
