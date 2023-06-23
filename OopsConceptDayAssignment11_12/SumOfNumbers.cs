using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptDayAssignment11_12
{
    internal class SumOfNumbers
    {
        public static void SumOfDigits(int num) //45
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10; //4 
            }
            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}
