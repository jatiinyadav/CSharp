using ConsoleApp2;
using System.Collections;

namespace Application{
    class Hashing
    {

        int xe = 10;
        static void Main(string[] args)
        {
            Hashing hs1 = new Hashing();
			Hashing hs12 = new Hashing();
			hs1.xe = 21;
            Console.WriteLine(hs1.xe);
            Console.WriteLine(hs12.xe);

            

            // Variables
            // Instance/Non-Static Variables: 0 copy for no instance, n copies for n instance
            // Static Variables: Only one copy, can be accessed without instance.
            // Readonly Variable: Cannot be modified after initialization
            // Constant Variables: Cannot be modified and only one copy

        }
    }
}
