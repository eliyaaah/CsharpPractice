using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewQuestion
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Check if two arrays have any common items
            char[] array1 = {'a', 'a', 'c', 'x'};
            char[] array2 = {'f', 'y', 'u'};

            // O(a+b) Time complexity solution
            // Can we assume two parameters? Can we assume arrays only for inputs?

            bool containsCommonItem(char[] arr1, char[] arr2)
            {
                var list = new List<char>(arr1);
            
                foreach (char x in arr2)
                {
                    if(list.Contains(x))
                    {
                        Console.WriteLine("True");
                        return true;
                    }
                }
                Console.WriteLine("False");
                return false;
            }

            // Trying to simplify
            bool containsCommonItem2(char[] arr1, char[] arr2)
            {
                var list = new List<char>(arr1);
                var list2 = new List<char>(arr2);
            
                bool hasMatch = list.Intersect(list2).Any();
                Console.WriteLine(hasMatch);
                return hasMatch;
            }

            containsCommonItem(array1, array2);
            containsCommonItem2(array1, array2);





            //2. Check if array has pair of integers with sum of 9

            bool hasPairWithSum(int[] arr, int sum)
            {
                // Creating empty list to add difference of array item and 8
                var listOfNums = new List<int>();

                foreach (int i in arr)
                {
                    // If list of differences contains the element it means that they would add up to the sum we're looking for
                    if(listOfNums.Contains(i))
                    {
                        Console.WriteLine("Found");
                        return true;
                    }
                    // If list of differences doesn't contain the element, subtract from sum and add another difference
                    else
                    {
                        listOfNums.Add(sum-i);
                    }
                }

                Console.WriteLine("Not found");
                return false;
            }

            hasPairWithSum(new int[] {6,4,3,2,1,7}, 9);

        }
    }
}
