namespace Pr5
{
    public partial class Pr5_6 : Form
    {
        public Pr5_6()
        {
            InitializeComponent();
        }
        // Статический метод для нахождения min и max из произвольного числа аргументов
        public static int[] FindMinMax(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return [0, 0]; 
            }

            int min = numbers[0];
            int max = numbers[0];

            foreach (int num in numbers)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            return [min, max];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Парсим введенные числа
                string[] inputs = textBox.Text.Split([' ', ','], StringSplitOptions.RemoveEmptyEntries);
                int[] numbers = Array.ConvertAll(inputs, int.Parse);

                // Получаем результат
                int[] result = FindMinMax(numbers);

                // Выводим результат
                labelResult.Text = $"Минимальное: {result[0]}, Максимальное: {result[1]}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите только целые числа, разделенные пробелами или запятыми",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Введено слишком большое или слишком маленькое число",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            labelResult.Text = "";
        }

        private void btnTransition_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain mainForm = new FormMain();
            mainForm.Show();
        } 
    }
}
