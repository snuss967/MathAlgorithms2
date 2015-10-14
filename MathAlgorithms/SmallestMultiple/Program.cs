using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultiple
{
    class Program
    {
        public static long calculateFactorial(int upUntil)
        {
            //calculate Facotrial upUntil @param upUntil
            upUntil += 1;
            long total = 1;
            for (int i = 1; i < upUntil; i++)
            {
                total *= i;
            }
            Console.WriteLine(total);
            return (total);
        } 
        static void Main(string[] args)
        {
            int primeTo20 = (1 * 2 * 3 * 5 * 7 * 11 * 13 * 17 * 19);
            long factorial = calculateFactorial(20);
            for (int i = primeTo20; i < factorial; i++)
            {
                int num = i * 20; // = i * 20;
                if (num % 19 == 0)
                {
                        if (num % 17 == 0)
                        {
                            if (num % 13 == 0)
                            {
                                if (num % 11 == 0)
                                {
                                    if (num % 9 == 0)
                                    {
                                        if (num % 8 == 0)
                                        {
                                            if (num % 7 == 0)
                                            {
                                                if (num % 5 == 0)
                                                {
                                                    Console.WriteLine(num);
                                                    Console.ReadLine();
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
