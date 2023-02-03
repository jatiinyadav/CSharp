using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collections
{
	internal class ArrList
	{

		static void Main(string[] args)
		{
			List<int> arr = new List<int>();
			arr.Add(2);

			Stack<string> str = new Stack<string>();
			str.Push("Hello");

			Queue<double> qu = new Queue<double>();
			qu.Enqueue(23.143);

			Hashtable ht = new Hashtable();
			ht.Add(1, "Hello");
			ht.Add(3, "C# Learning");
			ht.Add(2, "World");

			foreach (var item in ht.Keys)
			{
				Console.WriteLine(ht[item]);
			}
		}
	}
}
