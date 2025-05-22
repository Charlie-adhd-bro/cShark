namespace Pr5
{
    public partial class Pr5_1 : Form
    {
        public Pr5_1()
        {
            InitializeComponent();
        }
        static int DoubleFactorialRecursive(int n)
        {
            if (n <= 1)
                return 1;
            return n * DoubleFactorialRecursive(n - 2);
        }
        static int DoubleFactorialIterative(int n)
        {
            if (n <= 1)
                return 1;
            int result = 1;
            for (int i = n; i > 0; i -= 2)
            {
                result *= i;
            }
            return result;
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string choice = "";
            while (true)
            {
                if (radioBtnRecursion.Checked)
                {
                    choice = "with recursion"; break;
                }
                else if (radioBtnWithoutRecursion.Checked)
                {
                    choice = "without recursion"; break;
                }

                else
                {
                    MessageBox.Show("Выберите один из циклов", "не выбрано",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int n;
            if (!Int32.TryParse(txtInput.Text, out n) || n < 0)
            {
                MessageBox.Show("Введите корректное число\n" +
                    "(больше или равно нулю, целое)", "Неккоректный ввод",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (choice)
            {
                case "with recursion":
                    string result = "Двойной факториал через рекурсию:\n"
                        + DoubleFactorialRecursive(n).ToString();
                    labelResult.Text = result;
                    break;
                case "without recursion":
                    result = "Двойной факториал без рекурсии:\n"
                        + DoubleFactorialIterative(n).ToString();
                    labelResult.Text = result;
                    break;
            }

        }

        private void BtnRepeat_Click(object sender, EventArgs e)
        {
            labelResult.Text = null;
            txtInput.Clear();

            radioBtnRecursion.Checked = false;
            radioBtnWithoutRecursion.Checked = false;
        }
        private void Btn_transition_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain mainForm = new();
            mainForm.Show();
        }
    }
}
