using System;
using System.IO;

namespace FileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number that you would like to save to the file: number.txt:");
            string number1 = Console.ReadLine(); //Take in a number and save it to a string variable

            //Write the variable to a file named number.txt
            File.WriteAllText(@"C:\Users\mttab\Logs\number.txt", number1);
            
            //Read the file that you just added the number to
            string numbFile = File.ReadAllText(@"C:\Users\mttab\Logs\number.txt");
            
            //Write the number contained in the file to the console
            Console.WriteLine("The number read back from the file is: {0}", numbFile);
            Console.ReadLine();
        }
    }
}
