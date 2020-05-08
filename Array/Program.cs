using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function to reverse string
            string ReverseString(string str)
            {
                char[] arr = str.ToCharArray();
                System.Array.Reverse(arr);
                string strReverse = new string(arr);
                return strReverse;
            }

            Console.WriteLine("Enter your string:");
            string strToReverse = Console.ReadLine();
            Console.WriteLine(ReverseString(strToReverse));

        }
    }
}
