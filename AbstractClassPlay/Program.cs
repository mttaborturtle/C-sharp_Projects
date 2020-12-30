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
            Employee NewEmployee = new Employee() { fName = "Sample", lName = "Student" };
            
            NewEmployee.SayName();
            LastWord.Quit();

            Console.ReadLine();
        }
    }
}
