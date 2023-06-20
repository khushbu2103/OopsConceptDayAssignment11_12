using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OopsConceptDayAssignment11_12
{
    internal class ArrayPrograms
   {


        public static int RepeatedDuplicateElement(int[] arr)
        {

            //int[] arr = new int[] { 1, 2, 3, 4, 5, 2, 3, 4, 2, 3, 3, 0, 0 };
            int[] duplicateElements = new int[arr.Length];
            int duplicateCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate)
                {
                    bool alreadyCounted = false;
                    for (int k = 0; k < duplicateCount; k++)
                    {
                        if (arr[i] == duplicateElements[k])
                        {
                            alreadyCounted = true;
                            break;
                        }
                    }
                    if (!alreadyCounted)
                    {
                        duplicateElements[duplicateCount] = arr[i];
                        duplicateCount++;
                    }
                }
            }
            
            return duplicateCount;
        }

        public static void NonRepeatedUniqueElements(int[] arr)
        {
            int len = arr.Length;
            Console.WriteLine("The unique elements in the array are: ");
            for (int i = 0; i < len; i++)
            {
                bool isUnique = true;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.WriteLine(arr[i]);

                }

            }

        }

        public static void FrequencyOfElements(int[] arr, int num)
        {
            bool[] visited = new bool[num];
           // Array.(visited, false);
            Console.WriteLine("The unique elements in the array are: ");
            for (int i = 0; i < num; i++)
            {
              if (visited[i] == true)
                {
                    continue;
                }
                int count = 1;
                for (int j = i + 1; j < num; j++)
                {  
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        count++;
                        break;
                    }
                }
                Console.WriteLine(arr[i] + " " + count);

            }

        }

        public static void MinMaxOfArray(int[] arr)
        {
            int len = arr.Length;
           
            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine("Maximum element: " + max);
            Console.WriteLine("Minimum element: " + min);

        }

        public static void RightTrianglePattern(int n2)
        {
            for(int i = 0; i < n2; i++)
            {
                for( int j = i; j < n2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void SquarePattern(int n3)
        {
            for (int i = 0; i < n3; i++)
            {
                for (int j = 0; j < n3; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("*");
                        continue;
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        internal static string ReverseEachWordAtItsPosition(string input)
        {
            char[] delimiters = new char[] { ' ', ',', '.', ';', ':', '!', '?' };
            string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseString(words[i]);
            }
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                result += words[i];
                result += " ";
            }
            return result;
        }

        internal static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            int len = s.Length - 1;
            for (int i = 0; i < len; i++, len--)
            {
                char temp = charArray[i];
                charArray[i] = charArray[len];
                charArray[len] = temp;
            }
            return new string(charArray);
        }
    }
    
}
