namespace _16._5_ThadSwint
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
            this.TBox = new System.Windows.Forms.TextBox();
            this.TranslatedLabel = new System.Windows.Forms.Label();
            this.translateButton = new System.Windows.Forms.Button();
            this.CountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBox
            // 
            this.TBox.Location = new System.Drawing.Point(13, 13);
            this.TBox.MaxLength = 300;
            this.TBox.Multiline = true;
            this.TBox.Name = "TBox";
            this.TBox.Size = new System.Drawing.Size(180, 54);
            this.TBox.TabIndex = 0;
            // 
            // TranslatedLabel
            // 
            this.TranslatedLabel.AutoSize = true;
            this.TranslatedLabel.Location = new System.Drawing.Point(12, 97);
            this.TranslatedLabel.MaximumSize = new System.Drawing.Size(378, 2);
            this.TranslatedLabel.Name = "TranslatedLabel";
            this.TranslatedLabel.Size = new System.Drawing.Size(0, 2);
            this.TranslatedLabel.TabIndex = 1;
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(372, 304);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(97, 23);
            this.translateButton.TabIndex = 2;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.TranslateButton_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(24, 304);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(0, 17);
            this.CountLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 339);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.TranslatedLabel);
            this.Controls.Add(this.TBox);
            this.Name = "Form1";
            this.Text = "Pig Latin Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBox;
        private System.Windows.Forms.Label TranslatedLabel;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.Label CountLabel;
    }
}

