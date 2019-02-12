using System;
using System.Collections.Generic;

namespace TestingClass
{
    public class Class1
    {
        public int initial_test()
        {
            int num1 = 5;
            int num2 = 5;
            int sum = num1 + num2;
            return sum;
        }

        public string displayInitials()
        {
            string name = "John Smith";

            char firstInitial = name[0];
            char secondIntital = name[5];
            return name[0].ToString()+name[5].ToString();
        }

        public int timesBy3(int n1, int n2)
        {

            return n1 == n2 ? (n1 + n2) * 3 : n1 + n2;
        }

        public int explicitCasting(double n1)
        {
            double doubleNumber = n1;
            int intNumber = (int)doubleNumber; 

            return intNumber ;
        }

        public int sumOfAll()
        {
            int total = 0;
            for(int i = 0; i < 50; i++)
            {
                total = total + i;
            }

            return total;

        }
    }
}
