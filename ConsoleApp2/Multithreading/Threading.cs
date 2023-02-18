using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Multithreading
{
	internal class Threading
	{
		public static void Test1()
		{
			// int num = Convert.ToInt32(max);
			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine("Test1: " + i);
			}
		}

		public static void Test2()
		{
			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine("Test2: " + i);
			}
		}

		public void Test3()
		{
			lock (this);
			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine("Test3: " + i);
			}
		}
		static void Main(string[] args)
		{
			Threading threads = new Threading();
			Console.WriteLine("Main thread started.");
			Thread t1 = new Thread(Test1);
			Thread t2 = new Thread(Test2);
			Thread t3 = new Thread(threads.Test3);

			t3.Priority = ThreadPriority.Highest;

			t1.Start(); t2.Start(); t3.Start();
			// The main thread will not end until and unless all the threads are executed completely.
			t1.Join(); t2.Join();

			Console.WriteLine("Main Thread Ended.");


			// ThreadStart ts = new ThreadStart(Test1); // Thread Start is a delegate
			// Thread t = new Thread(ts);
			// t.Start();

			// Paramaterized Thread Start
			// It takes only an object as paramter
			// It is not type safe
			// ParameterizedThreadStart pts = new ParameterizedThreadStart(Test1);
			// Thread t = new Thread(pts);
			// t.Start(231);

			// Thread Priorities
			// - Lowest
			// - Below Normal
			// - Normal [default]
			// - Above Normal
			// - Highest
                 

			// Abort method will stop the infinite loop if running in threads

		}
	}
}
