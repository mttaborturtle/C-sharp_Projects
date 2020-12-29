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
            //Create employee object and call Sayname method then the quit interface
            Employee emp1 = new Employee() { fName = "Sample", lName = "Student" };
            emp1.SayName();
            emp1.Quit();
            
            Console.ReadLine();
        }
    }
}
