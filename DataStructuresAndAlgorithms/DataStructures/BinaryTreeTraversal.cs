using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class BinaryTreeTraversal
    {

        class Node{
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left =right =null;
            }
        }

        static int j = 0;
        
        public void InOrder()
        {
            j++;
        }
    }
}
