using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Favourites : Form
    {
 
        MainWindow main = null;
        DataTable table = new DataTable();
        public Favourites(MainWindow a)
        {
            InitializeComponent();

            main = a;
            table.Columns.Add("Name");
            table.Columns.Add("Address");

            dataGridView1.DataSource = table;
            dataGridView1.RowHeadersWidth = 24;
            readFile();

        }
        
        //The method that reads the favourites file and arranges the values in the list
        public void readFile()
        {
            try
            {
                string[] lines = File.ReadAllLines("Favourites.txt");
                string[] s;
                foreach (string line in lines)
                {

                    s = line.Split(',');
                    string[] row = new string[s.Length];
                    

                    row[0] = s[0];
                    row[1] = s[1];
                    table.Rows.Add(row);

                }

            }
            // handling the exception when file is not found
            catch (FileNotFoundException e)
            {
                var myFile = File.Create(e.FileName);
                myFile.Close();
            }

        }

        // Method to write the changes done to the favourites list to the file
        private void writeFile()
        {
            using (TextWriter tw = new StreamWriter("Favourites.txt"))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    tw.WriteLine(dataGridView1.Rows[i].Cells[0].Value + "," + dataGridView1.Rows[i].Cells[1].Value);
                }
                tw.Close();
            }

        }


        //The method that allows the user to visit the website from favourite list
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                main.visitWebsite(row.Cells[1].Value.ToString());

            }
        }


        // The button that saves the changes to the file
        private void button4_Click(object sender, EventArgs e)
        {
            writeFile();
            System.Windows.Forms.MessageBox.Show("Successfully Changed");
        }
    }
}
