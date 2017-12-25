using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;


namespace _9._1._1_C_
{
    class Program

    {
        public static bool AskQuestion(string question)
        {
            while (true)
            {
                Console.Write(question);
                string answer = Console.ReadLine();

                if (answer == "y" || answer == "n")
                    return answer == "y";
            }
        }

        // Читаем массив из файла
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

        static int[,] ReadArrFromConsole()
        {
            return IOUtils.ReadArray2DFromConsole<int>("массив чисел");
        }

        public static void SaveResultToFile(string answer)
        {
            while (true)
            {
                try
                {
                    string filePath = IOUtils.ReadValueFromConsole<string>("путь к выходному файлу");

                    // Записываем данные в файл и выйти из метода
                    FilesUtils.Write(filePath, answer);
                    return;
                }
                catch (Exception e)
                {
                    // Если во время считывания из файла ошибка, то выводим её,
                    // а затем просим ввести путь ещё раз
                    IOUtils.ShowError("Невозможно записать данные в этот файл");
                }
            }
        }

       
        

        static void Main(string[] args)
        {

            while (true)
            {

       
                int[,] matrix;

            
               
                if (AskQuestion("считать с файла? y/n  "))
                {

                    matrix = ReadArrFromFile();

                }
                else
                {
                    matrix = ReadArrFromConsole();
                }

                ClassMatrix arr2 = new ClassMatrix(matrix);
                string result = DataConverter.Array2DToStr(arr2.CreateNewMatrix());

                Console.WriteLine("Результат");
                Console.WriteLine(result);

               
                if (AskQuestion("сохранить в файл? y/n  "))
                {
                    SaveResultToFile(result);
                }
            }













        }
    }
}
