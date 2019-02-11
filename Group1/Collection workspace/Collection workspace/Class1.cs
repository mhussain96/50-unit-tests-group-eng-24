using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_workspace
{
    
    public class Class1
    {
        public string StackMethod()
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");


            Console.WriteLine(myStack);
            // what does this stack return

            return "Something";
        }

        public int AnotherStack()
        {
            Stack<int> newStack = new Stack<int>();
            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);
            newStack.Push(4);
            newStack.Push(5);
            newStack.Push(6);

            Console.WriteLine(newStack.Pop());
            Console.WriteLine(newStack.Pop());
            // how many does this stack return

            return -1;
        }
        
        public int AnotherStack2()
        {
            Stack<int> AnotherStack2 = new Stack<int>();
            for (int i = 1; i < 51; i++)
            {
                AnotherStack2.Push(i);
            }

            return AnotherStack2.Peek();
        }

        public int AnotherStack3()
        {
            Stack<int> AnotherStack3 = new Stack<int>();
            for (int i = 1; i < 51; i++)
            {
                // add 10 to the stack without changing length
            }

            return AnotherStack3.Peek();
        }
    }
}
