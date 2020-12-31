using System;

namespace StructMe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new object from the struct
            Struct struct1 = new Struct();
            
            //Give it a value
            struct1.Number = 12.5m;
            
            //Print it to the console
            Console.WriteLine("This is my decimal number: " + struct1.Number);
            Console.ReadLine();
        }
    }
}
