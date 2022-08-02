namespace VolumeConverter
{
    partial class volumeConverter
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
            this.convertClToLitreLabel = new System.Windows.Forms.Label();
            this.litreTextBox = new System.Windows.Forms.TextBox();
            this.clTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.clLabel = new System.Windows.Forms.Label();
            this.litreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertClToLitreLabel
            // 
            this.convertClToLitreLabel.AutoSize = true;
            this.convertClToLitreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertClToLitreLabel.Location = new System.Drawing.Point(101, 42);
            this.convertClToLitreLabel.Name = "convertClToLitreLabel";
            this.convertClToLitreLabel.Size = new System.Drawing.Size(230, 29);
            this.convertClToLitreLabel.TabIndex = 0;
            this.convertClToLitreLabel.Text = "Convert CL to Litre";
            this.convertClToLitreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // litreTextBox
            // 
            this.litreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litreTextBox.Location = new System.Drawing.Point(97, 148);
            this.litreTextBox.Multiline = true;
            this.litreTextBox.Name = "litreTextBox";
            this.litreTextBox.Size = new System.Drawing.Size(133, 38);
            this.litreTextBox.TabIndex = 1;
            this.litreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.litreTextBox.TextChanged += new System.EventHandler(this.litreTextBox_TextChanged);
            // 
            // clTextBox
            // 
            this.clTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTextBox.Location = new System.Drawing.Point(97, 85);
            this.clTextBox.Multiline = true;
            this.clTextBox.Name = "clTextBox";
            this.clTextBox.Size = new System.Drawing.Size(133, 38);
            this.clTextBox.TabIndex = 2;
            this.clTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTextBox.TextChanged += new System.EventHandler(this.clTextBox_TextChanged);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.Blue;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.convertButton.Location = new System.Drawing.Point(106, 220);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(99, 44);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Fuchsia;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton.Location = new System.Drawing.Point(256, 220);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(99, 44);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clLabel
            // 
            this.clLabel.AutoSize = true;
            this.clLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clLabel.Location = new System.Drawing.Point(279, 99);
            this.clLabel.Name = "clLabel";
            this.clLabel.Size = new System.Drawing.Size(27, 17);
            this.clLabel.TabIndex = 5;
            this.clLabel.Text = "CL";
            // 
            // litreLabel
            // 
            this.litreLabel.AutoSize = true;
            this.litreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litreLabel.Location = new System.Drawing.Point(276, 158);
            this.litreLabel.Name = "litreLabel";
            this.litreLabel.Size = new System.Drawing.Size(41, 17);
            this.litreLabel.TabIndex = 6;
            this.litreLabel.Text = "Litre";
            // 
            // volumeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(431, 329);
            this.Controls.Add(this.litreLabel);
            this.Controls.Add(this.clLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.clTextBox);
            this.Controls.Add(this.litreTextBox);
            this.Controls.Add(this.convertClToLitreLabel);
            this.MaximizeBox = false;
            this.Name = "volumeConverter";
            this.Text = "Volume Converter CL to Litre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label convertClToLitreLabel;
        private System.Windows.Forms.TextBox clTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label clLabel;
        private System.Windows.Forms.Label litreLabel;
        public System.Windows.Forms.TextBox litreTextBox;
    }
}

