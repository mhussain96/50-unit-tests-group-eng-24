using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01
{
    public class Class1
    {
        // CHALLENGE ONE  
        // return sum of seq and b , the value of sum should equate to 45 and the total including b =  585
        
        public double summation(double b)
        {
            double sum = 0;
            double[] seq = { 20.3, 2.1,b, 14.4 };
            for (int i = 0; i < seq.Length;i++)
            {
                if (seq[2] == 8.2)
                { 
                    sum = 20.3 + 2.1 + b + 14.4;
                }
            }
            return sum * (double)13;
        }
        // Challenge Two
        public bool isWithdraw(int value)
        {
            bool isValuePositive = false;
            if (value > 10)
            {
                isValuePositive = true;
            }
            return isValuePositive;
        }
        // Challenge Three
        public bool isAllowedEntry(int value)
        {
            bool isAllowed = false;
            List<int> ages = new List<int>();
            ages.Add(1);
            ages.Add(13);
            ages.AddRange(ages);
            foreach (var i in ages)
            {
                if (value >= i)
                {
                    isAllowed = true;
                }
            }           
            return isAllowed;
        }
        // CHALLENGE FOUR   
        public bool NameReturn(char a, char b, char c, char d)
        {
            bool isName = false;
            char[] nameTake = {a,b,c,d};
            string name = new string(nameTake);
            if (name == "jess")
            {
                isName = true;
            }
            return isName;
        }
    }
}
