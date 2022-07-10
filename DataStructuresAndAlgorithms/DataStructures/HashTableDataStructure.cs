using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    internal class HashTableDataStructure
    {
		public void TestHashTable()
		{

			// Create a hashtable
			// Using Hashtable class
			Hashtable my_hashtable1 = new Hashtable();

			// Adding key/value pair
			// in the hashtable
			// Using Add() method
			my_hashtable1.Add("A1", "Welcome");
			my_hashtable1.Add("A2", "to");
			my_hashtable1.Add("A3", "GeeksforGeeks");

			Console.WriteLine("Key and Value pairs from my_hashtable1:");

			foreach (DictionaryEntry ele1 in my_hashtable1)
			{
				Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
			}

			// Create another hashtable
			// Using Hashtable class
			// and adding key/value pairs
			// without using Add method
			Hashtable my_hashtable2 = new Hashtable() {
									{1, "hello"},
										{2, 234},
										{3, 230.45},
										{4, null}};

			Console.WriteLine("Key and Value pairs from my_hashtable2:");

			foreach (var ele2 in my_hashtable2.Keys)
			{
				Console.WriteLine("{0}and {1}", ele2,
								my_hashtable2[ele2]);
			}
		}
	}
}
