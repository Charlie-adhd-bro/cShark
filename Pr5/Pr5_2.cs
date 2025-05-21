namespace Pr5
{
    public partial class Pr5_2 : Form
    {
        public Pr5_2()
        {
            InitializeComponent();
        }
        public static int[] GetSubArray(int[] array, int n)
        {
            int length = Math.Min(n, array.Length);

            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = array[i];
            }

            return result;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox.Text, out int n))
            {
                if (n <= 0)
                {
                    MessageBox.Show("Не натуральное число", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int[] array = new int[10];
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(-1, 10);
                }

                labelResult.Text = "\nИсходный массив: \n" + string.Join(", ", array);

                // Вывод подмассива
                labelResult.Text += "\nПодмассив: \n" + string.Join(", ", GetSubArray(array, n));
            }
            else
            {
                MessageBox.Show("Введено не число", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRepeat_Click(object sender, EventArgs e)
        {
            labelResult.Text = null;
            textBox.Clear();
        }

        private void btnTransition_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain mainForm = new();
            mainForm.Show();
        }
    }
}
