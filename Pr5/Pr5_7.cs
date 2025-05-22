

namespace Pr5
{
    public partial class Pr5_7 : Form
    {
        public Pr5_7()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
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
