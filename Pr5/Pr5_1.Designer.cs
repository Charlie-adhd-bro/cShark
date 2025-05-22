namespace Pr5
{
    partial class Pr5_1
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
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            txtInput = new TextBox();
            radioBtnRecursion = new RadioButton();
            radioBtnWithoutRecursion = new RadioButton();
            btnSubmit = new Button();
            btnRepeat = new Button();
            btn_transition = new Button();
            labelResult = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(408, 41);
            label1.TabIndex = 0;
            label1.Text = "Введите значение n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.BackColor = SystemColors.Control;
            flowLayoutPanel2.Controls.Add(txtInput);
            flowLayoutPanel2.Controls.Add(radioBtnRecursion);
            flowLayoutPanel2.Controls.Add(radioBtnWithoutRecursion);
            flowLayoutPanel2.Controls.Add(btnSubmit);
            flowLayoutPanel2.Controls.Add(btnRepeat);
            flowLayoutPanel2.Controls.Add(btn_transition);
            flowLayoutPanel2.Controls.Add(labelResult);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 61);
            flowLayoutPanel2.MaximumSize = new Size(1032, 492);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(10);
            flowLayoutPanel2.Size = new Size(432, 492);
            flowLayoutPanel2.TabIndex = 10;
            // 
            // txtInput
            // 
            txtInput.Cursor = Cursors.IBeam;
            txtInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtInput.Location = new Point(13, 13);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(408, 33);
            txtInput.TabIndex = 0;
            // 
            // radioBtnRecursion
            // 
            radioBtnRecursion.AutoSize = true;
            radioBtnRecursion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioBtnRecursion.Location = new Point(13, 52);
            radioBtnRecursion.Name = "radioBtnRecursion";
            radioBtnRecursion.Size = new Size(201, 29);
            radioBtnRecursion.TabIndex = 9;
            radioBtnRecursion.TabStop = true;
            radioBtnRecursion.Text = "Метод с рекурсией ";
            radioBtnRecursion.UseVisualStyleBackColor = true;
            // 
            // radioBtnWithoutRecursion
            // 
            radioBtnWithoutRecursion.AutoSize = true;
            radioBtnWithoutRecursion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            radioBtnWithoutRecursion.Location = new Point(13, 87);
            radioBtnWithoutRecursion.Name = "radioBtnWithoutRecursion";
            radioBtnWithoutRecursion.Size = new Size(206, 29);
            radioBtnWithoutRecursion.TabIndex = 8;
            radioBtnWithoutRecursion.TabStop = true;
            radioBtnWithoutRecursion.Text = "Метод без рекурсии";
            radioBtnWithoutRecursion.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.AutoSize = true;
            btnSubmit.Font = new Font("Segoe UI", 14.25F);
            btnSubmit.Location = new Point(13, 122);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(408, 49);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Отправить";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // btnRepeat
            // 
            btnRepeat.AutoSize = true;
            btnRepeat.Font = new Font("Segoe UI", 14.25F);
            btnRepeat.Location = new Point(13, 177);
            btnRepeat.Name = "btnRepeat";
            btnRepeat.Size = new Size(408, 49);
            btnRepeat.TabIndex = 2;
            btnRepeat.Text = "Повторить";
            btnRepeat.UseVisualStyleBackColor = true;
            btnRepeat.Click += BtnRepeat_Click;
            // 
            // btn_transition
            // 
            btn_transition.AutoSize = true;
            btn_transition.Font = new Font("Segoe UI", 14.25F);
            btn_transition.Location = new Point(13, 232);
            btn_transition.Name = "btn_transition";
            btn_transition.Size = new Size(407, 49);
            btn_transition.TabIndex = 5;
            btn_transition.Text = "Вернуться";
            btn_transition.UseVisualStyleBackColor = true;
            btn_transition.Click += Btn_transition_Click;
            // 
            // labelResult
            // 
            labelResult.AutoEllipsis = true;
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelResult.Location = new Point(13, 284);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 32);
            labelResult.TabIndex = 3;
            labelResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(432, 61);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // Pr5_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 553);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Pr5_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pr5_1";
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox txtInput;
        private RadioButton radioBtnRecursion;
        private RadioButton radioBtnWithoutRecursion;
        private Label labelResult;
        private Button btnSubmit;
        private Button btnRepeat;
        private Button btn_transition;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}