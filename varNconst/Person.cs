using System;
using System.Collections.Generic;
using System.Text;

namespace varNconst
{
    public class Person
    {
        public string last;
        public string first;

        public Person(string fName) : this(fName, "Albert")
        {
        }
        public Person(string lName, string fName)
        {
            last = lName;
            first = fName;
        }

     
    }
}
