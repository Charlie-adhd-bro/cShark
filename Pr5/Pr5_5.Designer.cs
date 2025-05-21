namespace Pr5
{
    partial class Pr5_5
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
            textBoxStart = new TextBox();
            btnSubmit = new Button();
            labelResult = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnRepeat = new Button();
            btnTransition = new Button();
            radioInt = new RadioButton();
            radioChar = new RadioButton();
            textBoxEnd = new TextBox();
            label1 = new Label();
            label3 = new Label();
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
            label2.Size = new Size(182, 32);
            label2.TabIndex = 3;
            label2.Text = "Вывод массива";
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
            flowLayoutPanel2.Size = new Size(378, 67);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(188, 27);
            textBoxStart.Margin = new Padding(6);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(151, 39);
            textBoxStart.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(25, 171);
            btnSubmit.Margin = new Padding(6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(151, 49);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Результат";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(351, 165);
            labelResult.Margin = new Padding(6, 0, 6, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 32);
            labelResult.TabIndex = 2;
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBoxStart);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(textBoxEnd);
            flowLayoutPanel1.Controls.Add(radioInt);
            flowLayoutPanel1.Controls.Add(radioChar);
            flowLayoutPanel1.Controls.Add(btnSubmit);
            flowLayoutPanel1.Controls.Add(btnRepeat);
            flowLayoutPanel1.Controls.Add(labelResult);
            flowLayoutPanel1.Controls.Add(btnTransition);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 67);
            flowLayoutPanel1.Margin = new Padding(6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(19, 21, 19, 21);
            flowLayoutPanel1.Size = new Size(378, 480);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btnRepeat
            // 
            btnRepeat.Location = new Point(188, 171);
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
            btnTransition.Location = new Point(25, 232);
            btnTransition.Margin = new Padding(6);
            btnTransition.Name = "btnTransition";
            btnTransition.Size = new Size(151, 49);
            btnTransition.TabIndex = 4;
            btnTransition.Text = "Вернуться ";
            btnTransition.UseVisualStyleBackColor = true;
            btnTransition.Click += btnTransition_Click;
            // 
            // radioInt
            // 
            radioInt.Location = new Point(22, 126);
            radioInt.Name = "radioInt";
            radioInt.Size = new Size(154, 36);
            radioInt.TabIndex = 5;
            radioInt.TabStop = true;
            radioInt.Text = "Цифры";
            radioInt.UseVisualStyleBackColor = true;
            // 
            // radioChar
            // 
            radioChar.Location = new Point(182, 126);
            radioChar.Name = "radioChar";
            radioChar.Size = new Size(165, 36);
            radioChar.TabIndex = 6;
            radioChar.TabStop = true;
            radioChar.Text = "Символы";
            radioChar.UseVisualStyleBackColor = true;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(188, 78);
            textBoxEnd.Margin = new Padding(6);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(151, 39);
            textBoxEnd.TabIndex = 7;
            // 
            // label1
            // 
            label1.Location = new Point(25, 21);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 8;
            label1.Text = "Начало";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Location = new Point(25, 72);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 32);
            label3.TabIndex = 9;
            label3.Text = "Конец";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Pr5_5
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 547);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(6);
            Name = "Pr5_5";
            Text = "Pr5_5";
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox textBoxStart;
        private Button btnSubmit;
        private Label labelResult;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnRepeat;
        private Button btnTransition;
        private RadioButton radioInt;
        private RadioButton radioChar;
        private TextBox textBoxEnd;
        private Label label1;
        private Label label3;
    }
}