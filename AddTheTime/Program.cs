using System;

namespace AddTheTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The date and time right now is: " + DateTime.Now); //Print the current time

            //Take in a number to work with as a double
            Console.WriteLine("Give me a number. Any number at all:");
            double numb1 = Convert.ToDouble(Console.ReadLine());

            //Set a variable of the time right now
            DateTime dateValue = DateTime.Now;

            //Add the number input to the time right now and print out what time and day it will be in that many hours
            Console.WriteLine("It will be exactly " + dateValue.AddHours(numb1) + " in " + numb1 + " hours, which is the number you entered.");
            Console.ReadLine();
        }
    }
}
