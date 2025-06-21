namespace NumbersToWords
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblWordNumbers = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 13);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Enter a number between 0 and 9999.99";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(118, 30);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(119, 23);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert to Words";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblWordNumbers
            // 
            this.lblWordNumbers.AutoSize = true;
            this.lblWordNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordNumbers.Location = new System.Drawing.Point(9, 69);
            this.lblWordNumbers.Name = "lblWordNumbers";
            this.lblWordNumbers.Size = new System.Drawing.Size(0, 16);
            this.lblWordNumbers.TabIndex = 6;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(12, 32);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 5;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 104);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblWordNumbers);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Numbers to Words Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblWordNumbers;
        private System.Windows.Forms.TextBox txtNumber;
    }
}

