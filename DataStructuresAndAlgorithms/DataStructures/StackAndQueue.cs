using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    class StackAndQueue
    {
        public void TestStack()
        {
            Stack<string> stackText = new Stack<string>();
            stackText.Push("a");
            stackText.Push("b");

            Console.WriteLine(stackText.Peek());
            stackText.Pop();

            Console.WriteLine(stackText.Peek());

            Console.ReadLine();
        }

        public void TestQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            Console.WriteLine(queue.Peek());

            Console.WriteLine();
        }
    }
}
