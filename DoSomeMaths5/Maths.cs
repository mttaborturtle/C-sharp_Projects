using System;
using System.Collections.Generic;
using System.Text;

namespace DoSomeMaths5
{
    class Maths
    {
        public void MathMe(int x)
        {
            int DivMe = x / 2;
            Console.WriteLine("Your number divided by 2 = {0}", DivMe);
        }

        public void MathMe(decimal x)
        {
            decimal DivMe = x / 2;
            Console.WriteLine("\n250.5 divided by 2 = {0}", DivMe);
        }

        public void Anumber(out int number)
        {
            number = 1024;
        }
    }
}
