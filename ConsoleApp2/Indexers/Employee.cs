using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Indexers
{
	internal class Employee
	{
		int emo;
		string ename, job, dname, location;
		double salary;

		public Employee(int emo, string ename, string job, string dname, string location, double salary)
		{
			this.emo = emo;
			this.ename = ename;
			this.job = job;
			this.dname = dname;
			this.location = location;
			this.salary = salary;
		}

		public object this[int index] {
			get {
				if (index == 0)
				{
					return emo;
				}
				else if (index == 1) return ename;
				else if (index == 2) return job;
				else if (index == 3) return dname;
				else if (index == 4) return location;
				else if (index == 5) return salary;
				else
				{
					return -1;
				}
			}
			set
			{
				if (index == 0)
				{
					emo = (int)value;
				}
				else if (index == 1) ename = (string)value;
				else if (index == 2) job = (string)value;
				else if (index == 3) dname = (string)value;
				else if (index == 4) location = (string)value;
				else if (index == 5) salary = (double)value;

			}
		}

	}
}
