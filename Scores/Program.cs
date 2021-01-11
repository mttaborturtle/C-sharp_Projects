using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string date = DateTime.Today.ToShortDateString();
            string uname = Console.ReadLine();
            string msg = $"\nWelcome back {uname}. Today is {date}";
            Console.WriteLine(msg);

            string path = @"C:\Users\mttab\source\repos\Tech_Academy_Basic_C-sharp_Projects\Scores\StudentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores:");
            foreach (string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            double shrter = Math.Round(avgScore, 2);
            Console.WriteLine("\n\nThere are a total of " + lines.Length + " student scores. The average score is: " + shrter);



            Console.WriteLine("\n\nHit enter to continue...");
            Console.ReadLine();
        }
    }
}
