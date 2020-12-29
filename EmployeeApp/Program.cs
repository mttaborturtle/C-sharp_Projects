using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { FName = "Sample", LName = "Student" };
            emp1.SayName();
            
            Console.ReadLine();
        }
    }
}
