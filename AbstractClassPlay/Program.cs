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
            //Create a new list of employees
            List<Employee> employList = new List<Employee>()
            {
                new Employee { fName= "Joe", lName= "Schmoe", id= 1 },
                new Employee { fName= "Bill", lName= "Me", id= 2 },
                new Employee { fName= "Rachel", lName= "Inmander", id= 3 },
                new Employee { fName= "Stella", lName= "Blue", id= 4 },
                new Employee { fName= "Jess", lName= "Mannin", id= 5 },
                new Employee { fName= "Ruthie", lName= "Bader", id= 6 },
                new Employee { fName= "Joe", lName= "Dirt", id= 7 },
                new Employee { fName= "Bob", lName= "Dobs", id= 8 },
                new Employee { fName= "Elvis", lName= "Presley", id= 9 },
                new Employee { fName= "Jerry", lName= "Garcia", id= 10 },
            };

            //Create a list of Joes and find the Joes in the employee list with foreach
            List<Employee> Joes = new List<Employee>();
            foreach (Employee employee in employList)
            {
                if (employee.fName == "Joe")
                {
                    Joes.Add(employee);
                }
            };

            //Lambda that does the same as above
            List<Employee> Joes2 = employList.Where(x => x.fName == "Joe").ToList();

            //Print the first list of Joes 
            Console.WriteLine("\nThese are the Joes that work here:\n");
            foreach (Employee joe in Joes)
            {
                Console.WriteLine(joe.fName + " " + joe.lName);
            };

            //Print the list of the lambda Joes
            foreach (Employee employee in Joes2)
            {
                Console.WriteLine("I found with Lambda all Joes: " + employee.fName + " " + employee.lName);
            }

            //Lambda that checks ID and lists the ID greater than 5
            List<Employee> Over5 = employList.Where(x => x.id > 5).ToList();
            Console.WriteLine("\nI found the employees with ID# greater than 5:\n");
            foreach (Employee employee in Over5)
            {
                Console.WriteLine("Employee: " + employee.fName + " " + employee.lName + " - ID#: " + employee.id);
            }

            //I decided to have a little fun and wanted to print the whole list
            Console.WriteLine("\nAnd:\n");
            foreach (Employee employee in employList)
            {
                Console.WriteLine(employee.fName + " " + employee.lName + " works at our awesome company!!");
            };


            ////Create new IQuittable object in order to call the Iquit() method below
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
            Console.ReadLine();
        }
    }
}
