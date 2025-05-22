namespace Pr5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pr5_1 mainForm = new();
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pr5_2 mainForm = new();
            mainForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pr5_3 mainForm = new();
            mainForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pr5_4 mainForm = new();
            mainForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pr5_5 mainForm = new();
            mainForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pr5_6 mainForm = new();
            mainForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pr5_7 mainForm = new();
            mainForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
