using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() 
            { 
                { "name", "Krista" },
                { "age", "42" } 
            });
            myFamily.Add("mom", new Dictionary<string, string>()
            {
                { "name", "Debra" },
                { "age", "49" }
            });
            myFamily.Add("brother", new Dictionary<string, string>()
            {
                { "name", "Joey" },
                { "age", "26" }
            });
            myFamily.Add("dad", new Dictionary<string, string>()
            {
                { "name", "Mike" },
                { "age", "58" }
            });


            foreach (var family in myFamily)
            {
                Console.WriteLine($"{family.Value["name"]} is my {family.Key} and is {family.Value["age"]} years old.\n");
            }
        }
    }
}
