using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Statics
	{

		int x = 10;

		static class MyClass
		{
			static void Hello()
			{
				Console.WriteLine("Hello World");
			}
			public static void Greeting()
			{
				Console.WriteLine("Greetings");
			}

			static void Main(string[] args)
			{

				Statics.MyClass.Hello();

			}

		}
		 
		static void Main(string[] args)
		{
			// Statics st = new Statics();
			// Statics.MyClass.Hello();
			Statics.MyClass.Greeting();

		}


	}
}
