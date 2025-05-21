namespace Pr5
{
    public partial class Pr5_4 : Form
    {
        public Pr5_4()
        {
            InitializeComponent();
        }
        // Статический метод для поиска максимального элемента и его индексов
        public static int FindMaxElement(int[,] array, out int max, out int row, out int col)
        {
            max = array[0, 0];
            row = 0;
            col = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        row = i;
                        col = j;
                    }
                }
            } 
       
            return max;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1 тест
            int[,] normalCase = {
                { 10, 25, 13 },
                { 19, 22, 18 },
                { 14, 27, 16 }
            };

            //// 2 тест
            //int[,] negativeNumbers = {
            //    { -11, -25, -33 },
            //    { -9, -12, -28 },
            //    { -14, -17, -6 }
            //};

            //// 2 тест
            //int[,] duplicateMaxima = {
            //    { 50, 50, 30 },
            //    { 0, 50, 80 },
            //    { 40, 40, 80 }  
            //};

            //// 3 тест
            //int[,] singleElement = { { 255 } };

            //// 4 тест
            //int[,] cornerMax = {
            //    { 6, 5, 3 },
            //    { 9, 2, 8 },
            //    { 4, 4, 999 }  
            //};

            //// 5 тест
            //int[,] zeroValues = {
            //    { 0, 0, 0 },
            //    { 0, 0, 0 },
            //    { 0, 0, 0 }
            //};

            //// 6 тест
            //int[,] largeArray = {
            //    { 1, 2, 3, 4, 5 },
            //    { 6, 7, 8, 9, 10 },
            //    { 11, 12, 13, 14, 15 },
            //    { 16, 17, 18, 19, 20 },
            //    { 21, 22, 23, 24, 25 }
            //};

            //// 7 тест
            //int[,] nonSquareArray = {
            //    { 1, 2, 3, 4, 100 },
            //    { 5, 6, 7, 8, 9 },
            //    { 10, 11, 12, 13, 14 }
            //};

            // Вызов метода с out-параметрами
           

            string arrayText = "Массив:\n";
            for (int i = 0; i < normalCase.GetLength(0); i++)
            {
                for (int j = 0; j < normalCase.GetLength(1); j++)
                {
                    arrayText += normalCase[i, j].ToString().PadLeft(3);
                }
                arrayText += "\n";
            }

            labelResult.Text = arrayText;

            int maxValue = FindMaxElement(normalCase, out int max, out int row, out int col);
            labelResult.Text += $"Максимальное: {maxValue} на позиции ({row + 1},{col + 1})";                        
        }
        private void btnRepeat_Click(object sender, EventArgs e)
        {
            labelResult.Text = null;
        }

        private void btnTransition_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain mainForm = new FormMain();
            mainForm.Show();
        }
    }
}

//удали ниже
/* 
namespace Pr5
{
    public partial class Pr5_4 : Form
    {
        private int[,] currentArray;

        public Pr5_4()
        {
            InitializeComponent();
            // Инициализация тестового массива по умолчанию
            currentArray = new int[,] {
                { 1, 5, 3 },
                { 9, 2, 8 },
                { 4, 7, 6 }
            };
            UpdateArrayInfo();
        }

        public static int FindMaxElement(int[,] array, out int rowIndex, out int colIndex)
        {
            if (array == null || array.Length == 0)
            {
                rowIndex = -1;
                colIndex = -1;
                return int.MinValue;
            }

            int max = array[0, 0];
            rowIndex = 0;
            colIndex = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        rowIndex = i;
                        colIndex = j;
                    }
                }
            }
            return max;
        }

        private void UpdateArrayInfo()
        {
            int maxValue = FindMaxElement(currentArray, out int maxRow, out int maxCol);

            string arrayText = "Текущий массив:\n";
            for (int i = 0; i < currentArray.GetLength(0); i++)
            {
                for (int j = 0; j < currentArray.GetLength(1); j++)
                {
                    arrayText += currentArray[i, j].ToString().PadLeft(3);
                }
                arrayText += "\n";
            }

            labelResult.Text = arrayText +
                $"\nМаксимальный элемент: {maxValue}" +
                $"\nПозиция: [{maxRow},{maxCol}]";
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            currentArray = new int[,] {
                { 1, 5, 3 },
                { 9, 2, 8 },
                { 4, 7, 6 }
            };
            UpdateArrayInfo();
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            currentArray = new int[,] {
                { -1, -5, -3 },
                { -9, -2, -8 },
                { -4, -7, -6 }
            };
            UpdateArrayInfo();
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            UpdateArrayInfo();
        }

        private void btnTransition_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }
    }
}
*/