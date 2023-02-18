using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Collections
{
	internal class HashTable
	{

		static void Main(string[] args)
		{
			// HashTable
			Hashtable ht = new Hashtable();
			ht.Add("Eid", 1010);
			ht.Add("Ename", "Scott");
			ht.Add("Job", "Manager");
			ht.Add("Salary", 25000);

			foreach (var item in ht.Keys)
			{
				Console.WriteLine($"{item} : {ht[item]}");
			}

			// Generic Type
			List<int> ls = new List<int>();
			ls.Add(20);
			// ls.Add("Hello"); // Cannot add string in Generic Type Int

		}

	}


}
