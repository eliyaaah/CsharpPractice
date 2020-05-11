using System;
using System.Collections;
using System.Collections.Generic;

namespace HashTable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable user = new Hashtable
            {
                {"age", 24},
                {"name", "Illia"},
                {"magic", true}
            };
            user.Add("spell", "ololo"); // O(n)
            Console.WriteLine(user["age"]);

            // Dictionary is using HashTable but allows type-safety
            // For newer .NET version Dictionary is prefered
            // The primary structural difference between them is that Dictionary relies on 
            // chaining (maintaining a list of items for each hash table bucket) to resolve 
            // collisions whereas Hashtable uses rehashing for collision resolution 
            // (when a collision occurs, tries another hash function to map the key to a bucket).
            var users = new Dictionary<string, string>()
            {
                {"eliyah", "Illia"},
                {"tobipuzda", "Oleg"}
            };
            Console.WriteLine(users["eliyah"]);


            // HashSet is an unordered collection of unique elements. (no duplication)
            // no indexing or keys so not the best for retieving value
            var fruits = new HashSet<string>(){"apple", "orange", "banana"};
            foreach (string fr in fruits)
            {
                Console.Write("{0}, ", fr);
            }
        }
    }
}
