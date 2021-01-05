using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varNconst
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new person
            Person person1 = new Person("Einstein");

            //Create a constructor you will use later
            const string opener = "The smartest guy ever, who is also one of my quantum physics idols is ";

            //Put it all together and print it to the screen
            Console.WriteLine(opener + person1.first + " " + person1.last);
            Console.ReadLine();
        }

        
    }
}
