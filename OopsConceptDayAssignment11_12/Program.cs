﻿using System;
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
            Console.WriteLine("1.Duplicate number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
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
                    Console.WriteLine("Number of elements repeating more than once in the array: " +  DuplicateElement.RepeatedDuplicateElement(arr));
                    break;
            }
            Console.ReadLine();
        }
    }
}
