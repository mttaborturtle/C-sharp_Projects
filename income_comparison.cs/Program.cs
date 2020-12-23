using System;

namespace income_comparison.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1:\nWhat is your hourly rate? Submit rate then press enter:");
            string rateNum;
            int intNum;
            rateNum = Console.ReadLine();
            intNum = Convert.ToInt32(rateNum);

            Console.WriteLine("How many hours did you work per week on average?\nSubmit hours then press enter:");
            string hourStr;
            int hourInt;
            hourStr = Console.ReadLine();
            hourInt = Convert.ToInt32(hourStr);

            Console.WriteLine("Person 2:\nWhat is your hourly rate? Submit rate then press enter:");
            string rateNum2;
            int intNum2;
            rateNum2 = Console.ReadLine();
            intNum2 = Convert.ToInt32(rateNum2);

            Console.WriteLine("How many hours did you work per week on average?\nSubmit hours then press enter:");
            string hourStr2;
            int hourInt2;
            hourStr2 = Console.ReadLine();
            hourInt2 = Convert.ToInt32(hourStr2);

            int Per1Tot = (intNum * hourInt) * 52;
            int Per2Tot = (intNum2 * hourInt2) * 52;
            bool WhoRich = Per1Tot > Per2Tot;
            Console.WriteLine("Annual salery of Person 1:\n" + Per1Tot.ToString());
            Console.WriteLine("Annual salery of Person 2:\n" + Per2Tot.ToString());

            Console.WriteLine("\nDoes Person 1 make more money than Person 2?  " + WhoRich.ToString());
            Console.ReadLine();
        }
    }
}
