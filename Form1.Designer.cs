namespace Assignment_5
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
            panel1 = new Panel();
            submitButton = new Button();
            guessTextBox = new TextBox();
            panel2 = new Panel();
            resultLabel = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(260, 20);
            label1.TabIndex = 0;
            label1.Text = "Guess the number between 1 and 100:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(submitButton);
            panel1.Controls.Add(guessTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 125);
            panel1.TabIndex = 1;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(209, 77);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 2;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click_1;
            // 
            // guessTextBox
            // 
            guessTextBox.Location = new Point(3, 34);
            guessTextBox.Name = "guessTextBox";
            guessTextBox.Size = new Size(499, 27);
            guessTextBox.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(resultLabel);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(10, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 119);
            panel2.TabIndex = 2;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(15, 35);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(50, 20);
            resultLabel.TabIndex = 1;
            resultLabel.Text = "label3";
            resultLabel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 10);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 274);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Random number guessing game";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button submitButton;
        private TextBox guessTextBox;
        private Panel panel2;
        private Label label2;
        private Label resultLabel;
    }
}