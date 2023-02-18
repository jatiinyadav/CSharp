using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp2.ExceptionHandling
{
	internal class Handling
	{

		static void Main(string[] args)
		{
			int a = 10;

			Thread y = Thread.CurrentThread;
			y.Name = "My Thread";
			Console.WriteLine(y.Name);

			try
			{
				int c = a / 0;
				Console.WriteLine(c);
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}

			finally
			{
				Console.WriteLine("Code Executed");
			}

			Temperature te = new Temperature();
			te.showTemp();
			Console.WriteLine("Hello World");
		}

	}

	public class TempZeroException : Exception
	{
		public override string Message
		{
			get
			{
				return "Error using Exception";
			}
		}
		public TempZeroException() { }
		public TempZeroException(int message) : base($"{message}"){ }
	}

	public class Temperature
	{
		int temp = 0;

		public void showTemp()
		{
			try
			{
				Console.WriteLine("Enter Number: ");
				temp = Convert.ToInt32(Console.ReadLine());
				if(temp > 5)
				{
					throw new TempZeroException(temp);
				}

			}
			catch (TempZeroException ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
		}
	}

	
}
