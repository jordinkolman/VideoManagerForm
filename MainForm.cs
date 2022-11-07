using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolman_CourseProject_Part1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string nl = "\r\n";

            if (string.IsNullOrEmpty(titleText.Text))
            {
                //Title is blank
                MessageBox.Show("ERROR: Please enter a valid song title");
            }
            else if (string.IsNullOrEmpty(artistText.Text))
            {
                //Artist is blank
                MessageBox.Show("ERROR: Please enter a valid artist");
            }
            else if (string.IsNullOrEmpty(genreText.Text))
            {
                //Genre is blank
                MessageBox.Show("ERROR: Please enter a valid genre");
            }
            else if (string.IsNullOrEmpty(yearText.Text))
            {
                //Year is blank
                MessageBox.Show("ERROR: Please enter a valid year");
            }
            else if (string.IsNullOrEmpty(urlText.Text))
            {
                //url is blank
                MessageBox.Show("Error: Please enter a valid url");
            }
            else
            {
                //Add title to ListBox
                songList.Items.Add(titleText.Text);

                //Build the output text
                sb.Append(titleText.Text);
                sb.Append(nl);
                sb.Append(artistText.Text);
                sb.Append(nl);
                sb.Append(genreText.Text);
                sb.Append(nl);
                sb.Append(yearText.Text);
                sb.Append(nl);
                sb.Append(urlText.Text);
                sb.Append(nl);
                sb.Append(nl);

                outputText.Text = sb.ToString();
            }
        }

        private void songListLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void allSongsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string nl = "\r\n";

            // Build the output text
            foreach (var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(nl);
            }

            // Put the output text into the output textbox
            outputText.Text = sb.ToString();
        }
    }
}
