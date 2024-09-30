using code_revision_assignment;
using System;
using System.Collections.Generic;

namespace code_revision_assignment
{
    internal class NameList
    {
        static List<string> names = new List<string>();
        

        internal static void CreateList() //created a function to add names into the list, in order to have a few names sto start of the list before we can manage it.
        {
            names.Add("Anna");
            names.Add("John");
            names.Add("Alice");
            names.Add("Boris");
        }
        
        internal static void AddName() //added method in order to add more names to the list
        {
            Console.WriteLine("Please enter the name you would like to add");
            names.Add(Console.ReadLine());

        }

        internal static void PrintList() //added a printfunction to the list to make decrease duplicates in code
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        internal static void SortList() //made a sortfunction
        {
            names.Sort(); //Sor the names alphabetically
            Console.WriteLine("\nSorted lists:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        internal static void SearchName() //made a function to search for name
        {
            Console.WriteLine("\nEnter name to search:");
            string searchName = Console.ReadLine();
            if (names.Contains(searchName))
            {
                Console.WriteLine($"{searchName} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list.");
            }
        }
    }
}