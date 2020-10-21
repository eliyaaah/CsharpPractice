using System;
using System.Collections.Generic;
using System.Linq;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = {'a','x','c','d'};
            char[] array2 = {'x','y','z','i'};

            bool containsCommonItems(char[] arr1, char[] arr2)
            {
                var list = new List<char>(array1);

                foreach (char x in arr2)
                {
                    if (list.Contains(x))
                    {
                        Console.WriteLine("true");
                        return true;
                    }
                }
                Console.WriteLine("false");
                return false;
            }
        
            containsCommonItems(array1, array2);
        }
    }
}
 