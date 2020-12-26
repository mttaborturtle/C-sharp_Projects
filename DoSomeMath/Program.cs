using System;


namespace DoSomeMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number to do some maths with then hit enter: ");
            SomeMaths c = new SomeMaths();
            int input1 = Convert.ToInt32(Console.ReadLine());
            int Added = c.AddMe(input1);
            Console.WriteLine("Your number + 5 = " + Added);
            int Subbed = c.SubtractMe(input1);
            Console.WriteLine("Your number - 5 = " + Subbed);
            int Multiplied = c.MultMe(input1);
            Console.WriteLine("Your number X 5 = " + Multiplied);
            Console.ReadLine();

        }
    }

    
}
