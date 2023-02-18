using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.LINQ
{
	// internal class Linq1
	// {
		// Linq stands for Language Integrated Query
		// Linq can be used in Arrays, Collections, Relational Databases

		// Linq was introduced in .NET 3.5 Framework

		// SQL => Runtime Syntax Checking of SQL Statements, Debugging is not possible
		// LINQ => Compile Time Syntax Checking of SQL Statements, Debugging is possible

		// Table => Class;
		// Columns => Property;
		// Rows or Records => Instance;
		// Stored Procedures => Methods;
	// }
	interface myInterface1
	{
		 void Add(int x, int y);

	}

	interface myInterface2 : myInterface1
	{
		void Sub(int x, int y);

	}

	public class Linq1 : myInterface2
	{

		public void Add(int x, int y)
		{
			Console.WriteLine(x + y + "QW");
		}

		public void Sub(int x, int y)
		{
			Console.WriteLine(x - y + "ty");
		}
		static void Main(string[] args)
		{
			Linq1 pl = new Linq1();
			pl.Add(23, 23);
			pl.Sub(23, 23);
		}
	}
}
