using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_workspace
{
    
    public class Class1
    {
      
    }   
    public class myList1
    {
    static int[,] mySquareArray = new int[10, 10];
        public int IntegerList()
        {
            List<int> listSquare = new List<int>();
            int listSum = 0;
            for (int i = 0; i < mySquareArray.GetLength(0); i++)
            {
                for (int j = 0; j < mySquareArray.GetLength(1); j++)
                {
                    mySquareArray[i, j] = i * j;
                    listSquare.Add(mySquareArray[i, j]);
                    //listSum += listSquare[i * 10 + j];
                }
            }
            return listSquare[44];
        }
    }
}
