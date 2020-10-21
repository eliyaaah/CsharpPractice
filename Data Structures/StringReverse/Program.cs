using System;

namespace StringReverse
{
    class Program
    {
        public static string StringReverseRecursive(string str)
        {
            if (str.Length > 0)
                return StringReverseRecursive(str.Substring(1)) + str[0];
            else
                return str;
        }
        public static string stringReverseString3b(string str) {  
            char[] chars = new char[str.Length];  
            for (int i = 0, j = str.Length - 1; i <= j; i++, j--) {  
                chars[i] = str[j];  
                chars[j] = str[i];  
            }  
            return new string(chars);  
        }  
        static void Main(string[] args)
        {
            Console.WriteLine(stringReverseString3b("Hello World!"));
            Console.WriteLine(StringReverseRecursive("World hold on"));
        }
    }
}
