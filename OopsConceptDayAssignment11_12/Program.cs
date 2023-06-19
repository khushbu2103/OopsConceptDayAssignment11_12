using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptDayAssignment11_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("please Choose any Program");
            Console.WriteLine("1.Duplicate number\n2.Unique Elements\n3.Frequency of elements\n4.Minimum and Maximum in Array");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the size of array");
            int len = Convert.ToInt32(Console.ReadLine()); //length of array
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write("Enter element number {0} of array:", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            switch (option)
            {
                case 1:
                    Console.WriteLine("Number of elements repeating more than once in the array: " +  ArrayPrograms.RepeatedDuplicateElement(arr));
                    break;
                case 2:
                    ArrayPrograms.NonRepeatedUniqueElements(arr);
                    break;
                case 3:
                    int n = arr.Length;
                    ArrayPrograms.FrequencyOfElements(arr, n);
                    break;
                case 4:
                    ArrayPrograms.MinMaxOfArray(arr);
                    break;
            }
            Console.ReadLine();
        }
    }
}
