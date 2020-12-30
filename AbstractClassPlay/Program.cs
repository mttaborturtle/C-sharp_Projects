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
            Employee<string> emp1 = new Employee<string>();
            emp1.Things = new List<string> { "This", "is", "a", "cool", "list", "of", "strings" };

            foreach (string word in emp1.Things)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("\npress enter to continue....");
            Console.ReadLine();

            Employee<int> emp2 = new Employee<int>();
            emp2.Things = new List<int> { 123, 283, 3882, 8675309, 293, 2991, 23, 42 };

            foreach (int numbr in emp2.Things)
            {
                Console.WriteLine(numbr);
            }

            Console.WriteLine("\npress enter to quit....");
            Console.ReadLine();

            //Create new IQuittable object in order to call the Iquit() method below
            //IQuittable LastWord = new Employee();

            ////Create NewEmployee object and call Sayname method below
            //Employee NewEmployee = new Employee() { fName = "Bill", lName = "Mitcheson", id = 1 };
            //Employee NewEmployee2 = new Employee() { fName = "Stella", lName = "Blue", id = 2 };

            //NewEmployee.SayName();
            //NewEmployee2.SayName();
            //LastWord.Quit();

            //if (NewEmployee.id == NewEmployee2.id) 
            //{
            //    Console.WriteLine("\nNewEmployee has the same ID number as NewEmployee2....");
            //}
            //else
            //{
            //    Console.WriteLine("\nNewEmployee does not have the same ID number as NewEmployee2....");
            //}
            //Console.ReadLine();
        }
    }
}
