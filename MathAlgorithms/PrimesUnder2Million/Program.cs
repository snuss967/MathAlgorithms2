using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesUnder2Million
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimesUNderTwoMillionSummnation takeSum = new PrimesUNderTwoMillionSummnation();
            takeSum.sumPrimeNumbers(2000000);
            Console.ReadLine();
        }
    }
}
