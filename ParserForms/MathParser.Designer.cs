namespace ParserForms
{
    partial class MathParser
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
            this.parseButton = new System.Windows.Forms.Button();
            this.sentenceTextBox = new System.Windows.Forms.TextBox();
            this.successLabel = new System.Windows.Forms.Label();
            this.failLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(32, 91);
            this.parseButton.Margin = new System.Windows.Forms.Padding(4);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(100, 28);
            this.parseButton.TabIndex = 0;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.ParseButtonClick);
            // 
            // sentenceTextBox
            // 
            this.sentenceTextBox.Location = new System.Drawing.Point(32, 42);
            this.sentenceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sentenceTextBox.Name = "sentenceTextBox";
            this.sentenceTextBox.Size = new System.Drawing.Size(457, 22);
            this.sentenceTextBox.TabIndex = 1;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.ForeColor = System.Drawing.Color.Green;
            this.successLabel.Location = new System.Drawing.Point(32, 123);
            this.successLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(0, 17);
            this.successLabel.TabIndex = 2;
            // 
            // failLabel
            // 
            this.failLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.failLabel.AutoSize = true;
            this.failLabel.BackColor = System.Drawing.Color.Transparent;
            this.failLabel.ForeColor = System.Drawing.Color.Maroon;
            this.failLabel.Location = new System.Drawing.Point(185, 122);
            this.failLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.failLabel.Name = "failLabel";
            this.failLabel.Size = new System.Drawing.Size(0, 17);
            this.failLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Format: [Number][Space][Operator][Number][Space]...\r\n";
            // 
            // MathParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.failLabel);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.sentenceTextBox);
            this.Controls.Add(this.parseButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MathParser";
            this.Text = "Math expressions parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.TextBox sentenceTextBox;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Label failLabel;
        private System.Windows.Forms.Label label1;
    }
}

