using DataStructuresAndAlgorithms.Algorithms;
using DataStructuresAndAlgorithms.DataStructures;
using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //ATMCashDispenser ATMMachine = new ATMCashDispenser();
            //Console.WriteLine(ATMMachine.Withdraw(1800));

            // Console.Write("Enter a number: ");
            // var number = int.TryParse(Console.ReadLine(),out int num);
            // Console.WriteLine("The number is a Palindrome: " + num.CheckPalindrome());

            //Console.Write("Enter a number: ");
            //var number = Console.ReadLine();
            //Console.WriteLine("The number is a Palindrome: " + number.LongestPalindrome());

            //Solution.Calc();
            //['gr', 'sd', 'rg']
            //var arr = new string[] { "gr", "sd", "rg" };
            //Console.WriteLine(solution(arr));

            //DataStructures

            //StackAndQueue stackAndQueue = new StackAndQueue();
            //stackAndQueue.TestQueue();
            //stackAndQueue.TestStack();

            var f = new int[] { };
            f[1] = 2;
            int k = f.Length;

            LinkedListDataStructure linkedListDataStructure = new LinkedListDataStructure();
            linkedListDataStructure.TestLinkedList();

        }

        //public static int solution(int[] A)
        //{
        //    // write your code in C# 6.0 with .NET 4.5 (Mono)
        //    int smallestPositveInteger = 1;

        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        if(smallestPositveInteger > A[i])

        //    }
        //}
        
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int n = 1;
            Array.Sort(A);
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == n)
                    n++;
            }
            return n;

        }
        // you can also use other imports, for example:
        // using System.Collections.Generic;

        // you can write to stdout for debugging purposes, e.g.
        // Console.WriteLine("this is a debug message");

        public static int[] solution(string[] S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int[] result = null;

            for (int i = 0; i < S.Length - 1; i++)
            {
                var currentString = S[i];

                for (int j = i + 1; j < S.Length; j++)
                {
                    var laterString = S[j];

                    for (int k = 0; k < S[i].Length; k++)
                    {
                        if (currentString[k] == laterString[k])
                        {
                            result = new int[] { i, j, k };
                            break;
                        }
                    }

                    if (result != null)
                        break;
                }

                if (result != null)
                    break;
            }
            var on = new List<string>();
            return result;
        }

        public static int solution2(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int countMoment = 0;
            var onBulbs = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 1)
                    countMoment++;
                else
                {
                    var allPreviousOn = false;
                    for (int j = A[i] - 1; j >= 1; j--)
                    {
                        if (!onBulbs.Contains(j))
                        {
                            allPreviousOn = false;
                            break;
                        }
                        allPreviousOn = true;
                    }

                    if (allPreviousOn)
                        countMoment++;
                }
                onBulbs.Add(A[i]);
            }

            return countMoment;
        }

        public class Tree
        {
            public int data;
            public Tree left, right;
        };

        // A utility function to create a new Binary
        // Tree node
        static Tree newTree(int data)
        {
            Tree temp = new Tree();
            temp.data = data;
            temp.left = temp.right = null;
            return temp;
        }

        static int numOfNodesInLongestPath(Tree node,Dictionary<int, int> m)
        {
            if (node == null)
                return m.Count;

            // put this node into hash
            if (m.ContainsKey(node.data))
            {
                m[node.data] = m[node.data] + 1;
            }
            else
            {
                m.Add(node.data, 1);
            }

            int num_nodes = Math.Max(numOfNodesInLongestPath(node.left, m),
                                    numOfNodesInLongestPath(node.right, m));

            // remove current node from path
            if (m.ContainsKey(node.data))
            {
                m[node.data] = m[node.data] - 1;
            }

            if (m[node.data] == 0)
                m.Remove(node.data);

            return num_nodes;
        }

        // A utility function to find long unique value path
        //static int largestUniquePath(Tree node)
        //{
        //    if (node == null)
        //        return 0;

        //    // to store all node value
        //    Dictionary<int,int> hash = new Dictionary<int,int>();

        //    // ret max length
        //    return numNodesInLongestPath(node, hash);
        //}

        //class Solution
        //{
        //    public int solution(Tree T)
        //    {
        //        // write your code in C# 6.0 with .NET 4.5 (Mono)

        //        if (T == null)
        //            return 0;

        //        // to store all node value
        //        Dictionary<int, int> hash = new Dictionary<int, int>();

        //        // ret max length
        //        return numOfNodesInLongestPath(T, hash);
        //    }


        //    int numOfNodesInLongestPath(Tree node, Dictionary<int, int> m)
        //    {
        //        if (node == null)
        //            return m.Count;

        //        // put this node into hash
        //        if (m.ContainsKey(node.x))
        //        {
        //            return m.Count;
        //        }
        //        else
        //        {
        //            m.Add(node.x, 1);
        //        }

        //        int num_nodes = Math.Max(numOfNodesInLongestPath(node.l, m),
        //                                numOfNodesInLongestPath(node.r, m));

        //        // remove current node from path
        //        if (m.ContainsKey(node.x))
        //        {
        //            m[node.x] = m[node.x] - 1;
        //        }

        //        if (m[node.x] == 0)
        //            m.Remove(node.x);

        //        return num_nodes;
        //    }

        //}
        // Driver Code
        //public static void Main(String[] args)
        //{

        //    // Create binary tree shown in above figure
        //    Node root = newNode(1);
        //    root.left = newNode(2);
        //    root.right = newNode(3);
        //    root.left.left = newNode(4);
        //    root.left.right = newNode(5);
        //    root.right.left = newNode(6);
        //    root.right.right = newNode(7);
        //    root.right.left.right = newNode(8);
        //    root.right.right.right = newNode(9);

        //    Console.WriteLine(largestUinquePath(root));
        //}
    }
}
