namespace hegemony
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            btnCopy = new Button();
            btnFrom = new Button();
            btnTo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 1;
            label2.Text = "To:";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(56, 6);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(100, 23);
            txtFrom.TabIndex = 2;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(56, 40);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(100, 23);
            txtTo.TabIndex = 3;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(12, 83);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 4;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnFrom
            // 
            btnFrom.Location = new Point(162, 6);
            btnFrom.Name = "btnFrom";
            btnFrom.Size = new Size(75, 23);
            btnFrom.TabIndex = 5;
            btnFrom.Text = "From";
            btnFrom.UseVisualStyleBackColor = true;
            btnFrom.Click += btnFrom_Click;
            // 
            // btnTo
            // 
            btnTo.Location = new Point(162, 40);
            btnTo.Name = "btnTo";
            btnTo.Size = new Size(75, 23);
            btnTo.TabIndex = 6;
            btnTo.Text = "To";
            btnTo.UseVisualStyleBackColor = true;
            btnTo.Click += btnTo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 246);
            Controls.Add(btnTo);
            Controls.Add(btnFrom);
            Controls.Add(btnCopy);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFrom;
        private TextBox txtTo;
        private Button btnCopy;
        private Button btnFrom;
        private Button btnTo;
    }
}
