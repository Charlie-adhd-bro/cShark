namespace Pr5
{
    partial class Pr5_2
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
            label2.Size = new Size(125, 32);
            label2.TabIndex = 3;
            label2.Text = "Введите n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(6);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(19, 21, 19, 21);
            flowLayoutPanel2.Size = new Size(369, 67);
            flowLayoutPanel2.TabIndex = 5;
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
            btnSubmit.Location = new Point(25, 78);
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
            labelResult.Location = new Point(176, 72);
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
            flowLayoutPanel1.Location = new Point(0, 67);
            flowLayoutPanel1.Margin = new Padding(6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(19, 21, 19, 21);
            flowLayoutPanel1.Size = new Size(369, 407);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnRepeat
            // 
            btnRepeat.Location = new Point(188, 78);
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
            btnTransition.Location = new Point(25, 139);
            btnTransition.Margin = new Padding(6);
            btnTransition.Name = "btnTransition";
            btnTransition.Size = new Size(139, 49);
            btnTransition.TabIndex = 4;
            btnTransition.Text = "Вернуться ";
            btnTransition.UseVisualStyleBackColor = true;
            btnTransition.Click += btnTransition_Click;
            // 
            // Pr5_2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 474);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(6);
            Name = "Pr5_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pr5_2";
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
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