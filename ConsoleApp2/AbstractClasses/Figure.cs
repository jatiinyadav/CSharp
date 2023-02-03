using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.AbstractClasses
{
	internal abstract class Figure
	{
		public double width, height, radius;
		public const float pi = 3.14f;

		public abstract double GetArea();
	}

	class Rectangle : Figure
	{
		public Rectangle(double height, double width)
		{
			this.height = height;
			this.width = width;
		}

		public override double GetArea()
		{
			return width * height;
		}
	}

	class Circle : Figure
	{
		public Circle(double radius) {
			this.radius = radius;
		}

		public override double GetArea()
		{
			return radius * radius * pi;
		}

		static void Main(string[] args)
		{
			Circle cl = new Circle(20);
			Console.WriteLine(cl.GetArea());
		}
	}


}
