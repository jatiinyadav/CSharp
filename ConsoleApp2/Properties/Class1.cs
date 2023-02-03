using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Properties
{
	internal class Class1
	{

		int _Balance;
		string name;
		bool _Status;
		string _Country;

		public string CName
		{
			get { return name; }
			set { name = value; }
		}

		public int Balance
		{
			get { return _Balance; }

			protected set { if(_Status){
					_Balance = value;
				}}
		}

		public Class1(int balance, bool status, string myName, string country)
		{
			_Balance = balance;
			_Status = status;
			_Country = country;
			name = myName;
		}



		public bool Status
		{
			get { return _Status; }
			set { _Status = value; }

		}

		public string Country
		{
			set
			{
				_Country = value;
			}
		}


	}
}
