namespace Pr5
{
    public partial class Pr5_3 : Form
    {
        public Pr5_3()
        {
            InitializeComponent();
            labelInstructions.Text = "Символьный массив, \nпреобразованный в массив кодов";
        }

        // Статический метод для преобразования символьного массива в массив кодов
        public static int[] CharCodesToArray(char[] charArray)
        {
            int[] result = new int[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                result[i] = (int)charArray[i]; // Получаем код символа
            }
            return result;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Создаем тестовый символьный массив
            char[] charArray = { 'A', 'B', 'C', 'a', 'b', 'c', '1', '2', '3', '!' };

            // Преобразуем в массив кодов
            int[] codeArray = CharCodesToArray(charArray);

            // Выводим результаты
            labelResult.Text = "Символьный массив:\n" + string.Join(", ", charArray);
            labelResult.Text += "\n\nМассив кодов:\n" + string.Join(", ", codeArray);
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

//namespace Pr5
//{
//    public partial class Pr5_3 : Form
//    {
//        private char[] charArray = new char[10];
//        private int currentIndex = 0;

//        public Pr5_3()
//        {
//            InitializeComponent();
//            labelInstructions.Text = "Введите символы один за другим (осталось: 10)";
//        }

//        public static int[] CharCodesToArray(char[] array)
//        {
//            int[] result = new int[array.Length];
//            for (int i = 0; i < array.Length; i++)
//            {
//                result[i] = array[i]; // Автоматическое преобразование char → int
//            }
//            return result;
//        }

//        private void btnSubmit_Click(object sender, EventArgs e)
//        {
//            if (currentIndex >= charArray.Length)
//            {
//                MessageBox.Show("Массив заполнен!", "Информация",
//                    MessageBoxButtons.OK, MessageBoxIcon.Information);
//                return;
//            }

//            if (textBox.Text.Length == 1)
//            {
//                charArray[currentIndex] = textBox.Text[0];
//                currentIndex++;

//                // Правильное отображение массива символов
//                labelResult.Text = "Текущий массив: " +
//                    string.Join(", ", charArray.Take(currentIndex).Select(c => $"'{c}'"));

//                labelInstructions.Text = $"Осталось символов: {charArray.Length - currentIndex}";
//                textBox.Clear();

//                if (currentIndex == charArray.Length)
//                {
//                    int[] codes = CharCodesToArray(charArray);
//                    labelResult.Text += $"\n\nКоды символов:\n{string.Join(", ", codes)}";
//                }
//            }
//            else
//            {
//                MessageBox.Show("Введите ровно один символ!", "Ошибка",
//                    MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void btnRepeat_Click(object sender, EventArgs e)
//        {
//            charArray = new char[10];
//            currentIndex = 0;
//            labelInstructions.Text = "Введите символы (осталось: 10)";
//            labelResult.Text = "";
//            textBox.Clear();
//        }

//        private void btnTransition_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            new FormMain().Show();
//        }
//    }
//}