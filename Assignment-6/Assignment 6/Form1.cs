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

namespace Assignment_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)//file explorer button
        {
           
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Task printDir = Task.Run(()=>PrintDirectory(browser.SelectedPath));
                await printDir;
            }
        }

        //printing the directory
        //Implemented PrintDirectory with Tyler Truman
        private void PrintDirectory(string directory)
        {
            try
            {
                if (!(subdir.Checked))
                {
                   foreach (string files in Directory.GetFiles(directory))
                   {
                       // printing all files in the outside directory   
                       FilesListBox.Items.Add(files);
                   }

                   foreach (string directories in Directory.GetDirectories(directory))
                   {
                       //printing name of directory
                       FilesListBox.Items.Add(directories);
                   }
                   folderstxt.Text = System.IO.Directory.GetDirectories(directory).Count().ToString();
                   filestxt.Text = System.IO.Directory.GetFiles(directory).Count().ToString();

                }
                else //user wants sub directories check
                {
                    foreach (string files in Directory.GetFiles(directory))
                    {
                        // printing all files in the outside directory   
                        FilesListBox.Items.Add(files);
                    }

                    foreach (string directories in Directory.GetDirectories(directory))
                    {
                        //printing name of directory
                        FilesListBox.Items.Add(directories);
                        //recurese to print all contents of sub directories
                        PrintDirectory(directories);
                    }
                    folderstxt.Text = System.IO.Directory.GetDirectories(directory, "*", SearchOption.AllDirectories).Count().ToString();
                    filestxt.Text = System.IO.Directory.GetFiles(directory, "*", SearchOption.AllDirectories).Count().ToString();
                }
            }
            catch (UnauthorizedAccessException)
            {
                FilesListBox.Items.Add($"Access Denied...");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FilesListBox.Items.Clear();
            folderstxt.Text = "";
            filestxt.Text = "";
        }
    }
}
