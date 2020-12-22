using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take in a number and miultiply it by 50. Then print the result
            Console.WriteLine("Give me a number to multiply: ");
            string num1;
            int num2;
            num1 = Console.ReadLine();
            num2 = Convert.ToInt32(num1);
            int addNum = num2 * 50;
            Console.WriteLine("Your number X 50 = " + addNum.ToString());
            Console.WriteLine("Hit return to continue.... ");
            Console.ReadLine();

            //Take in a number and add 25. Then print the result
            Console.WriteLine("Give me a number to add: ");
            string inputAdd;
            int outputAdd;
            inputAdd = Console.ReadLine();
            outputAdd = Convert.ToInt32(inputAdd);
            int addMe = outputAdd + 25;
            Console.WriteLine("Your number + 25 = " + addMe.ToString());
            Console.WriteLine("Hit return to continue.... ");
            Console.ReadLine();

            //Take in a number and divide by 12.5. Then print the result
            Console.WriteLine("Give me a number to divide: ");
            string inputDiv;
            double outputDiv;
            inputDiv = Console.ReadLine();
            outputDiv = Convert.ToInt32(inputDiv);
            double DivMe = outputDiv / 12.5;
            Console.WriteLine("Your number / 12.5 = " + DivMe.ToString());
            Console.WriteLine("Hit return to continue.... ");
            Console.ReadLine();

            //Take in a number. Then print if the result is greater or less than 50
            Console.WriteLine("Give me a number either greater or less than 50: ");
            string inputGreat;
            int outputGreat;
            inputGreat = Console.ReadLine();
            outputGreat = Convert.ToInt32(inputGreat);
            bool GreatMe = outputGreat > 50;
            Console.WriteLine("Is your number greater than 50? " + GreatMe.ToString());
            Console.WriteLine("Hit return to continue.... ");
            Console.ReadLine();

            //Take in a number and divide by 7. Then print the remainder
            Console.WriteLine("Give me a number: ");
            string inputMod;
            double outputMod;
            inputMod = Console.ReadLine();
            outputMod = Convert.ToInt32(inputMod);
            double ModMe = outputMod % 7;
            Console.WriteLine("Your number divided by 7 = " + ModMe.ToString());
            Console.WriteLine("Hit return to continue.... ");
            Console.ReadLine();

        }
    }
}
