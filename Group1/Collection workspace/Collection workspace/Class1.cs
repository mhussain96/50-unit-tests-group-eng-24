using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Collection_workspace
{

    //Amira's Solutions
    public class CollectionsTesting
    {
        static Dictionary<string, string> dict = new Dictionary<string, string>();
        //Create Dictionary additions of books with authors as their key (two strings). 

        public Dictionary<string, string> DictionaryTest1()
        {
            return dict;
        }
    }
    //Maiwand's Solutions
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
          
        //Michael's Solutions
          public class myList1
          {
          static int[,] mySquareArray = new int[10, 10];
              public int IntegerList(int size)
              {
                  //Create a square array with all the values from 0 - 99
                  //Add the values from the array to a list in numerical order
                  //Return the number in the 44th position
                  //Should return 44
                  return -1;
              }
          }
          
          public class myList2
          {
              public List<string> ClassList()
              {
                  List<string> listOfClassMembers = new List<string>();
                  return listOfClassMembers;
                  //Delete the two lines above
                  //Create a list of class members
                  //return the list
              }
          }
          
          public class myList3
          {
              //Create a constructor for creating a book
              //Include its name, author and release year
              //Create a list of 4 books as objects
              //And return the list
              public class Book
              {
                  public Book()
                  {

                  }
              }

              public List<Book> Library()
              { 
                  var booklist = new List<Book>();
                  return booklist;

              }
          }
    }
}
