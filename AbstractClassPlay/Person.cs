using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPlay
{
    public abstract class Person
    {
        //Create a person here
        public string fName { get; set; }
        public string lName { get; set; }

        public int id { get; set; }

        public abstract void SayName();

    }
}
