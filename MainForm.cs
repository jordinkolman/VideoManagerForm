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
}
