using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var result = rnd.Next(10);
            Console.WriteLine(result);

            // pause to see the random number
            Console.ReadLine();
        }
    }
}
