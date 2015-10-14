using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneThousandDigitFibonacciNumbe
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate1000thTerm calc = new Calculate1000thTerm();
            calc.calculate();
            Console.ReadLine();
        }

        private static void calculateFibonanci()
        {
            double hugeNumber = Math.Pow(10, 1000);
            Console.WriteLine(hugeNumber);
            double firstNum = 0;
            double secondNum = 1;
            double total = 0;
            for (int i = 0; i < hugeNumber; i++)
            {
                Console.Write(i + ":");
                if (i == 0)
                {
                    Console.WriteLine(firstNum);
                }
                else if (i == 1)
                {
                    Console.WriteLine(secondNum);
                }
                
                else
                {
                    total = firstNum + secondNum;
                    firstNum = secondNum;
                    secondNum = total;
                    Console.WriteLine(total);

              }
                Console.ReadLine();

            }
        }
    }
}
