namespace Pr5
{
    public partial class Pr5_4 : Form
    {
        public Pr5_4()
        {
            InitializeComponent();
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1 тест
            //int[,] array = {
            //    {2, 4, 6}
            //};

            // 2 тест
            //int[,] array = { };

            //3 тест
            int[,] array = {
            {4, 9, 2},
            {9, 5, 3},
            {1, 9, 0}
            };

            //4 тест

            //5 тест
            if (array.Length == 0)
            {
                MessageBox.Show("Массив пуст", "не выбрано",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int maxValue = FindMaxElement(array, out int maxRow, out int maxCol);

                string arrayText = "Текущий массив:\n";
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        arrayText += array[i, j].ToString().PadLeft(3) + "";
                    }
                    arrayText += "\n";
                }

                labelResult.Text = arrayText +
                    $"\nМаксимальный элемент: {maxValue}" +
                    $"\nПозиция: [{maxRow},{maxCol}]";
            }
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
