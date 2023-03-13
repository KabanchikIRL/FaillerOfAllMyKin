namespace FailMen
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BackButtom = new System.Windows.Forms.Button();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.fileTipeLable = new System.Windows.Forms.Label();
            this.GoButtom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateFileButton = new System.Windows.Forms.Button();
            this.CreateDirectoryButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.Arch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButtom
            // 
            this.BackButtom.Location = new System.Drawing.Point(630, 9);
            this.BackButtom.Name = "BackButtom";
            this.BackButtom.Size = new System.Drawing.Size(75, 23);
            this.BackButtom.TabIndex = 0;
            this.BackButtom.Text = "Back";
            this.BackButtom.UseVisualStyleBackColor = true;
            this.BackButtom.Click += new System.EventHandler(this.BackButtom_Click);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "folder.png");
            this.iconList.Images.SetKeyName(1, "file.png");
            this.iconList.Images.SetKeyName(2, "doc.png");
            this.iconList.Images.SetKeyName(3, "pdf.png");
            this.iconList.Images.SetKeyName(4, "mp3.png");
            this.iconList.Images.SetKeyName(5, "mp4.png");
            this.iconList.Images.SetKeyName(6, "exe.png");
            this.iconList.Images.SetKeyName(7, "png.png");
            this.iconList.Images.SetKeyName(8, "unknown.png");
            this.iconList.Images.SetKeyName(9, "folder64.png");
            // 
            // fileTipeLable
            // 
            this.fileTipeLable.AutoSize = true;
            this.fileTipeLable.Location = new System.Drawing.Point(1075, 422);
            this.fileTipeLable.Name = "fileTipeLable";
            this.fileTipeLable.Size = new System.Drawing.Size(13, 13);
            this.fileTipeLable.TabIndex = 8;
            this.fileTipeLable.Text = "..";
            // 
            // GoButtom
            // 
            this.GoButtom.Location = new System.Drawing.Point(1000, 9);
            this.GoButtom.Name = "GoButtom";
            this.GoButtom.Size = new System.Drawing.Size(75, 23);
            this.GoButtom.TabIndex = 9;
            this.GoButtom.Text = "Go";
            this.GoButtom.UseVisualStyleBackColor = true;
            this.GoButtom.Click += new System.EventHandler(this.GoButtom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название файла";
            // 
            // fileNameLable
            // 
            this.fileNameLable.AutoSize = true;
            this.fileNameLable.Location = new System.Drawing.Point(111, 422);
            this.fileNameLable.Name = "fileNameLable";
            this.fileNameLable.Size = new System.Drawing.Size(13, 13);
            this.fileNameLable.TabIndex = 11;
            this.fileNameLable.Text = "..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(997, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Тип файла";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(612, 379);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(674, 54);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(355, 20);
            this.FilePathTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "\"Путь\"";
            // 
            // CreateFileButton
            // 
            this.CreateFileButton.Location = new System.Drawing.Point(630, 96);
            this.CreateFileButton.Name = "CreateFileButton";
            this.CreateFileButton.Size = new System.Drawing.Size(106, 43);
            this.CreateFileButton.TabIndex = 19;
            this.CreateFileButton.Text = "Создать файл";
            this.CreateFileButton.UseVisualStyleBackColor = true;
            this.CreateFileButton.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // CreateDirectoryButton
            // 
            this.CreateDirectoryButton.Location = new System.Drawing.Point(923, 96);
            this.CreateDirectoryButton.Name = "CreateDirectoryButton";
            this.CreateDirectoryButton.Size = new System.Drawing.Size(106, 43);
            this.CreateDirectoryButton.TabIndex = 20;
            this.CreateDirectoryButton.Text = "Создать папку";
            this.CreateDirectoryButton.UseVisualStyleBackColor = true;
            this.CreateDirectoryButton.Click += new System.EventHandler(this.CreateDirectoryButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(630, 173);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(106, 43);
            this.DelButton.TabIndex = 21;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // Arch
            // 
            this.Arch.Location = new System.Drawing.Point(923, 173);
            this.Arch.Name = "Arch";
            this.Arch.Size = new System.Drawing.Size(106, 43);
            this.Arch.TabIndex = 22;
            this.Arch.Text = "Архивировать";
            this.Arch.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 491);
            this.Controls.Add(this.Arch);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.CreateDirectoryButton);
            this.Controls.Add(this.CreateFileButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileNameLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoButtom);
            this.Controls.Add(this.fileTipeLable);
            this.Controls.Add(this.BackButtom);
            this.Name = "Form1";
            this.Text = "Файловый менеджер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButtom;
        private System.Windows.Forms.Label fileTipeLable;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Button GoButtom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileNameLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateFileButton;
        private System.Windows.Forms.Button CreateDirectoryButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button Arch;
    }
}

