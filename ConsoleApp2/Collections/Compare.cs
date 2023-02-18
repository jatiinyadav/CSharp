using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collections
{
	internal class Compare
	{
		public bool CompareValues(int a, int b)
		{
			if (a == b) return true;
			return false;
		}

		public int CompareintValues (int a, int b)
		{
			if (a == b)
			{
				Console.WriteLine("Values are same");
			} else
			{
				Console.WriteLine("Values are not same");
			}

			return -1;
		} 

		static void Main(string[] args)
		{
			Compare cp = new Compare();
			Console.WriteLine(cp.CompareValues(2,2));
		}
	}
}
