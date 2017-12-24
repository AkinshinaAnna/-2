using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClassMatrix
    {
        public int[,] matrix { get; set; }

        public ClassMatrix (int[,] matrix)
        {
            this.matrix = matrix;
        }

        // 	Первый столбец с минимальной суммой элементов поменять местами с последним столбцом 
        // с максимальной суммой элементов
        private static int ColSum(int[,] table, int colIndex)
        {
            int result = 0;
            for (int r = 0; r < table.GetLength(0); r++)
                result += table[r, colIndex];
            return result;
        }

        private static int IndexOfMaxColSum(int[,] table)
        {
            int maxColIndex = 0,
                maxSum = ColSum(table, 0);
            for (int c = 1; c < table.GetLength(1); c++)
            {
                int sum = ColSum(table, c);
                if (sum >= maxSum)
                {
                    maxSum = sum;
                    maxColIndex = c;
                }
            }

            return maxColIndex;
        }

        private static int IndexOfMinColSum(int[,] table)
        {
            int minColIndex = 0,
                minSum = ColSum(table, 0);
            for (int c = 1; c < table.GetLength(1); c++)
            {
                int sum = ColSum(table, c);
                if (sum < minSum)
                {
                    minSum = sum;
                    minColIndex = c;
                }
            }

            return minColIndex;
        }

        private static void Replace(int[,] table)
        {
            int minColIndex = IndexOfMinColSum(table);
            int maxColIndex = IndexOfMaxColSum(table);
            for (int r = 0; r < table.GetLength(0); r++)
            {

                int c = table[r, minColIndex];
                table[r, minColIndex] = table[r, maxColIndex];
                table[r, maxColIndex] = c;
            }
        }
        // главная функция, которая создает новый массив, у которого перемещены столбцы
        public  int[,] CreateNewMatrix()
        {
          
          int[,] NewMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
           for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    NewMatrix[r, c] = matrix[r, c];
                }
            }
            Replace(NewMatrix);
            return NewMatrix;
            
        }




        // конец задачи

      


    }
}
