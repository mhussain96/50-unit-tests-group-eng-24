using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_workspace
{
    
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
    public class myList4
    {
        public Dictionary<int, string> topFilms = new Dictionary<int, string>();
        public Dictionary<int, string> TopFilms()
        {
            //Put all these films in a list in order of release date
            topFilms.Add(1994, "Shawshank Redemption");
            topFilms.Add(1972, "The Godfather");
            topFilms.Add(2008, "The Dark Knight");
            topFilms.Add(1957, "12 Angry Men");
            topFilms.Add(1993, "Schindler's List");
            topFilms.Add(1994, "Pulp Fiction");
            topFilms.Add(1966, "The Good, the Bad and the Ugly");
            topFilms.Add(1999, "Fight Club");
            topFilms.Add(2010, "Inception");
            topFilms.Add(2018, "Into the Spider-Verse");

        return topFilms;
        }
    }
}
