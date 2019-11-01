using System;

namespace MatrixArrayOperations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimensions of your first matrix: ");
            Console.Write("Enter the row size: ");
            int rowNumA = int.Parse(Console.ReadLine());
            Console.Write("Enter the column size: ");
            int colNumA = int.Parse(Console.ReadLine());
            Console.WriteLine("You enter a " + rowNumA + " x " + colNumA + " matrix");
            Console.WriteLine("Enter the values of your matrix starting with the first row: ");

            int[,] matrix1 = new int[rowNumA, colNumA];

            for (int i = 0; i < rowNumA; i++)
            {
                for (int j = 0; j < colNumA; j++)
                {
                    Console.Write("matrix[{0},{1}] = ", i, j);
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("You enter this matrix: ");

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write(" " + matrix1[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter the dimensions of your second matrix: ");
            Console.Write("Enter the row size: ");
            int rowNumB;
            int answer1 = int.Parse(Console.ReadLine());
            while (answer1 != rowNumA)
            {
                Console.WriteLine("The number of rows has to match the first matrix!");
                Console.Write("Enter the row size: ");
                answer1 = int.Parse(Console.ReadLine());
            }
            
            rowNumB = answer1;
            
            Console.Write("Enter the column size: ");
            int colNumB;
            int answer2 = int.Parse(Console.ReadLine());
            while (answer2 != colNumA)
            {
                Console.WriteLine("The number of colums has to match the first matrix!");
                Console.Write("Enter the col size: ");
                answer2 = int.Parse(Console.ReadLine());
            }

            colNumB = answer2;

            Console.WriteLine("You enter a " + rowNumB + " x " + colNumB + " matrix");
            Console.WriteLine("Enter the values of your matrix starting with the first row: ");

            int[,] matrix2 = new int[rowNumA, colNumA];

            for (int i = 0; i < rowNumB; i++)
            {
                for (int j = 0; j < colNumB; j++)
                {
                    Console.Write("matrix[{0},{1}] = ", i, j);
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("You enter this matrix: ");

            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(" " + matrix2[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Do you want to add these two matrix? y or n");
            string answer3 = Console.ReadLine();

            int[,] sumArray = new int[rowNumB, colNumB];
            if (answer3 == "y")
            {
                for (int i = 0; i < rowNumB; i++)
                {
                    for (int j = 0; j < colNumB; j++)
                    {
                        sumArray[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }

                Console.WriteLine("The addition of the two matrix is: ");

                for (int i = 0; i < sumArray.GetLength(0); i++)
                {
                    for (int j = 0; j < sumArray.GetLength(1); j++)
                    {
                        Console.Write(" " + sumArray[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Thanks for using my program! Good bye.");
            }
        }
    }
}
