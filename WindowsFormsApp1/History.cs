using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class History : Form
    {
        MainWindow main = null;
        public History(MainWindow a)
        {
            InitializeComponent();
            main = a;
            readFile();
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
        }
        //The method that reads the history file
        public void readFile()
        {
            richTextBox1.Clear();
            try
            {
                string[] lines = File.ReadAllLines("History.txt");

                foreach (string line in lines)
                    richTextBox1.Text += line + "\n";
            }
            //handling the exception when file is not found
            catch (FileNotFoundException e)
            {
                var myFile = File.Create(e.FileName);
                myFile.Close();
            }
        }

        //The method that allows the user to visit the website from history list
        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {

            main.visitWebsite(e.LinkText);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
