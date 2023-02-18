using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
	interface Interface1
	{
		// Contains only abstract methods, methods which doesn't have a body.
		// Every abstract method of an interface should be implemented by the child class,
		// of an interface.	
		// The default scope the members of Interface is public whereas class has private	 
		// Every member of interface is abstract by default.
		// We cannot declare variables in Interfaces.

		void Add(int a, int b);
	}

	interface Interface2
	{
		void Hello();
		void Show();
	}

	interface Interface3
	{
		void Hello();
		void Show();
	}
	class ImplementationClass : Interface1, Interface2, Interface3
	{
		public void Add(int a, int b)
		{
			Console.WriteLine(a + b);
		}

		public void Hello()
		{

		}

		void Interface2.Show()
		{
			Console.WriteLine("Hey there");
		}	

		void Interface3.Show()
		{

		}

		static void Main(string[] args)
		{
			ImplementationClass cls1 = new ImplementationClass(); // Instance 
			cls1.Add(20, 20);

			Interface2 i1 = cls1; // Reference Variable
			i1.Show();

		}
	}

}
