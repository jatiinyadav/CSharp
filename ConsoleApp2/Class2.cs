using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	 internal class Class2 : Class1
	{
		public Class2() : base(10)
		{
			Console.WriteLine("Class2 Constructor");
		}
		static void Main(string[] args)
		{
			Class2 cls2 = new Class2();
			Console.WriteLine(cls2.myName);
		}

		// Single Level
		// MultiLevel
		// Multiple
		// Heirarichal
		// Hybrid	

	}
}
