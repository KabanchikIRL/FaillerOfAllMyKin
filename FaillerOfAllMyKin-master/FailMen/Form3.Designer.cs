namespace FailMen
{
    partial class Form3
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
            this.CreateDirctorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateDerectoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateDirctorButton
            // 
            this.CreateDirctorButton.Location = new System.Drawing.Point(98, 73);
            this.CreateDirctorButton.Name = "CreateDirctorButton";
            this.CreateDirctorButton.Size = new System.Drawing.Size(191, 23);
            this.CreateDirctorButton.TabIndex = 0;
            this.CreateDirctorButton.Text = "Создать документ";
            this.CreateDirctorButton.UseVisualStyleBackColor = true;
            this.CreateDirctorButton.Click += new System.EventHandler(this.CreateDirctorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название документа";
            // 
            // CreateDerectoryTextBox
            // 
            this.CreateDerectoryTextBox.Location = new System.Drawing.Point(132, 37);
            this.CreateDerectoryTextBox.Name = "CreateDerectoryTextBox";
            this.CreateDerectoryTextBox.Size = new System.Drawing.Size(220, 20);
            this.CreateDerectoryTextBox.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 191);
            this.Controls.Add(this.CreateDerectoryTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateDirctorButton);
            this.Name = "Form3";
            this.Text = "Создание документа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateDirctorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreateDerectoryTextBox;
    }
}