using System;

namespace CarInsuranceChecker
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int old = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI? Please type true or false:");
            string DUI = Console.ReadLine();
            bool trouble = Convert.ToBoolean(DUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int law = Convert.ToInt32(tickets);

            Console.WriteLine("Are you qualified?");
            Console.WriteLine(old > 15 && trouble == false && law <= 3);
        }
    }
}
