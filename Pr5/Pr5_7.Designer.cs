namespace Pr5
{
    partial class Pr5_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pr5_7));
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            textBoxInput = new TextBox();
            btnSubmit = new Button();
            labelResult = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            label1 = new Label();
            textBoxChars = new TextBox();
            btnRepeat = new Button();
            btnTransition = new Button();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(flowLayoutPanel2, "flowLayoutPanel2");
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // textBoxInput
            // 
            resources.ApplyResources(textBoxInput, "textBoxInput");
            textBoxInput.Name = "textBoxInput";
            // 
            // btnSubmit
            // 
            resources.ApplyResources(btnSubmit, "btnSubmit");
            btnSubmit.Name = "btnSubmit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // labelResult
            // 
            resources.ApplyResources(labelResult, "labelResult");
            labelResult.Name = "labelResult";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(textBoxInput);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(textBoxChars);
            flowLayoutPanel1.Controls.Add(btnSubmit);
            flowLayoutPanel1.Controls.Add(btnRepeat);
            flowLayoutPanel1.Controls.Add(btnTransition);
            flowLayoutPanel1.Controls.Add(labelResult);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // textBoxChars
            // 
            resources.ApplyResources(textBoxChars, "textBoxChars");
            textBoxChars.Name = "textBoxChars";
            // 
            // btnRepeat
            // 
            resources.ApplyResources(btnRepeat, "btnRepeat");
            btnRepeat.Name = "btnRepeat";
            btnRepeat.UseVisualStyleBackColor = false;
            btnRepeat.Click += btnRepeat_Click;
            // 
            // btnTransition
            // 
            resources.ApplyResources(btnTransition, "btnTransition");
            btnTransition.Name = "btnTransition";
            btnTransition.UseVisualStyleBackColor = false;
            btnTransition.Click += btnTransition_Click;
            // 
            // Pr5_7
            // 
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Name = "Pr5_7";
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
        private TextBox textBoxInput;
        private Button btnSubmit;
        private Label labelResult;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnRepeat;
        private Button btnTransition;
        private TextBox textBoxChars;
        private Label label3;
        private Label label1;
    }
}