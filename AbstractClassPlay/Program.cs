using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPlay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new IQuittable object in order to call the Iquit() method below
            IQuittable LastWord = new Employee();
            
            //Create NewEmployee object and call Sayname method below
            Employee NewEmployee = new Employee() { fName = "Bill", lName = "Mitcheson", id = 1 };
            Employee NewEmployee2 = new Employee() { fName = "Stella", lName = "Blue", id = 2 };

            NewEmployee.SayName();
            NewEmployee2.SayName();
            LastWord.Quit();

            if (NewEmployee.id == NewEmployee2.id) 
            {
                Console.WriteLine("\nNewEmployee has the same ID number as NewEmployee2....");
            }
            else
            {
                Console.WriteLine("\nNewEmployee does not have the same ID number as NewEmployee2....");
            }
            Console.ReadLine();
        }
    }
}
