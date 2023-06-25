using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Задание 2. Сложение матриц.

            Console.Write("Введите кол-во строк: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов: ");
            int B = int.Parse(Console.ReadLine());

            Random r = new Random();

            int[,] matrixA = new int[A, B];
            int[,] matrixB = new int[A, B];
            int[,] matrixC = new int[A, B];

            Console.WriteLine("matrixA:");

            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    matrixA[i, j] = r.Next(10);
                    Console.Write($"{matrixA[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("matrixB:");

            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    matrixB[i, j] = r.Next(10);
                    Console.Write($"{matrixB[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("matrixC:");

            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                    Console.Write($"{matrixC[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}
