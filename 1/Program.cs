using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringArr = Console.ReadLine();
            string[] arr = stringArr.Split(' ');
            int[] myInts = Array.ConvertAll(arr, int.Parse);
            int min = int.MaxValue;
            int max = int.MinValue;
            double sum = 0;
            double avg = 0;
            for (int s1 = 0; s1 < arr.Length; s1++)
            {
                if (myInts[s1] < min)
                {
                    min = myInts[s1];
                }
                if (myInts[s1] > max)
                {
                    max = myInts[s1];
                }
                sum = sum + myInts[s1];
            }
            avg = sum / myInts.Length;
            Console.WriteLine("Min : {0}", min);
            Console.WriteLine("Max : {0}", max);
            Console.WriteLine("Sum : {0}", sum);
            Console.WriteLine("Average : {0}", avg);
        }
    }
}
