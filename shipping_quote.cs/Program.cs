using System;

namespace shipping_quote.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nPlease enter package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());
            
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("\nPlease enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Please enter package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Please enter package length:");
                int length = Convert.ToInt32(Console.ReadLine());
                
                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Package too big to be shipped by Package Express.");
                }
                else
                {
                    int quote = ((height * width * length) * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this paackage is: $" + quote.ToString() + ".00\nThank you!");
                }
            }
            

        }
    }
}
