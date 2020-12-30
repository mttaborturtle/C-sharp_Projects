using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the Current day of the week. Be sure to capitalize:");
                string NewDay = Console.ReadLine();

                Day day = (Day)Enum.Parse(typeof(Day), NewDay);

                Console.WriteLine(day);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Please enter an actual day of the week and capitalize the first letter. Try again...");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week and capitalize the first letter. Try again...");
            }
            
        }
    }
}