using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class BulkDownload : Form
    {
        String file = "bulk.txt";
        public BulkDownload()
        {
            InitializeComponent();
            textBox1.Text = file;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //The Download button which starts the bulk download from given file name
        private void button1_Click(object sender, EventArgs e)
        {
            long a;
            int statusCode;
            file = textBox1.Text;
            richTextBox1.Clear();
            try
            {
                string[] lines = File.ReadAllLines(file);

                foreach (string line in lines)
                {
                    HttpWebResponse response = null;
                    try
                    {
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("Http://" + line);
                    
                    
                        response = (HttpWebResponse)request.GetResponse();
                        statusCode = 200;
                        a = response.ContentLength;
                    }
                    catch (System.UriFormatException)
                    {
                        statusCode = 400;
                        a = -1;
                    }
                    //Dealing with the exception that website throws an error message
                    catch (WebException we)
                    {
                        response = (HttpWebResponse)we.Response;
                        if (response == null)
                        {

                            statusCode = 400;
                            a = -1;
                        }

                        else
                        {
                            statusCode = (int)response.StatusCode;
                            a = response.ContentLength;

                        }


                    }

                    richTextBox1.Text += statusCode + " " + a + " " + line + "\n";

                }
                System.Windows.Forms.MessageBox.Show("File loaded Successfully");
            }
            //handling the exception when file is not found
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("File Not Found");

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
