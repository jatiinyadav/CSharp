using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Delegate
{
	internal class Delegate1
	{
		// A delegate holds the refernce of a method and then calls the method for execution
		// 1. Define a delegate
		// 2. Instantiating the delegate (Crreating an instance of the delegate)

		public delegate void AddDelegate(int a, int b);
		public delegate void StringDelegate(string name);
		public void AddNums(int a, int b)
		{
			Console.WriteLine($"{a} + {b}");
		}

		public static void StringName(string name)
		{
			Console.WriteLine($"My name is: {name}");
		}

		static void Main(string[] args)
		{
			Delegate1 d = new Delegate1();
			AddDelegate ad = new AddDelegate(d.AddNums);
			ad(23, 12);

			// Anonymous Method
			StringDelegate sstr = delegate (string name)
			{
				Console.WriteLine("Hello");
			};

			// The anonymous can also be used when adding functions in the windows application form

			StringDelegate sd = new StringDelegate(StringName);
			sd("Jatin Yadav");
		}
	}
}
