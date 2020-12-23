using System;
using System.Text;


namespace AllAboutStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "This ";
            string word2 = "is ";
            string word3 = "a ";
            string word4 = "sentence!!";
            Console.WriteLine(word1 + word2 + word3 + word4);

            Console.WriteLine("Write some letters:");
            string letters = Console.ReadLine();
            string shout = letters.ToUpper();
            Console.WriteLine("\n" + shout + "!!!!!!!!");

            StringBuilder prgraph = new StringBuilder();
            prgraph.Append("\nI really love dogs. ");
            prgraph.Append("They simply are the best friend a person could have.\n");
            prgraph.Append("My dog is a Labradoodle. Her name is Stella Blue. ");
            prgraph.Append("She loves to cuddle\nand play fetch. She also can jump over 5 feet in the air ");
            prgraph.Append("to try to grab\na stick in my hand. She really is the best dog ever!!! ");

            Console.WriteLine(prgraph);
        }
    }
}
