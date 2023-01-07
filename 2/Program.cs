using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxCount = 0;
            int repeatingNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentCount++;
                    }
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        repeatingNumber = numbers[i];
                    }
                }
            }
            Console.WriteLine(repeatingNumber);
        }
    }
}
