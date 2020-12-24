using System;
using System.Collections.Generic;

namespace IterateMe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take in some text and add it to the end of each item before printing to the screen
            List<string> names = new List<string>() { "Bill", "Rachel", "Stella Blue", "Ruthy", "Jessica" };
            Console.WriteLine("Please enter some text of your choosing then hit enter:");
            string textEntered = Console.ReadLine();
            List<string> addedStrings = new List<string>();

            foreach (string name in names)
            {
                addedStrings.Add(name + " " + textEntered);
            }

            foreach (string addedString in addedStrings)
            {
                Console.WriteLine(addedString);
            }
            Console.WriteLine("\nHit enter to continue....");
            Console.ReadLine();

            //Fixed infinite loop. originally I had a-- instead of a++
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine("value : {0}", a);
            }
            Console.WriteLine("\nHit enter to continue....");
            Console.ReadLine();

            //The next two commands use < and <= to decide whether or not to continue
            List<int> nums = new List<int>() { 23, 44, 57, 48, 89, 100, 234 };
            foreach (int num in nums)
            {
                if (num < 90)
                {
                    Console.WriteLine(num);
                }

            }
            Console.WriteLine("\nHit enter to continue....");
            Console.ReadLine();

            foreach (int num in nums)
            {
                if (num <= 48)
                {
                    Console.WriteLine(num);
                }

            }
            Console.WriteLine("\nHit enter to continue....");
            Console.ReadLine();

            //Check to see if user input is in the list then provide the index of the string
            List<string> names2 = new List<string>() { "Bill", "Rachel", "Stella Blue", "Ruthy", "Jessica" };
            Console.WriteLine("Enter a name that you want to search for:");
            string nameSearch = Console.ReadLine();
            int index = names2.FindIndex(a => a.Contains(nameSearch));

            foreach (string name in names2)
            {
                if (name == nameSearch)
                {
                    Console.WriteLine("\nThe name: " + nameSearch + " is located at the index of: [" + index.ToString() + "]");
                }
            }

            if (!names2.Contains(nameSearch))
            {
                Console.WriteLine("The name you entered is not on the list. Try again...");
            }
            Console.WriteLine("\nHit enter to continue....");

            //Check to see if user input is in the list then provide the indexes of the string even if there is more than 1
            List<string> names3 = new List<string>() { "Bob", "Rachel", "Rachel", "Josie", "Ruth", "Jess" };
            Console.WriteLine("\nEnter a name that you want to search for:");
            string nameSearch2 = Console.ReadLine();
            List<int> indices = new List<int>();
            for (int i = 0; i < names3.Count; i++)
                if (names3[i] == nameSearch2)
                {
                    indices.Add(i);
                }

            foreach (string name in names3)
            {
                if (name == nameSearch2)
                {
                    Console.WriteLine("\nThe name: " + nameSearch2 + " is located at the index (or indices) of: [" + string.Join(", ", indices) + "]");
                    break;
                }
            }

            if (!names3.Contains(nameSearch2))
            {
                Console.WriteLine("The name you entered is not on the list. Try again...");
            }
            Console.WriteLine("\nHit enter to continue....");
            Console.ReadLine();

            //Display the list item by item and identify if the item has been shown before or not
            List<string> names4 = new List<string>() { "Bob", "Rachel", "Rachel", "Josie", "Ruth", "Jess" };
            List<string> namesCopy = new List<string>();

            foreach (string name in names4)
            {
                if (namesCopy.Contains(name))
                {
                    Console.WriteLine(name + " has appeared before.");
                }

                else
                {
                    Console.WriteLine(name + " is the first one found");
                }
                namesCopy.Add(name);
            }
            Console.ReadLine();

        }
    }
}
