using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;


namespace FailMen
{
    public partial class Form1 : Form
    {
        private string filePath = "D:";
        private bool isFile = false;
        private string currentySelectedItemName = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilePathTextBox.Text = filePath;
            loadFilesAndDerectories();
        }
        public void loadFilesAndDerectories() 
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAtt;

            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileNameLable.Text = fileDetails.Name;
                    fileTipeLable.Text = fileDetails.Extension;
                    fileAtt = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAtt = File.GetAttributes(filePath);
                    
                }
                if ((fileAtt & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles(); //Получает все файлы
                    DirectoryInfo[] dirs = fileList.GetDirectories(); //Получает все папки

                    string fileExtension = "";
                    listView1.Items.Clear();
                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();// Отображение иконок для определённого, типа файлов
                        switch(fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView1.Items.Add(files[i].Name, 4);
                                break;
                            case ".EXE":
                            case ".COM":
                                listView1.Items.Add(files[i].Name, 6);
                                break;
                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView1.Items.Add(files[i].Name, 5);
                                break;
                            case ".PDF":
                                listView1.Items.Add(files[i].Name, 3);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView1.Items.Add(files[i].Name, 2);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView1.Items.Add(files[i].Name, 7);
                                break;
                            default:

                                listView1.Items.Add(files[i].Name, 8);
                                break;

                        }
                        listView1.Items.Add(files[i].Name, 8);
                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 0);
                    }
                }
                else
                {
                    fileNameLable.Text = this.currentySelectedItemName;
                }

            }

            catch(Exception e)
            {

            }
        }


        public void loudButtomAction() //операция для кнопки вперёд и назад
        {
            removeBackSlash();
            filePath = FilePathTextBox.Text;
            loadFilesAndDerectories();
            isFile = false;
        }

        public void removeBackSlash()
        {
            string path = FilePathTextBox.Text;
            if (path.LastIndexOf("/") == path.Length - 1)
            {
                FilePathTextBox.Text = path.Substring(0, path.Length - 1); 
            }
        }

        public void goBack() //Кнопка назад
        {
            try
            {
                removeBackSlash();
                string path = FilePathTextBox.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                FilePathTextBox.Text = path;
                removeBackSlash();
            }
            catch (Exception e)
            {
                
            }
            
        }

        private void GoButtom_Click(object sender, EventArgs e) //Кнопка вперёд
        {
            loudButtomAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentySelectedItemName = e.Item.Text;

            FileAttributes fileAtt = File.GetAttributes(filePath + "/" + currentySelectedItemName);
            if ((fileAtt & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                FilePathTextBox.Text = filePath + "/" + currentySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loudButtomAction();
        }

        private void BackButtom_Click(object sender, EventArgs e)//Кнопка назад
        {
            goBack();
            loudButtomAction();
        }

        private void CreateFileButton_Click(object sender, EventArgs e) //Создание файла
        {
            try
            {
                Form2 addform = new Form2();
                addform.filePath = filePath;
                addform.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void CreateDirectoryButton_Click(object sender, EventArgs e) //Создать папку
        {
            try
            {
                Form3 addform = new Form3();
                addform.filePath = filePath;
                addform.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void DelButton_Click(object sender, EventArgs e) //Удалить
        {

            try
            {
                FileAttributes fileAttributes = File.GetAttributes(filePath + "/" + currentySelectedItemName);
                if (fileAttributes.ToString().IndexOf("Directory") != -1)
                        Directory.Delete(filePath + "/" + currentySelectedItemName);
                else
                        File.Delete(filePath + "/" + currentySelectedItemName);
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }

       // private void Arch_Click(object sender, EventArgs e)
        //{
          //  try
            //{
              //  FileAttributes fileAttributes = File.GetAttributes(filePath + "\\" + currentySelectedItemName);
                //if (fileAttributes.ToString().IndexOf("Directory") != -1)
                  //  ZipFile.CreateFromDirectory(filePath + "\\" + currentySelectedItemName, filePath + "\\" + currentySelectedItemName + ".zip");
                //else
                //{
                  //  Directory.CreateDirectory(filePath + "\\" + currentySelectedItemName.Remove(currentySelectedItemName.LastIndexOf(".")));
                    //File.Copy(filePath + "\\" + currentySelectedItemName, filePath + "\\" + currentySelectedItemName.Remove(currentySelectedItemName.LastIndexOf(".")) + "\\" + currentySelectedItemName);
                    //ZipFile.CreateFromDirectory(filePath + "\\" + currentySelectedItemName.Remove(currentySelectedItemName.LastIndexOf(".")), filePath + "\\" + currentySelectedItemName.Remove(currentySelectedItemName.LastIndexOf(".")) + ".zip");
                    //Directory.Delete(filePath + "\\" + currentySelectedItemName.Remove(currentySelectedItemName.LastIndexOf(".")), true);
                //}

           // }
            //catch (Exception ex)
            //{
              //  MessageBox.Show(ex.Message, "Ошибка");
            //}
        ///}
    }
    }
//            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
//            this.CopButDer.Click += new System.EventHandler(this.CopButDer_Click);


