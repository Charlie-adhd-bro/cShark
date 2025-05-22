namespace Pr5
{
    partial class Pr5_6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            textBox = new TextBox();
            btnSubmit = new Button();
            labelResult = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnRepeat = new Button();
            btnTransition = new Button();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(25, 21);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(802, 64);
            label2.TabIndex = 3;
            label2.Text = "Введите произвольное количество чисел (через пробел или запятые), чтобы найти среди них минимальное и максимальное";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(6);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(19, 21, 19, 21);
            flowLayoutPanel2.Size = new Size(858, 106);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // textBox
            // 
            textBox.Location = new Point(25, 27);
            textBox.Margin = new Padding(6);
            textBox.Name = "textBox";
            textBox.Size = new Size(314, 39);
            textBox.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(351, 27);
            btnSubmit.Margin = new Padding(6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(139, 49);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Результат";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(502, 21);
            labelResult.Margin = new Padding(6, 0, 6, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 32);
            labelResult.TabIndex = 2;
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(textBox);
            flowLayoutPanel1.Controls.Add(btnSubmit);
            flowLayoutPanel1.Controls.Add(labelResult);
            flowLayoutPanel1.Controls.Add(btnRepeat);
            flowLayoutPanel1.Controls.Add(btnTransition);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 106);
            flowLayoutPanel1.Margin = new Padding(6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(19, 21, 19, 21);
            flowLayoutPanel1.Size = new Size(858, 238);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnRepeat
            // 
            btnRepeat.Location = new Point(514, 27);
            btnRepeat.Margin = new Padding(6);
            btnRepeat.Name = "btnRepeat";
            btnRepeat.Size = new Size(151, 49);
            btnRepeat.TabIndex = 3;
            btnRepeat.Text = "Сброс";
            btnRepeat.UseVisualStyleBackColor = true;
            btnRepeat.Click += btnRepeat_Click;
            // 
            // btnTransition
            // 
            btnTransition.Location = new Point(677, 27);
            btnTransition.Margin = new Padding(6);
            btnTransition.Name = "btnTransition";
            btnTransition.Size = new Size(139, 49);
            btnTransition.TabIndex = 4;
            btnTransition.Text = "Вернуться ";
            btnTransition.UseVisualStyleBackColor = true;
            btnTransition.Click += btnTransition_Click;
            // 
            // Pr5_6
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 344);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6);
            Name = "Pr5_6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pr5_6";
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox textBox;
        private Button btnSubmit;
        private Label labelResult;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnRepeat;
        private Button btnTransition;
    }
}