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
            int step = start <= end ? 1 : -1;
            int length = Math.Abs(end - start) + 1;
            int[] sequence = new int[length];

            for (int i = 0; i < length; i++)
                sequence[i] = start + i * step;

            return sequence;
        }


        public static char[] GenerateSequence(char start, char end)
        {
            int step = start <= end ? 1 : -1;
            int length = Math.Abs(end - start) + 1;
            char[] sequence = new char[length];

            for (int i = 0; i < length; i++)
                sequence[i] = (char)(start + i * step);

            return sequence;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radioInt.Checked)
            {
                if (int.TryParse(textBoxStart.Text, out int start) &&
                    int.TryParse(textBoxEnd.Text, out int end)
                    )
                {
                    labelResult.Text = "Результат: " + string.Join(", ", GenerateSequence(start, end));
                }
                else
                {
                    MessageBox.Show(
                        "Введите корректные целые числа", 
                        "Ошибка ввода",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );
                }
            }
            else if (radioChar.Checked)
            {
                if (char.TryParse(textBoxStart.Text, out char start) &&
                    char.TryParse(textBoxEnd.Text, out char end))
                {
                    labelResult.Text = "Результат: '" + string.Join("', '", GenerateSequence(start, end)) + "'";
                }
                else
                {
                    MessageBox.Show(
                        "Введите корректные символы\n(по одному в текстовых полях)", 
                        "Ошибка ввода",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Выберите радиокнопку", 
                    "не выбрано",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            textBoxStart.Text = "";
            textBoxEnd.Text = "";
            radioInt.Checked = false;
            radioChar.Checked = false;
        }

        private void btnTransition_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }
    }
}