using System;

namespace tic_tac_toe___arrays
{
    class Program
    {

        static int[,] matrix =
           {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 },
            };

        static void Main(string[] args)
        {
            //using foreach
            foreach (int item in matrix)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine("\n");
            Console.ReadKey();

            //using nested for loop
            for (int i = 0; i < matrix.GetLength(0); i++)//GetLenght(0) - will give the number of rows (lenght of the first dimention - rows)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//GetLenght(0) - will give the number of collumns (lenght of the second dimention - collumns)
                {
                    //printing even only
                    if (matrix[i, j] % 2 == 0)
                    {
                        Console.Write(matrix[i, j]);
                    }

                }

            }
            Console.WriteLine("\n");
            for (int i = 0; i < matrix.GetLength(0); i++)//GetLenght(0) - will give the number of rows (lenght of the first dimention - rows)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//GetLenght(0) - will give the number of collumns (lenght of the second dimention - collumns)
                {

                    //printing diagonal only
                    //1,5,9
                    if (i == j)
                    {
                        Console.Write(matrix[i, j]);
                    }

                }

            }
            Console.WriteLine("\n");
            for (int i = 0; i < matrix.GetLength(0); i++)//GetLenght(0) - will give the number of rows (lenght of the first dimention - rows)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)//GetLenght(0) - will give the number of collumns (lenght of the second dimention - collumns)
                {

                    //printing diagonal only
                    //1,5,9


                }

            }
            Console.ReadKey();
        }
    }
}