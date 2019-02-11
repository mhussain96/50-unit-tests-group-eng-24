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
        {
            IDictionary<int, string> dict = new Dictionary<int,string>();
            dict.Add(0, "Luke");
            dict.Add(1, "Micheal");
            dict.Add(2, "Amira");
            dict.Add(3, "Maiwand");

            return dict.Contains(new KeyValuePair<int, string>(1, "Micheal"));
        }

        public int Collection_Test_02()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            return queue.Peek();
        }

        public string Collection_Test_03()
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
