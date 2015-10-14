using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneThousandDigitFibonacciNumbe
{
    class Calculate1000thTerm
    {
        double total = 0;
        public void calculate()
        {
            double phi = ((1 + Math.Sqrt(5)) / 2);
            total = Math.Ceiling(((1000 - 1 + (Math.Log10(5) / 2)) / (Math.Log10(phi))));
            Console.WriteLine(total);
        } 

    }
}
