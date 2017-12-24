using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace _9._1._1F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rnd_button_Click(object sender, EventArgs e)
        {
            int[,] arr2Drnd = ArrayUtils.CreateRandomArray2(inputdataGridView.RowCount, inputdataGridView.ColumnCount, 100);
            DataGridViewUtils.Array2ToGrid(inputdataGridView, arr2Drnd);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Задаём начальные пути для диалогов открытия/сохранения файла
            this.LoadFileDialog.InitialDirectory = Environment.CurrentDirectory;
            this.SaveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            // Инициализируем наши DataGridView (задаём им начальные свойства)
            DataGridViewUtils.InitGridForArr(inputdataGridView, 40, false, true, true, true, true);
            DataGridViewUtils.InitGridForArr(outputdataGridView, 40, true, true, true, true, true);
        }

       
      

      
       

        private void changebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Преобразуем содержимое нашего DataGridView в массив
                int[,] arr = DataGridViewUtils.GridToArray2<int>(inputdataGridView);

                // Создаём объект класса Array2DUtils для выполнения
                // различных операций над двумерными массивами
                ClassMatrix arrayUtils = new ClassMatrix(arr);

                // Преобразуем результат выполнения метода IncreaseElementsValue
                // в содержимое DataGridView
                DataGridViewUtils.Array2ToGrid(outputdataGridView, arrayUtils.CreateNewMatrix());
            }
            catch (Exception E)
            {
                // Если во время выполнения действий с массивом произошла ошибка,
                // то выводим её текст
                MessagesUtils.ShowError(E.Message);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Задаём начальные пути для диалогов открытия/сохранения файла
            this.LoadFileDialog.InitialDirectory = Environment.CurrentDirectory;
            this.SaveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            // Инициализируем наши DataGridView (задаём им начальные свойства)
            DataGridViewUtils.InitGridForArr(inputdataGridView, 40, false, true, true, true, true);
            DataGridViewUtils.InitGridForArr(outputdataGridView, 40, true, true, true, true, true);
        }

        private void MainMenuFileOpen_Click_1(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Преобразуем содержимое DataGridView в массив
                    int[,] arr = DataGridViewUtils.GridToArray2<int>(outputdataGridView);

                    // Записываем полученный массив в файл, предварительно
                    // преобразовав его в строку
                    FilesUtils.Write(SaveFileDialog.FileName, DataConverter.Array2DToStr<int>(arr));

                    MessagesUtils.Show("Данные сохранены");
                }
                catch (Exception E)
                {
                    MessagesUtils.ShowError("Ошибка сохранения данных");
                }
            }
        }

        private void MainMenuSaveFile_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Преобразуем содержимое DataGridView в массив
                    int[,] arr = DataGridViewUtils.GridToArray2<int>(outputdataGridView);

                    // Записываем полученный массив в файл, предварительно
                    // преобразовав его в строку
                    FilesUtils.Write(SaveFileDialog.FileName, DataConverter.Array2DToStr<int>(arr));

                    MessagesUtils.Show("Данные сохранены");
                }
                catch (Exception E)
                {
                    MessagesUtils.ShowError("Ошибка сохранения данных");
                }
            }
        }
    }
}
