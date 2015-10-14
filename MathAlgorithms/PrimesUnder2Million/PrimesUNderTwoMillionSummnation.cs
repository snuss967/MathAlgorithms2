using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesUnder2Million
{
    class PrimesUNderTwoMillionSummnation
    {
        public void sumPrimeNumbers(long toWhatNumber)
        {
            long total = 28;
            long i;
            bool flag = false;
            for (i = 13; i < toWhatNumber + 1; i++)
            {
                int upperBound = (int)Math.Sqrt(i) + 1;
                flag = false;
                for (long j = 2; j < upperBound; j++)
                {
                    if (i % j == 0)
                    {
                        flag = true;
                        j = i;
                    }
                }
                
                if (!flag)
                {
                   
                    total += i;
                    

                }
                if (i == toWhatNumber)
                {
                    Console.WriteLine(total);
                    Console.ReadLine();
                    Environment.Exit(1);
                }
            }
        }
    }
}
