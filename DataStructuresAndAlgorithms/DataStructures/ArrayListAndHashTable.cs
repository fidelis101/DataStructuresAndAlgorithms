using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    class ArrayListAndHashTable
    {
        public void TestArrayList()
        {
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            

            foreach (var item in arlist1)
                Console.WriteLine(item + ", ");


            Console.WriteLine(arlist1[1]);

            // Create a hashtable
            // Using Hashtable class
            Hashtable my_hashtable = new Hashtable();

            //Adding key/value pair in the hashtable
            //Using Add() method
            my_hashtable.Add("A1", "Welcome");
            my_hashtable.Add("A2", 1);
            my_hashtable.Add("A3", "GeeksforGeeks");

            foreach(DictionaryEntry element in my_hashtable)
            {
                Console.WriteLine("Key:- {0} and Value:- {1}", element.Key, element.Value);
            }

            Console.ReadKey();
        }
    }
}
