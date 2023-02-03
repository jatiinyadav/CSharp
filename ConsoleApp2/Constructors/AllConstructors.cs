using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Constructors
{
	internal class AllConstructors
	{
		public AllConstructors()
		{
			// Default Constructor
		}

		public AllConstructors(int i)
		{
			// Paramaterized Constructor
		}

		// private AllConstructors(){
		// 
		// Other classes cannot create objects of this class, not the instance of the class can be created.
		// 
		// }

		// static AllConstructors(){
		// 
		//	This constructor will run only once, even if we create multiple instances.
		//  A static constructor does not take access modifiers or have parameters.
		//	It is the first thing to be invoked.
		// }

		public AllConstructors(AllConstructors alc)
		{
			// Copy Constructor
		}
	}
}
