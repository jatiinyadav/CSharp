using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Properties
{
	internal class Program
	{

		enum Hello
		{
			Monday, Tuesday, Wednesday, Thrusday, Friday, Saturday, Sunday
		}
		static void Main(string[] args)
		{
			Class1 cls = new Class1(2000, false, "Hello World", "Jatin Yadav");
			cls.Status = true;
			cls.CName = "Jatin Yadav";

			Console.WriteLine((Hello)2);

			Console.WriteLine(cls.Balance);
			Console.WriteLine(cls.CName);
		}
	}
}
