using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    public class Collections_Dict
    {
        public bool Collection_Test_01()
            /*
            Test 1:
            A method that contains a dictionary of five Spartans. The method should return true if the value 'Micheal'
            has a key of '1'.
            */
        {
            IDictionary<int, string> dict = new Dictionary<int,string>();
            dict.Add(0, "Luke");
            dict.Add(1, "Micheal");
            dict.Add(2, "Amira");
            dict.Add(3, "Maiwand");

            return dict.Contains(new KeyValuePair<int, string>(1, "Micheal"));
        }

        public int Collection_Test_02()
            /*
            Test 2:
            A method that contains a queue of integers 1 - 4. The method should return the value of the first item
            in the queue (which is '1').
            */
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            return queue.Peek();
        }

        public string Collection_Test_03()
            /*
            Test 3:
            A method that contains a queue of five strings. A foreach loop goes through the queue and adds
            the value of each queue item to a variable named 'queueSentance'. Once the loop has finished, the method 
            returns the final string contained in the 'queueSentance' variable which should be 'This is a queue.'
            */
        {
            var queueSentance = "";
            Queue<string> queue2 = new Queue<string>();
            queue2.Enqueue("This");
            queue2.Enqueue(" is");
            queue2.Enqueue(" a");
            queue2.Enqueue(" queue.");

            foreach(string item in queue2)
            {
                queueSentance += item;
            }

            return queueSentance;
            
        }
        
        public string Collection_Test_04()
            /*
            Test 4:
            A method that contains a dictionary of five strings. The method should return the value contained 
            in the dictionary index 1 which is 'Item Ones'.
            */
        {
            IDictionary<int, string> dict02 = new Dictionary<int, string>();
            dict02.Add(0, "Item One");
            dict02.Add(1, "Item Two");
            dict02.Add(2, "Item Three");
            dict02.Add(3, "Item Four");
            
            return dict02[1];
        }
        
    }
}
