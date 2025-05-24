namespace Pr5
{
    public partial class Pr5_7 : Form
    {
        public Pr5_7()
        {
            InitializeComponent();
        }
        public static string CharsToString(string input, params char[] chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                input += chars[i];
            }
            return input;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            try
            {
                string inputs = textBoxInput.Text;
                char[] chars = textBoxChars.Text.ToCharArray();

                if (string.IsNullOrWhiteSpace(inputs) || chars.Length == 0)
                {
                    MessageBox.Show(
                        "Оба текстовых поля должны быть заполнены",
                        "Ошибка ввода", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );
                    return;
                }

                labelResult.Text = CharsToString(inputs, chars);
                labelResult.Text += '\n' + CharsToString(inputs, '1', ' ', '2');
                labelResult.Text += '\n' + CharsToString(inputs, '1');
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        private void btnRepeat_Click(object sender, EventArgs e)
        {
            labelResult.Text = null;
            textBoxInput.Clear();
            textBoxChars.Clear();
        }
        private void btnTransition_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain mainForm = new();
            mainForm.Show();
        }

       
    }
}
