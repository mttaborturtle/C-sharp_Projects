using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            //Take in a number and use the selection to pick a word in an array
            string[] strArray = { "This ", "is ", "my ", "array ", "of ", "cool ", "strings" };
            Console.WriteLine("Please select a number between 0-6 which will show a word in an array:");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (selection > 6)
                {
                    Console.WriteLine("Please pick a number between 0 and 6. Try again...\n");
                }
            else
                {
                    Console.WriteLine("You have selected the word: " + strArray[selection] + "\n");
                }

            //Take in a number and use the selection to pick a number in an array
            int[] numArrayNew = { 33, 44, 55, 66, 77, 88, 99 };
            Console.WriteLine("Please select a number between 0-6 which will show a number in an array:");
            int selectNum = Convert.ToInt32(Console.ReadLine());
            if (selectNum > 6)
                {
                    Console.WriteLine("Please pick a number between 0 and 6. Try again...\n");
                }
            else
                {
                    Console.WriteLine("You have selected the number: " + numArrayNew[selectNum].ToString() + "\n");
                }


            //Take in a number and use the selection to pick a word in an string
            List<string> strList = new List<string>();
            strList.Add("Hello");
            strList.Add("there,");
            strList.Add("Whatevah");
            strList.Add("ya'");
            strList.Add("name");
            strList.Add("is!!!");
            Console.WriteLine("Please select a number between 0-5 which will show a word in a string:");
            int selectWord = Convert.ToInt32(Console.ReadLine());
            if (selectNum > 5)
                {
                    Console.WriteLine("Please pick a number between 0 and 5. Try again...\n");
                }
            else
                {
                    Console.WriteLine("You have selected the word: '" + strList[selectWord] + "' from the string!\n");
                }

            //Lists can be modified
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);

            //Arrays are for a fixed quantity of items
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            Console.WriteLine(numArray[4]);

            int[] numArray2 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

            Console.WriteLine(numArray[4] + numArray2[3]);

            int[] numArray3 = { 5, 2, 10, 200, 5000, 600, 2300 };
            numArray3[5] = 4500;

            Console.WriteLine(numArray3[5]);


        }
    }
}
