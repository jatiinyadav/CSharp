using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Polymorphism
{

	class Matrix
	{
		public int a, b, c, d;
		public Matrix(int a, int b, int c, int d)
		{
			this.a = a;
			this.b = b;
			this.c = c;
			this.d = d;
		}

		public override string ToString()
		{
			return $"a: {a}\nb: {b}\nc: {c}\nd: {d}";
		}

		public static Matrix operator +(Matrix mx1, Matrix mx2)
		{

			Matrix obj = new Matrix(mx1.a + mx2.a, mx1.b + mx2.b, mx1.c + mx2.c, mx1.d + mx2.d);

			return obj;
		}
	}

	internal class MatrixAddition
	{
		static void Main(string[] args)
		{
			Matrix mx1 = new Matrix(10, 20, 30, 40);
			Matrix mx2 = new Matrix(10, 20, 30, 40);

			Matrix mx3 = mx1 + mx2;
			Console.WriteLine(mx3);
		}
	}
}
