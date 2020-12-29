using System;

namespace DoSomeMaths4
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths c = new Maths();

            int num1 = 25;
            int num2 = 30;

            c.MathMe(num1, num2);
            c.MathMe(x:num1, y:num2);
            
            Console.ReadLine();
        }
    }
}
