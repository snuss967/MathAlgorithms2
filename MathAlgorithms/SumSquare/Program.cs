using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            long total = computeSquareOfSum(100) - computeSquareSum(100);
            Console.WriteLine(total);
            Console.ReadLine();
        }

        private static long computeSquareSum(int numberUntil)
        {
            long total = 0;
            for (int i = 1 ; i < numberUntil + 1; i++)
            {
                total +=  (long)Math.Pow(i, 2);
            }
            return total;
        }

        private static long computeSquareOfSum(int numberUntil)
        {
            int addEmUp = 0;
            for (int i = 0; i < numberUntil +1; i++)
            {
                addEmUp += i;
            }

            long powerOf = (long)Math.Pow(addEmUp, 2);
            return powerOf;
        }
    }
}
