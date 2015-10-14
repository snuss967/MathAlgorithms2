using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LargestPalindrome
{
    class CalculateLargestPalindrome
    {
        int largestNum = 0;
	//the basis for our comparison largest number it isnt anything yet so we set it to 0 as we know that all of our numbers will be greater than 0
        //@param max is the value that we will run our multiplication up to ie max * max
	public void Calculate(int max)
        {
		//calculates the largest palindrome

            int total = 1;
            for (int i = max; i > 0; i--)
            {
                for (int j = max; j > 0; j--)
                {
			//loops through the second and first sets of numbers
                    total = (i * j);
			//the total of i times j
                    string totalForComparison = total.ToString();
                    int length = totalForComparison.Length;
                    int perSide = length / 2;
                    bool flag = false;
                    for (int k = 0, l = length -1; k < perSide; k++)
                    {
			/* We convert the number to a string so that we can use the number as an array
				we then compare the values at the indices for k the beginning working forwards and for
				l the end working backwards if the match then it is a palindrome. Finally we are able
				to say that with numbers with an odd number of digits the middle digit does not matter and thus we can disregard
				Hence why we can divide with integer division and not worry about the remainder. 
                        /* Console.WriteLine(totalForComparison[l]);
                         Console.WriteLine(totalForComparison[k]);
                         Console.WriteLine(totalForComparison);
                         Console.ReadLine();
			Debugging Information
				*/
                        if (totalForComparison[k] == totalForComparison[l])
                        {

                            flag = true;
                        }
                        else
                        {
                            flag = false;
                            k = perSide;
                        }
                        l--;
                    }
                    if (flag)
                    {
                        if (total > largestNum)
                        {
                            largestNum = total;
                        }
                    }
                }
            }
            Console.WriteLine(largestNum);
            Console.ReadLine();
        }
    }
}
