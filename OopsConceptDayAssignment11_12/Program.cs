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
            Console.WriteLine("1.Duplicate number\n" +
                "2.Unique Elements\n" +
                "3.Frequency of elements\n" +
                "4.Minimum & Maximum or array\n" +
                "5.Right angle pattern\n" +
                "6.Square star pattern\n" +
                "7. Reverse each words in string");
            int option = Convert.ToInt32(Console.ReadLine());
           
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the size of array");

                    int len = Convert.ToInt32(Console.ReadLine()); //length of array
                    int[] arr = new int[len];
                    for (int i = 0; i < len; i++)
                    {
                        Console.Write("Enter element number {0} of array:", i + 1);
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Number of elements repeating more than once in the array: " +  ArrayPrograms.RepeatedDuplicateElement(arr));
                    break;
                case 2:
                    Console.WriteLine("Enter the size of array");
                    int length = Convert.ToInt32(Console.ReadLine()); //length of array
                    int[] arrary = new int[length];
                    for (int i = 0; i < length; i++)
                    {
                        Console.Write("Enter element number {0} of array:", i + 1);
                        arrary[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    ArrayPrograms.NonRepeatedUniqueElements(arrary);
                    break;
                case 3:
                    Console.WriteLine("Enter the size of array");
                    int length2 = Convert.ToInt32(Console.ReadLine()); //length of array
                    int[] array2 = new int[length2];
                    for (int i = 0; i < length2; i++)
                    {
                        Console.Write("Enter element number {0} of array:", i + 1);
                        array2[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    int n = array2.Length;
                    ArrayPrograms.FrequencyOfElements(array2, n);
                    break;
                case 4:
                    Console.WriteLine("Enter the size of array");
                    int length3 = Convert.ToInt32(Console.ReadLine()); //length of array
                    int[] array3 = new int[length3];
                    for (int i = 0; i < length3; i++)
                    {
                        Console.Write("Enter element number {0} of array:", i + 1);
                        array3[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    ArrayPrograms.MinMaxOfArray(array3);
                    break;
                case 5:
                    Console.WriteLine("Enter number of elements required in first row of pattern");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    ArrayPrograms.RightTrianglePattern(n2);
                    break;
                case 6:
                    Console.WriteLine("Enter number of elements required in first row of pattern");
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    ArrayPrograms.SquarePattern(n3);
                    break;
                case 7:
                    Console.Write("Enter a string: ");
                    string input = Console.ReadLine();
                    string result = ArrayPrograms.ReverseEachWordAtItsPosition(input);
                    Console.WriteLine(result);
                    break;
            }
            Console.ReadLine();
        }
    }
}
