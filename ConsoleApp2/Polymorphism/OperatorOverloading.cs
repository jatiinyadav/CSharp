using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Polymorphism
{
	internal class OperatorOverloading
	{
		// Operator Overloading
		int str1 = 10;
		int str2 = 5;


		// + operator
		public static OperatorOverloading operator+ (OperatorOverloading opov)
		{

			opov.str2 = -opov.str2;

			return opov;
		}

		public void Display()
		{
			Console.WriteLine(str1);
			Console.WriteLine(str2);
		}
		

		static void Main(string[] args)
		{
			OperatorOverloading cls = new OperatorOverloading();
			cls = +cls;
			Console.WriteLine(cls.str1 + cls.str2);
			
		}
	}
}
