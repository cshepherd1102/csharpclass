using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        private static void Main(string[] args)
        {
            var doIt = 0;
            var greeting = "Hellow World!";

            switch (doIt)
            {

                case 0:
                    Console.WriteLine(greeting);
                    break;

                case 1:

                    Console.WriteLine("Goodbye...ruel world!!");
                    break;

                default:
                    Console.WriteLine("fallthrough...");
                    break;
            }
        }
    }
}
