using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Indexers
{
	internal class MainI
	{
		static void Main(string[] args)
		{
			Employee emp = new Employee(2, "Jatin Yadav", "Developer", "IT", "Delhi", 23.14);
			Console.WriteLine(emp[0]);
			Console.WriteLine(emp[1]);
			Console.WriteLine(emp[2]);
			Console.WriteLine(emp[3]);

			emp[1] = "Yadav Jatin";
			Console.WriteLine(emp[1]);
		}
	}
}
