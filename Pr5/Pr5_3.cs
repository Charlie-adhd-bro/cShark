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

        public static int[] GetCharCodes(char[] array, int length)
        {
            int[] codes = new int[length];
            for (int i = 0; i < length; i++)
            {
                codes[i] = (int)array[i];
            }
            return codes;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string inputText = textBox.Text;
            if (string.IsNullOrEmpty(inputText))
            {
                MessageBox.Show(
                    "Текстовое поле пустое, введите хотя бы один символ", 
                    "Ошибка",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                );
                return;
            }

            foreach (char c in inputText)
            {
                if (currentIndex >= charArray.Length)
                {
                    MessageBox.Show(
                        "Массив заполнен!", 
                        "Информация",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    break;
                }

                charArray[currentIndex] = c;
                currentIndex++;
            }

            string[] formattedChars = new string[currentIndex];

            for (int i = 0; i < currentIndex; i++)
            {
                formattedChars[i] = $"'{charArray[i]}'";
            }

            string resultString = string.Join(", ", formattedChars);

            labelResult.Text = "Текущий массив:\n " + resultString;
            labelResult.Text += $"\nКоды символов:\n" +
                $"{string.Join(", ", GetCharCodes(charArray, currentIndex))}";

            labelInstructions.Text = $"Осталось символов: {charArray.Length - currentIndex}";
            textBox.Clear();       
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
