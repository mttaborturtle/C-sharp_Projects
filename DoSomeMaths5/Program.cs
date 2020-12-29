using System;

namespace DoSomeMaths5
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths c = new Maths();
            Console.WriteLine("Enter a number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            c.MathMe(Number);

            decimal num2 = 250.5m;
            c.MathMe(num2);
            
            
            int ShowNumber;
            c.Anumber(out ShowNumber);
            Console.WriteLine("\nThis is a number I used in an output method: " + ShowNumber);

            Static.somewords();

            Console.ReadLine();
        } 
    }
}
