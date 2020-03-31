using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleNet
{
    class Program
    {
        private static bool result = false;

        static void Main(string[] args)
        {
            if (result)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine("Hello");
            Console.WriteLine("1st line after switching develop branch!");
        }
    }
}
