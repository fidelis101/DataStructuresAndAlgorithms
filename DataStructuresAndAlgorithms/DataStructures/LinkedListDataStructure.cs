using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    internal class LinkedListDataStructure
    {
        public void TestLinkedList()
        {
            LinkedList<int> data = new LinkedList<int>();
            int limit = 0;

            int[] test = { 1, 7, 3, 9, 2, 6,5 };

            foreach (var item in test)
            {
                if(item <= limit)
                {
                    data.AddFirst(item);
                }else
                {
                    data.AddLast(item);
                }
            }

            var data1 = data.OrderByDescending(x => x);
        }
    }
}
