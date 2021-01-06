using System;

namespace AskYourAge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("What was your age on Jan 1st of this year(2021)?");
                var age = Convert.ToInt32(Console.ReadLine()); //User input their age an assign it to a var age
                if (age == 0 || age < 0) //Check to see if the user enter a zero OR a negative number
                {
                    throw new BadNumberException();
                }
                int birthYear = 2020 - age; //Get their birthyear by subtracting their age from the current year(Change this as 2021 continues)
                Console.WriteLine("You were born in {0}", birthYear); //Print their birthyear
                Console.ReadLine();
            }
            catch (BadNumberException)
            {
                Console.WriteLine("Negaitive numbers and 0 are not allowed. Please enter a number above 0.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number.");
                Console.ReadLine();
            }
            
        }
    }
}
