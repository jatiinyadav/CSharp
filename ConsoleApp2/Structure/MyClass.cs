using System;

namespace ConsoleApp2.Structure
{

	// Class memory is located in the heap memory because it is a reference type.
	// Struct memory is located in the Stack memory because it is a value type.
	struct MyClass
	{
		// Predefined data types of value type category are structures. (int, double, float)
		// Predefined data types of reference type category are classes. (Ex: String, Object)

		// When we have to store large data go for Classes.
		// When we have to store small data fo gor Structures.

		// In case of classes when creating a new instance the keyword new is mandatory,
		// whereas in struct the new keyword is optional.

		// Initialization is possible in the class ex: int i = 10;
		// It is not possible in the time of struct ex: int i; we cannot do int i = 10;

		// A structure doesn't support inheritance.
		// A structure can also implement a interface.
		static int x = 10;

		static MyClass()
		{
			Console.WriteLine("Hello Worldss");
		}

		static void Func()
		{
			Console.WriteLine("Hello you there!!");
		}
		static void Main(string[] args)
		{
			MyClass cls = new MyClass();
			MyClass cls2 = new MyClass();
			Console.WriteLine(x);
		}
	}

	public class Area
	{
		double _radius = 12.34;

		public double Radius
		{
			get{ return _radius; }
			set{ if (value > _radius) { 
					_radius = value;    
			} }
		}
	}

	public class Example
	{
		static void Main(string[] args)
		{
			Area ar = new Area();
			double radius = ar.Radius;
			ar.Radius = 23.11;            
			Console.WriteLine(ar.Radius);
		}


	}
}