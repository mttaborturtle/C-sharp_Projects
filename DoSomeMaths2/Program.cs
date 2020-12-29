using System;

namespace DoSomeMaths2
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths c = new Maths();

            int Added = c.AddMe(250);
            Console.WriteLine("250 + 250 = {0}", Added);

            int Multed = c.AddMe((decimal)4.5);
            Console.WriteLine("4.5 X 4.5 = {0}", Multed);

            int Subbed = c.AddMe("200");
            Console.WriteLine("200 - 50 = {0}", Subbed);
            Console.ReadLine();
        }
    }
}
