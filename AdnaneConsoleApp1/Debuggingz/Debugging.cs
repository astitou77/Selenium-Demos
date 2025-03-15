using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AdnaneConsoleApp1.Debuggingz
{
    class Debugging
    {

        [TestMethod]
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Debugging Demo !");

#if DEBUG
            Console.WriteLine("!!!!!!! Debug Mode !!!!!!! ");
#else
            Console.WriteLine("Release Mode");
#endif
            int Adnano = 5;
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine(Adnano+i);
            }

            // Breakpoint"
            Console.WriteLine("Setting breakpoint...");

            // Step into, over, and out

        }
    }
}
