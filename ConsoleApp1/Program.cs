using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace ConsoleApp1
{
    class Program
    {
        static int[,] ReadArrFromConsole(int[, ]matrix)
        {
            Console.Write(" ");
            string FromFile = Console.ReadLine();
            return ArrayUtils.CreateRandomArray2(matrix.GetLength(0), matrix.GetLength(1), n);
        }

        static int[,] ReadArrFromFile()
        {
            while (true)
            {
                try
                {
                    string filePath = IOUtils.ReadValueFromConsole<string>("путь к входному файлу");

                    //  Считываем данные из файла, преобразовываем их в массив
                    // и возвращаем вызывающему коду
                    string arrText = FilesUtils.Read(filePath);
                    return DataConverter.StrToArray2D<int>(arrText);
                }
                catch (Exception e)
                {
                    // Если во время считывания из файла ошибка, то выводим её,
                    // а затем просим ввести путь ещё раз
                    IOUtils.ShowError("Невозможно считать данные из этого файла");
                }
            }
        }


        static void Main(string[] args)
        {
            int[,] matrix;

            // Спрашиваем у пользователя, будет ли он читать данные из файла
            Console.Write("Считать из файла (yes/no): ");
            string FromFile = Console.ReadLine();

            if (FromFile == "yes")
            {

                matrix = ReadArrFromFile();

            }
            else
            {
                matrix = ReadArrFromConsole();
            }
        }
    }
}
