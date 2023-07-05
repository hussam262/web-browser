using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        Browser a = new Browser();


        public MainWindow()
        {
            InitializeComponent();
            readHome();
            a.VISIT_URL = a.HOME_URL;
            textBox1.Text = a.HOME_URL;
            a.visitWebsite(a.HOME_URL);
            richTextBox1.Text = a.STATUS_CODE + "\n" + a.WEBSITE_DETAILS;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Pressing the button 'go' to visit a website 
        private void button1_Click(object sender, EventArgs e)
        {

            a.VISIT_URL = textBox1.Text;
            a.visitWebsite(textBox1.Text);
            richTextBox1.Text = a.STATUS_CODE + "\n" + a.WEBSITE_DETAILS;
        }
        // The home button
        private void button3_Click(object sender, EventArgs e)
        {


            a.VISIT_URL = a.HOME_URL;
            a.visitWebsite(a.HOME_URL);
            textBox1.Text = a.HOME_URL;
            richTextBox1.Text = a.STATUS_CODE + "\n" + a.WEBSITE_DETAILS;
        }

        //The refresh button
        private void button2_Click(object sender, EventArgs e)
        {
            a.visitWebsite(a.VISIT_URL);
            richTextBox1.Text = a.STATUS_CODE + "\n" + a.WEBSITE_DETAILS;
        }

        //The favourite button (opens favourite window)
        private void button4_Click(object sender, EventArgs e)
        {
            Favourites fav = new Favourites(this);
            fav.Show();

        }

        //The history button (opens History window)
        private void historyButton_Click(object sender, EventArgs e)
        {
            History his = new History(this);
            his.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("History.txt");

                a.VISIT_URL = lines[lines.Length - 2];
                a.visitWebsite(a.VISIT_URL);
                textBox1.Text = a.VISIT_URL;
                richTextBox1.Text = a.STATUS_CODE + "\n" + a.WEBSITE_DETAILS;
            }
            catch (Exception) { 
            
            }
        }

        //The method that visits a website from history or favourite
        public void visitWebsite(String str)
        {
            a.VISIT_URL = str;
            a.visitWebsite(a.VISIT_URL);
            textBox1.Text = a.VISIT_URL;
            richTextBox1.Text = a.STATUS_CODE + "\n" + a.WEBSITE_DETAILS;
        }

        // The bulk download button
        private void bulkButton_Click(object sender, EventArgs e)
        {
            BulkDownload blk = new BulkDownload();
            blk.Show();
        }

        //Button to change home URL
        private void button2_Click_1(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter("Home.txt"))
            {
                tw.WriteLine(a.VISIT_URL);
                tw.Close();
            }
                a.HOME_URL = a.VISIT_URL;
            System.Windows.Forms.MessageBox.Show("Home Page changed Successfully");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //The method that reads the current home page when initializing the browser
        public void readHome() {
            try {
                string[] lines = File.ReadAllLines("Home.txt");
                a.HOME_URL = lines[0];

            }
            // dealing with exception if file containing home address is not found
            catch (Exception e) {
                //dealing with exception if file is empty
                if (e is System.IndexOutOfRangeException  ) {
                    File.Delete("Home.txt");
                    var myFile = File.Create("Home.txt");
                    using (TextWriter tw = new StreamWriter(myFile))
                    {
                        tw.WriteLine("www.hw.ac.uk");
                        tw.Close();
                    }
                    string[] lines = File.ReadAllLines("Home.txt");
                    a.HOME_URL = lines[0];
                }
                //dealing with exception if file is not found
                else if (e is FileNotFoundException) {
                    var myFile = File.Create("Home.txt");
                    using (TextWriter tw = new StreamWriter(myFile))
                    {
                        tw.WriteLine("www.hw.ac.uk");
                        tw.Close();
                    }
                    string[] lines = File.ReadAllLines("Home.txt");
                    a.HOME_URL = lines[0];
                }
                //dealing with exception if file has a wrong value for home address
                else if (e is System.UriFormatException) {
                    File.Delete("Home.txt");
                    var myFile = File.Create("Home.txt");
                    using (TextWriter tw = new StreamWriter(myFile))
                    {
                        tw.WriteLine("www.hw.ac.uk");
                        tw.Close();
                    }
                    string[] lines = File.ReadAllLines("Home.txt");
                    a.HOME_URL = lines[0];
                }
            }

            

            }
    }
}
