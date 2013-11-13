using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace echo
{
    class Program
    {
        private static void Main(string[] args)
        {
            //create an array  - knows it size...unlike a list which can grow and shrink
            var attendees = new[] { "mike", "Mark", "Mark", "Jacob" };
            
            foreach(var name in attendees)
            {
                Console.WriteLine(name);

            }

            var i = 0;
            while (i < 10)
            {
                Console.WriteLine("try and stop me! (i = " +  i++ + ")");
                //i++;
                //i = i + 1;   These are equivalent
                //i += 1;
            }
            
           
        }
    }
}
