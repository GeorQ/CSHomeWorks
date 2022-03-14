using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCol;
            int numOfRow;

            do
            {
                numOfCol = GetValidInputInt("Enter number of columns it should be non negative int which is bigger than 0:  ");
            } while (numOfCol <= 0);


            do
            {
                numOfRow = GetValidInputInt("Enter number of rows it should be non negative int which is bigger than 0:  ");
            } while (numOfRow <= 0);

            int[,] mat = RandomMatrixGenerator(numOfCol, numOfRow);
            PrintMatrix(mat);
            Console.WriteLine($"The matrix sum is {GetMatrixSum(mat)}");
        }
        
        static int GetValidInputInt(string message)
        {
            int temp;
            do
            {
                Console.Write(message);
            } while (!Int32.TryParse(Console.ReadLine(), out temp));
            return temp;
        }

        static int[,] RandomMatrixGenerator(int col, int row)
        {
            Random rd = new Random();
            int[,] matrix = new int[row, col];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rd.Next();
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        
        static int GetMatrixSum(int[,] matrix)
        {
            int temp = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    temp += matrix[i, j];
                }
            }
            return temp;
        }
    }
}
