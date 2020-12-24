using System;

namespace DoWhile
{
    class Program
    {
        static void Main()
        {
            int a = 0;
            while (a < 10)
            {
                Console.WriteLine("How man times?: " + a);
                a++;
            }

            Console.WriteLine("\nGive me a number less than 20 to count up to:");
            int endNum = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            do
            {
                Console.WriteLine("Number = {0}", i);
                i++;

                if (i > endNum)
                    break;

            } while (i < 20);
        }
    }
}
