using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeTests
{
    public class SomeTest
    {
        // takes a string change any text into lowercase then uppercase on repeat, ignoring spaces
        // Hello => hElLo first character should be a lowercase
        public string TextToSpongeBobMeme(string str) {

            return "";
        }

        // takes 3 words, return a string removing the middle word leaving one space
        public string RemoveMiddleWord(string str) {

            return "";
        }

        // takes an array of ints, return the sum of the array NOT INCLUDING THE LARGEST NUMBER
        public int SumIgnoringMax(int[] intArr) {
            
            return -1;
        }

        // takes 2 ints which decides how high the pyramid goes
        /*example for 5, 9

             *
            ***
           *****
          *******
         *********
     
        */
        public char[,] Pyramid(int height, int width) {
            char[,] pyramid = new char[height, width];
            //some code to make it work, good luck 
            
            return pyramid;
        }

        // takes 2 int arrays, returns teh elements from the first array that aren't in the 
        // second array
        public int[] Different(int[] arr1, int[] arr2) {

            return new int[] { };
        }

        // Using DateTime and AddDays increment the given date by one year
        public string AddADay(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day);
            date = date.AddDays(365);
            string test1 = date.ToString();
            return test1;
        }
        // An Array of integers are provided theyre in a random order
        // create a method that will sort this array in an acsending order
        public int[] BubSort(int[] unsorted)
        {
            int temp = 0;
            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = 0; j < unsorted.Length - 1; j++)
                {
                    if (unsorted[j] > unsorted[j + 1])
                    {
                        temp = unsorted[j + 1];
                        unsorted[j + 1] = unsorted[j];
                        unsorted[j] = temp;
                    }
                }
            }
            return unsorted;
        }

        // Create a method that will write the string "Hello" reversed
        public string ReverseString(string str)
        {
            string reverse = null;
            int l = 0;

            l = str.Length - 1;
            while (l >= 0)
            {
                reverse = reverse + str[l];
                l--;
            }
            return reverse;
        }

        //solve 3x^2 + 2x - 1, one of the roots will be the correct answer
        public double Quadratic(int a, int b, int c)
        {
            double d = 0;
            double x1 = 0;
            double x2 = 0;

            d = (b * b) - (4 * a * c);
            if (d == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
            }
            return x2;
        }

        public int Mult(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
    }
}
