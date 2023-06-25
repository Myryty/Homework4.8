using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Задание 1. Случайная матрица

            Console.Write("Введите кол-во строк: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов: ");
            int B = int.Parse(Console.ReadLine());

            Random r = new Random();

            int[,] matrix = new int[A, B];

            int sum = 0;

            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    matrix[i, j] = r.Next(10);
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.Write($"Сумма всех элементов матрицы: {sum}");
            Console.ReadLine();






        }
    }
}
