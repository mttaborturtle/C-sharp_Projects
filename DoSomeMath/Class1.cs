using System;
using System.Collections.Generic;
using System.Text;

namespace DoSomeMath
{
    public class SomeMaths
    {
        public void DoTheMath()
        {
            Console.WriteLine("Please enter a number: ");
            Num1();
            Console.WriteLine("Please enter a number: ");
            Num2();


            AddMe();
            subtractMe();
            MultMe();


        }

        public void Num1()
        {
        int number1 = Convert.ToInt32(Console.ReadLine());
        }

        public void Num2()
        {
        int number2 = Convert.ToInt32(Console.ReadLine());
        }

        public void AddMe()
            {
               
                //int added = number1 + num2;
                Console.WriteLine("This is a test");
            }

        public void subtractMe()
        {
            //int subbed = AddMe.num1 - num2;
            Console.WriteLine("This is a test");
        }

        public void MultMe()
        {
            Console.WriteLine("This is a test");
        }


    }
}
