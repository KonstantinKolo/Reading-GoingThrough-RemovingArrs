using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (char letter in input)
            {
                Console.WriteLine("{0} - {1}", letter, letter - 'a');
            }
        }
    }
}
