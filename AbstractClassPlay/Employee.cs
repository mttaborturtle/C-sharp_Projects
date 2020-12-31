using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPlay
{
    public class Employee : Person, IQuittable
    {


        //Do something with the person created
        public override void SayName()
        {
            Console.WriteLine("\nName: " + fName + " " + lName + ", ID number: " + id);
        }

        //It looks like the person quit so it uses the interface to announce that they quit!
        public void Quit()
        {
            Console.WriteLine("\nThis is my last day because I quit!!!!");
        }

        //Operator overload below
        public static bool operator ==(Employee employee, Employee employee2)
        {
            return employee.id == employee2.id;
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            return employee.id != employee2.id;
        }
    }
}
