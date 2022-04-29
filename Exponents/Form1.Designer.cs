namespace Exponents
{
    partial class Form1
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
            this.uInputTextBox = new System.Windows.Forms.TextBox();
            this.uInputLabel = new System.Windows.Forms.Label();
            this.uOutputLabel = new System.Windows.Forms.Label();
            this.uGoButton = new System.Windows.Forms.Button();
            this.uResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uInputTextBox
            // 
            this.uInputTextBox.Location = new System.Drawing.Point(123, 55);
            this.uInputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uInputTextBox.Name = "uInputTextBox";
            this.uInputTextBox.Size = new System.Drawing.Size(132, 22);
            this.uInputTextBox.TabIndex = 0;
            this.uInputTextBox.Tag = "Text Box";
            // 
            // uInputLabel
            // 
            this.uInputLabel.AutoSize = true;
            this.uInputLabel.Location = new System.Drawing.Point(123, 33);
            this.uInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uInputLabel.Name = "uInputLabel";
            this.uInputLabel.Size = new System.Drawing.Size(103, 16);
            this.uInputLabel.TabIndex = 3;
            this.uInputLabel.Tag = "Label";
            this.uInputLabel.Text = "Enter an integer:";
            // 
            // uOutputLabel
            // 
            this.uOutputLabel.AutoSize = true;
            this.uOutputLabel.Location = new System.Drawing.Point(136, 223);
            this.uOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uOutputLabel.Name = "uOutputLabel";
            this.uOutputLabel.Size = new System.Drawing.Size(0, 16);
            this.uOutputLabel.TabIndex = 4;
            this.uOutputLabel.Tag = "Output Label";
            this.uOutputLabel.Visible = false;
            // 
            // uGoButton
            // 
            this.uGoButton.Location = new System.Drawing.Point(140, 118);
            this.uGoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uGoButton.Name = "uGoButton";
            this.uGoButton.Size = new System.Drawing.Size(100, 82);
            this.uGoButton.TabIndex = 6;
            this.uGoButton.Tag = "Button";
            this.uGoButton.Text = "Go!";
            this.uGoButton.UseVisualStyleBackColor = true;
            this.uGoButton.Click += new System.EventHandler(this.xGoButton_Click);
            // 
            // uResetButton
            // 
            this.uResetButton.Location = new System.Drawing.Point(140, 261);
            this.uResetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uResetButton.Name = "uResetButton";
            this.uResetButton.Size = new System.Drawing.Size(100, 28);
            this.uResetButton.TabIndex = 7;
            this.uResetButton.Tag = "Reset Button";
            this.uResetButton.Text = "Reset";
            this.uResetButton.UseVisualStyleBackColor = true;
            this.uResetButton.Click += new System.EventHandler(this.xResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.uResetButton);
            this.Controls.Add(this.uGoButton);
            this.Controls.Add(this.uOutputLabel);
            this.Controls.Add(this.uInputLabel);
            this.Controls.Add(this.uInputTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exponents Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uInputTextBox;
        private System.Windows.Forms.Label uInputLabel;
        private System.Windows.Forms.Label uOutputLabel;
        private System.Windows.Forms.Button uGoButton;
        private System.Windows.Forms.Button uResetButton;
    }
}

