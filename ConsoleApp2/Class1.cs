using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {

        public String myName = "Hello World";

        // Explicit Constructor  or Parameterless
        public Class1(int i)
        {
            Console.WriteLine("Constructor Class1 is called: " + i);
        }

        // Paramaterized Constructor
        public Class1(String name)
        {
            Console.WriteLine($"Hello {name}");
        }

        // Copy Constructor
        public Class1(Class1 cls)
        {
            myName = cls.myName;
        }

        // Static Constructor 
        static Class1()
        {
            Console.WriteLine("Static Constructor is Called");
        }


        static void Main()
        {
            int section = 12;
            Console.WriteLine(section);
        }

    }
}
