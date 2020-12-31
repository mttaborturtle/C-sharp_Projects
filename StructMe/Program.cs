using System;

namespace StructMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Struct struct1 = new Struct();
            struct1.Number = 12.5m;
            
            Console.WriteLine("This is my decimal number: " + struct1.Number);
            Console.ReadLine();
        }
    }
}
