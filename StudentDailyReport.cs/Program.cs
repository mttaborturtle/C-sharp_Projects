using System;

namespace StudentDailyReport.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.");
            
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine("What course are you currently on?");
            string courseName = Console.ReadLine();
            
            Console.WriteLine("What page number?");
            string pNum;
            int pageNum;
            pNum = Console.ReadLine();
            pageNum = Convert.ToInt32(pNum);
            
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'");
            string needHelp = Console.ReadLine();
            
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveEx = Console.ReadLine();
            
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedBack = Console.ReadLine();
            
            Console.WriteLine("How many hours did you study today?");
            string hrNum;
            int hourNum;
            hrNum = Console.ReadLine();
            hourNum = Convert.ToInt32(pNum);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

        }
    }
}
