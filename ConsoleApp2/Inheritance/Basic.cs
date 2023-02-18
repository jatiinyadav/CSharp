using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Inheritance
{
    class Basic
    {
        public void func()
        {
            Console.WriteLine("Hello World");
        }

    }

    class Bas2 : Basic
    {
        public new void func()
        {
            Console.WriteLine("Hello World from Basic2");
        }

        public int i;

        public Bas2() { }
        public Bas2(int element)
        {
            i = element;
        }

        public static Bas2 operator +(Bas2 cb4, Bas2 cb2)
		{
            Bas2 cv5 = new Bas2(cb4.i + cb2.i);
			return cv5;
		}

        static void Main(string[] args)
        {
            Bas2 cv1 = new Bas2(10);
            Bas2 cv2 = new Bas2(10);
            Bas2 cv3 = cv1 + cv2;


            Console.WriteLine(cv3.i);
            
        }
	}

 

    class Basic3 : Bas2
    {

        static int qq = 10;

        public new void func()
        {
            Console.WriteLine("Hello World from Basic2");
        }

        static void Main(string[] args)
        {
            Basic3 b2 = new Basic3();
            b2.func();
            Console.WriteLine(qq);

        }
    }
}
