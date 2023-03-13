using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace FailMen
{
    
    public partial class Form3 : Form
    {
        public string filePath;
        public Form3()
        {
            InitializeComponent();
        }

        private void CreateDirctorButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CreateDerectoryTextBox.Text == string.Empty)
                    throw new Exception("Напишите имя папки!");

                Directory.CreateDirectory(filePath + "/" + CreateDerectoryTextBox.Text);
                this.Close();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}
