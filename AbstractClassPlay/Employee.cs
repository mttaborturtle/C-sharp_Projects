using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPlay
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + fName + " " + lName);
        }

        public void Quit()
        {
            Console.WriteLine("I quit!!!!");
        }
    }
}
