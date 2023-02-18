using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collections
{
	internal class ArrList
	{

		public static void displayData(ArrayList arr)
		{
			Console.WriteLine();

			foreach (var item in arr)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();

		}

		static void Main(string[] args)
		{
			ArrayList arr = new ArrayList();
			arr.Add(100);
			arr.Add(200);
			arr.Add(300);
			arr.Add(400);
			arr.Add(500);

			displayData(arr);

			arr.Reverse();

			displayData(arr);

			arr.RemoveAt(3);

			displayData(arr);
		}

	}
}
