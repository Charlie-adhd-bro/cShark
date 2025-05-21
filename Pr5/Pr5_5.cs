namespace Pr5
{
    public partial class Pr5_5 : Form
    {
        public Pr5_5()
        {
            InitializeComponent();
        }

        public static int[] GenerateSequence(int start, int end)
        {
            if (start > end)
            {
                // Если начальное число больше конечного, меняем их местами
                int temp = start;
                start = end;
                end = temp;
            }

            int length = end - start + 1;
            int[] sequence = new int[length];

            for (int i = 0; i < length; i++)
            {
                sequence[i] = start + i;
            }

            return sequence;
        }

        // Перегруженный метод для символов
        public static char[] GenerateSequence(char start, char end)
        {
            if (start > end)
            {
                // Если начальный символ больше конечного, меняем их местами
                char temp = start;
                start = end;
                end = temp;
            }

            int length = end - start + 1;
            char[] sequence = new char[length];

            for (int i = 0; i < length; i++)
            {
                sequence[i] = (char)(start + i);
            }

            return sequence;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Тест с целыми числами
            int[] intSequence = GenerateSequence(2, 4);
            string result = "Целочисленный массив: " + string.Join(", ", intSequence);
            labelResult.Text = result;

            // Тест с символами
            char[] charSequence = GenerateSequence('B', 'D');
            result = "Массив символов: '" + string.Join("', '", charSequence) + "'";
            labelResult.Text += result;
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



//namespace Pr5
//{
//    public partial class Pr5_5 : Form
//    {
//        public Pr5_5()
//        {
//            InitializeComponent();
//        }

//        public static int[] GenerateSequence(int start, int end)
//        {
//            // Определяем направление последовательности
//            int step = start <= end ? 1 : -1;
//            int length = Math.Abs(end - start) + 1;

//            int[] sequence = new int[length];

//            for (int i = 0; i < length; i++)
//            {
//                sequence[i] = start + i * step;
//            }

//            return sequence;
//        }

//        public static char[] GenerateSequence(char start, char end)
//        {
//            // Определяем направление последовательности
//            int step = start <= end ? 1 : -1;
//            int length = Math.Abs(end - start) + 1;

//            char[] sequence = new char[length];

//            for (int i = 0; i < length; i++)
//            {
//                sequence[i] = (char)(start + i * step);
//            }

//            return sequence;
//        }
//        private void btnSubmit_Click(object sender, EventArgs e)
//        {
//            if (radioInt.Checked)
//            {
//                if (int.TryParse(textBoxStart.Text, out int start) &&
//                    int.TryParse(textBoxEnd.Text, out int end) &&
//                        (start > 0 && end > 0))
//                {
//                    int[] sequence = GenerateSequence(start, end);
//                    labelResult.Text = "Результат: " + string.Join(", ", sequence);
//                }
//                else
//                {
//                    MessageBox.Show("Введите корректные целые натуральные числа");
//                }
//            }
//            else if (radioChar.Checked)
//            {
//                if (char.TryParse(textBoxStart.Text, out char start) &&
//                    char.TryParse(textBoxEnd.Text, out char end))
//                {
//                    char[] sequence = GenerateSequence(start, end);
//                    labelResult.Text = "Результат: '" + string.Join("', '", sequence) + "'";
//                }
//                else
//                {
//                    MessageBox.Show("Введите корректные символы");
//                }
//            }
//        }

//        private void btnRepeat_Click(object sender, EventArgs e)
//        {
//            labelResult.Text = null;
//            textBoxStart.Text = "";
//            textBoxEnd.Text = "";

//            radioInt.Checked = false;
//            radioChar.Checked = false;
//        }

//        private void btnTransition_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            FormMain mainForm = new FormMain();
//            mainForm.Show();
//        }
//    }
//}

