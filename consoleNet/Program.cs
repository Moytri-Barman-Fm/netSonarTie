using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleNet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;

            if (isTrue == true)
            {
                Console.WriteLine("1");
            }

            if (isTrue == false)
            {
                Console.WriteLine("2");
            }

            bool IsBoolMethod()
            {
                return true;
            }

            if (IsBoolMethod() == false)
            {
                Console.WriteLine("3");
            }
            Console.WriteLine("Hello");
            Console.WriteLine("1st line after switching develop branch!");
        }
    }
}
