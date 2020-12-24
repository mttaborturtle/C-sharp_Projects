using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take in a number and miultiply it by 50. Then print the result
            Console.WriteLine("I have a list if numbers. Give me a number to multiply them by: ");
            List<int> numbers = new List<int>() { 10, 14, 23, 44, 123, 483, 657 };
            
            try
            {
                int inputNum = Convert.ToInt32(Console.ReadLine());
                foreach (int num in numbers)
                {
                    int divNum = num / inputNum;
                    Console.WriteLine("The number " + num + " divided by your number " + inputNum + " = " + divNum.ToString());
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number. Please try again.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can not divide by zero silly! Please try again.");
            }
            finally
            {
                Console.WriteLine("\nMath complete and is now outside of try block. Hit return to continue...");
                Console.ReadLine();
            }

        }
    }
}
