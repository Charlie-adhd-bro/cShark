namespace Pr5
{
    public partial class Pr5_3 : Form
    {
        private char[] charArray = new char[10];
        private int currentIndex = 0;

        public Pr5_3()
        {
            InitializeComponent();
        }

        public static int[] GetCharCodes(char[] array)
        {
            int[] codes = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                codes[i] = (int)array[i];
            }
            return codes;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (currentIndex >= charArray.Length)
            {
                MessageBox.Show("Массив заполнен!", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (textBox.Text.Length == 1)
            {
                charArray[currentIndex] = textBox.Text[0];
                currentIndex++;

                labelResult.Text = "Текущий массив:\n " +
                    string.Join(", ", charArray.Take(currentIndex).Select(c => $"'{c}'"));

                labelInstructions.Text = $"Осталось символов: {charArray.Length - currentIndex}";
                textBox.Clear();

                int[] codes = GetCharCodes(charArray);
                labelResult.Text += $"\nКоды символов:\n{string.Join(", ", codes)}";
                
            }
            else
            {
                MessageBox.Show("Введите ровно один символ!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            charArray = new char[10];
            currentIndex = 0;
            labelInstructions.Text = "Введите символы (осталось: 10)";
            labelResult.Text = "";
            textBox.Clear();
        }

        private void btnTransition_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }
    }
}
