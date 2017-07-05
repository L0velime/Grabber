namespace Private_Video_Grabber
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
            this.idNumberTextBox = new System.Windows.Forms.TextBox();
            this.publicUrlTextBox = new System.Windows.Forms.TextBox();
            this.newPrivateUrlTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.publicLabel = new System.Windows.Forms.Label();
            this.newPrivateLabel = new System.Windows.Forms.Label();
            this.createUrlButton = new System.Windows.Forms.Button();
            this.copyUrlButton = new System.Windows.Forms.Button();
            this.keepNumbersLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // idNumberTextBox
            // 
            this.idNumberTextBox.Location = new System.Drawing.Point(12, 25);
            this.idNumberTextBox.Name = "idNumberTextBox";
            this.idNumberTextBox.Size = new System.Drawing.Size(172, 20);
            this.idNumberTextBox.TabIndex = 0;
            this.idNumberTextBox.TextChanged += new System.EventHandler(this.idNumberTextBox_TextChanged);
            // 
            // publicUrlTextBox
            // 
            this.publicUrlTextBox.Location = new System.Drawing.Point(12, 122);
            this.publicUrlTextBox.Name = "publicUrlTextBox";
            this.publicUrlTextBox.Size = new System.Drawing.Size(172, 20);
            this.publicUrlTextBox.TabIndex = 1;
            this.publicUrlTextBox.TextChanged += new System.EventHandler(this.publicUrlTextBox_TextChanged);
            // 
            // newPrivateUrlTextBox
            // 
            this.newPrivateUrlTextBox.Location = new System.Drawing.Point(12, 167);
            this.newPrivateUrlTextBox.Name = "newPrivateUrlTextBox";
            this.newPrivateUrlTextBox.Size = new System.Drawing.Size(172, 20);
            this.newPrivateUrlTextBox.TabIndex = 2;
            this.newPrivateUrlTextBox.TextChanged += new System.EventHandler(this.newPrivateUrlTextBox_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(84, 13);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "Private Video ID";
            this.idLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // publicLabel
            // 
            this.publicLabel.AutoSize = true;
            this.publicLabel.Location = new System.Drawing.Point(12, 106);
            this.publicLabel.Name = "publicLabel";
            this.publicLabel.Size = new System.Drawing.Size(95, 13);
            this.publicLabel.TabIndex = 4;
            this.publicLabel.Text = "Public Video Label";
            this.publicLabel.Click += new System.EventHandler(this.publicLabel_Click);
            // 
            // newPrivateLabel
            // 
            this.newPrivateLabel.AutoSize = true;
            this.newPrivateLabel.Location = new System.Drawing.Point(12, 151);
            this.newPrivateLabel.Name = "newPrivateLabel";
            this.newPrivateLabel.Size = new System.Drawing.Size(99, 13);
            this.newPrivateLabel.TabIndex = 5;
            this.newPrivateLabel.Text = "Private Video Label";
            this.newPrivateLabel.Click += new System.EventHandler(this.newPrivateLabel_Click);
            // 
            // createUrlButton
            // 
            this.createUrlButton.Location = new System.Drawing.Point(12, 218);
            this.createUrlButton.Name = "createUrlButton";
            this.createUrlButton.Size = new System.Drawing.Size(75, 23);
            this.createUrlButton.TabIndex = 6;
            this.createUrlButton.Text = "Create URL";
            this.createUrlButton.UseVisualStyleBackColor = true;
            this.createUrlButton.Click += new System.EventHandler(this.createUrlButton_Click);
            // 
            // copyUrlButton
            // 
            this.copyUrlButton.Location = new System.Drawing.Point(109, 218);
            this.copyUrlButton.Name = "copyUrlButton";
            this.copyUrlButton.Size = new System.Drawing.Size(75, 23);
            this.copyUrlButton.TabIndex = 7;
            this.copyUrlButton.Text = "Copy URL";
            this.copyUrlButton.UseVisualStyleBackColor = true;
            this.copyUrlButton.Click += new System.EventHandler(this.copyUrlButton_Click);
            // 
            // keepNumbersLabel
            // 
            this.keepNumbersLabel.AutoSize = true;
            this.keepNumbersLabel.Location = new System.Drawing.Point(48, 65);
            this.keepNumbersLabel.Name = "keepNumbersLabel";
            this.keepNumbersLabel.Size = new System.Drawing.Size(133, 13);
            this.keepNumbersLabel.TabIndex = 9;
            this.keepNumbersLabel.Text = "How many to keep from ID";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 63);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(30, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 251);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.keepNumbersLabel);
            this.Controls.Add(this.copyUrlButton);
            this.Controls.Add(this.createUrlButton);
            this.Controls.Add(this.newPrivateLabel);
            this.Controls.Add(this.publicLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.newPrivateUrlTextBox);
            this.Controls.Add(this.publicUrlTextBox);
            this.Controls.Add(this.idNumberTextBox);
            this.Name = "Form1";
            this.Text = "Private Video Grabber";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idNumberTextBox;
        private System.Windows.Forms.TextBox publicUrlTextBox;
        private System.Windows.Forms.TextBox newPrivateUrlTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label publicLabel;
        private System.Windows.Forms.Label newPrivateLabel;
        private System.Windows.Forms.Button createUrlButton;
        private System.Windows.Forms.Button copyUrlButton;
        public System.Windows.Forms.Label keepNumbersLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

