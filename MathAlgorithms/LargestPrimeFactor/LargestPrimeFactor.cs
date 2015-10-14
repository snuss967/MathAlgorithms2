using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    class LargestPrimeFactor
    {
        public void Factorization(long largeNumber)
        {
            long upperBound = (long)Math.Sqrt(largeNumber);
            Console.WriteLine(upperBound);

            for (long i = 1;  i < upperBound; i++)
			    {
                Console.WriteLine(i);
                if (largeNumber % i == 0)
                {
                    Console.WriteLine(i);
                    int newUpperBound = (int)Math.Sqrt(i);
                    bool flag = false;
                    for (int j = 2; j < newUpperBound; j++)
                    {
                        if (i % j == 0)
                        {
                            j = newUpperBound;
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        Console.WriteLine(i);
                        Console.ReadLine();
                    }
                    {

                    }
                   
                }
			    }
            Console.WriteLine(largeNumber);
            Console.ReadLine();

        }
    }
}
