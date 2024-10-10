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
            names.Add("Kalle");
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
            Console.WriteLine("\nThe list currenctly contains:");
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
            Console.WriteLine("\nPlease enter a name to search for");
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

        internal static void MenuSwitch() //made a switchmenu to navigate through the differenct functions of handling the list
        {
            CreateList();
            Console.WriteLine("Welcome to the NameList program! What would you like to do today?");
            while (true)
            {
                Console.WriteLine("\n1. Print the list\n" +
                    "2. Sort the list\n" +
                    "3. Add a name to the list\n" +
                    "4. Search for a name in the list\n" +
                    "5. Remove a name from the list\n" +
                    "Escape. Close program.");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        PrintList();
                        break;

                    case ConsoleKey.D2:
                        SortList();
                        break;

                    case ConsoleKey.D3:
                        AddName();
                        break;

                    case ConsoleKey.D4:
                        SearchName();
                        break;

                    case ConsoleKey.D5:
                        RemoveName();
                        break;

                    case ConsoleKey.Escape:
                        return;

                    default:
                        Console.WriteLine("This input was not correct. Please try again");
                        break;
                }
            }

        }

        private static void RemoveName() //added a method to remove names.
        {
            Console.WriteLine("\nPlease enter a name that you would like to remove");
            string removedName = Console.ReadLine();
            if (names.Contains(removedName))
            {
                Console.WriteLine($"{removedName} has been removed");
                names.Remove(removedName);
            }
            else
            {
                Console.WriteLine($"{removedName}not be found in the list, it has not been removed.");
            }
        }
    }
}