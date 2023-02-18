using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{
	class Cls1
	{
		public void He()
		{
			Console.WriteLine("Hello World from He");
		}
	}

	class Cls2 : Cls1
	{
		public void Him()
		{
			Console.WriteLine("Hello World from Him");
		}

	}

	class Cl3
	{
		static void Main(string[] args)
		{
			Cls2 cx = new Cls2();
			cx.Him();
		}
	}


}
