using System;

namespace DoSomeMaths3
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths c = new Maths();

            Console.WriteLine("Enter the first number to multiply: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number to multiply(You may leave this blank): ");
            string num2 = Console.ReadLine();
            
            if (num2 == "")
            {
                int Multed = c.AddMe(num1);
                Console.WriteLine("Number 1 X number 2(10 if blank) = {0}", Multed);
            }
            else
            {
                int changed = Convert.ToInt32(num2);
                int Multed = c.AddMe(num1, changed);
                Console.WriteLine("Number 1 X number 2(10 if blank) = {0}", Multed);
            }
            Console.ReadLine();
        }
    }
}
