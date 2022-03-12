using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCol = GetValidInputInt("Enter number of columns: ");
            int numOfRow = GetValidInputInt("Enter number of rows: ");
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
                    matrix[i, j] = rd.Next(10, 30);
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
