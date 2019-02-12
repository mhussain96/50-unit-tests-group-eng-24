using System;
using System.Collections.Generic;

namespace Group3tests
{
    public class Class1
    {
        public string Reverse(string word)
        {
            // Take in a string
            // Output the reverse of this string
            // E.g. string = "word" and return "drow"
            // Code here

            return "";
        }

        public int Smallest(int[] intArray)
        {
            
            // Find the smallest integer in an array of integers
            //Code here

            return -1;
        }

        public int NextSquare(int n)
        {
            // Take in a positive square integer
            // Find the next square integer
            // E.g. input 9 and return 16
            // Code here
            return -1;
        }

        public double GeometricSeries(int a_1, double r, int n)
        {
            // Calculate the nth term in a geometric series , a_n
            // a_1 is the first term, r is the common ratio and n is the number of terms
            // Remember the first term a_1 is already given, that is, n = 1
            // Give your answer to 2d.p.
            // Code here
            return -1;
        }

        public int CreateArray(int size)
        {
            int[] myArray = new int[size];
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = (i + 1) * (i + 1);
            }
            for (int i = 0; i < 10; i++)
            {
                sum += myArray[i];
            }
            return sum;
        }


        public int StackTest()
        {
            Stack<int> stack1 = new Stack<int>();
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                stack1.Push(i * i * i);
            }

            for (int j = 0; j < 10; j++)
            {
                sum += stack1.Pop();
            }
            return sum;
        }
        public int QueueTest()
        {
            Queue<int> queue1 = new Queue<int>();
            int sum1 = 0;
            for (int i = 1; i <= 100; i++)
            {
                queue1.Enqueue(i * i * i);
            }

            for (int j = 0; j < 10; j++)
            {
                sum1 += queue1.Dequeue();
            }
            return sum1;
        }


    }
}
