using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptDayAssignment11_12
{
    internal class Matrix
    {
        public void Run()
        {
            int sum = 0;
            int row = 0;
            int col = 0;
            int[,] Matrix;
            Random rand = new Random();

            Console.WriteLine("Enter the number of rows in the matrix: ");
            row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns in the matrix: ");
            col = Convert.ToInt32(Console.ReadLine());

            Matrix = new int[row, col];

           

                Console.WriteLine("Do you want to print the default matrix? (y/n)");
                string printChoice = Console.ReadLine();

                if (printChoice == "y")
                {
                    Console.WriteLine("The default matrix is: ");
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Console.Write(Matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter the elements of the matrix: ");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write("Enter element at row " + (i + 1) + ", column " + (j + 1) + ": ");
                        Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("The sum of each row of the matrix is: ");
            for (int i = 0; i < row; i++)
            {
                sum = 0;
                for (int j = 0; j < col; j++)
                {
                    sum += Matrix[i, j];
                }
                Console.WriteLine("Sum of row " + (i + 1) + " is: " + sum);
            }
        }
    }
}
