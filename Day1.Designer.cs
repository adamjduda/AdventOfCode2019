namespace AdventOfCode
{
    partial class Day1
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.importFilePathTextBox = new System.Windows.Forms.TextBox();
            this.importBoxLabel = new System.Windows.Forms.Label();
            this.exportBoxLabel = new System.Windows.Forms.Label();
            this.exportFilePathTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(197, 99);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // importFilePathTextBox
            // 
            this.importFilePathTextBox.Location = new System.Drawing.Point(12, 25);
            this.importFilePathTextBox.Name = "importFilePathTextBox";
            this.importFilePathTextBox.Size = new System.Drawing.Size(260, 20);
            this.importFilePathTextBox.TabIndex = 1;
            // 
            // importBoxLabel
            // 
            this.importBoxLabel.AutoSize = true;
            this.importBoxLabel.Location = new System.Drawing.Point(12, 9);
            this.importBoxLabel.Name = "importBoxLabel";
            this.importBoxLabel.Size = new System.Drawing.Size(80, 13);
            this.importBoxLabel.TabIndex = 2;
            this.importBoxLabel.Text = "Import File Path";
            // 
            // exportBoxLabel
            // 
            this.exportBoxLabel.AutoSize = true;
            this.exportBoxLabel.Location = new System.Drawing.Point(12, 57);
            this.exportBoxLabel.Name = "exportBoxLabel";
            this.exportBoxLabel.Size = new System.Drawing.Size(81, 13);
            this.exportBoxLabel.TabIndex = 3;
            this.exportBoxLabel.Text = "Export File Path";
            // 
            // exportFilePathTextBox
            // 
            this.exportFilePathTextBox.Location = new System.Drawing.Point(12, 73);
            this.exportFilePathTextBox.Name = "exportFilePathTextBox";
            this.exportFilePathTextBox.Size = new System.Drawing.Size(260, 20);
            this.exportFilePathTextBox.TabIndex = 4;
            // 
            // Day1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 134);
            this.Controls.Add(this.exportFilePathTextBox);
            this.Controls.Add(this.exportBoxLabel);
            this.Controls.Add(this.importBoxLabel);
            this.Controls.Add(this.importFilePathTextBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "Day1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox importFilePathTextBox;
        private System.Windows.Forms.Label importBoxLabel;
        private System.Windows.Forms.Label exportBoxLabel;
        private System.Windows.Forms.TextBox exportFilePathTextBox;
    }
}

