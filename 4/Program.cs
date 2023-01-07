using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string strings = Console.ReadLine();
            string[] numberArr = strings.Split(' ');
            int[] myInts = Array.ConvertAll(numberArr, int.Parse);
            int[] cycleInts = new int[myInts.Length - 1];
            int length = cycleInts.Length;
            if (myInts.Length > 1)
            {
                for (int s1 = 0; s1 < cycleInts.Length; s1++)
                {
                    if (myInts.Length > 1)
                    {
                        for (int s2 = 0; s2 < cycleInts.Length; s2++)
                        {
                            cycleInts[s2] = myInts[s2] + myInts[s2 + 1];
                        }
                        Array.Clear(myInts, 0, myInts.Length);
                        for (int s3 = 0; s3 < cycleInts.Length; s3++)
                        {

                            myInts[s3] = cycleInts[s3];
                        }
                        if (cycleInts.Length > length)
                        {
                            Array.Clear(cycleInts, 0, cycleInts.Length);
                        }
                    }
                }
                Console.WriteLine(cycleInts[0]);
            }
            else
            {
                Console.WriteLine(myInts[0]);
            }
        }
    }
}
