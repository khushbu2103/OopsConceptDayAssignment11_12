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
    }
    
}
