using System;
using System.Windows.Forms;
using ServiceStack;
using WindowsFormsApp1.CSV;
using WindowsFormsApp1.XML;

namespace WindowsFormsApp1
{
    public partial class CSVSettings : Form
    {
        private string dirPath;
        private TestResults _testResults;
        public CSVSettings(TestResults testResults)
        {
            this.dirPath = "";
            _testResults = testResults;
            InitializeComponent();
        }

        private void open_dir_csv_Click(object sender, EventArgs e)
        {
            using(var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    dirPath = fbd.SelectedPath;
                    directory_display.Text = dirPath;
                }
            }
        }

        private void save_csv_Click_1(object sender, EventArgs e)
        {
            if (!filename_input.Text.IsEmpty() && !directory_display.Text.IsEmpty() && !delimiter_input.Text.IsEmpty())
            {
                string path = directory_display.Text + @"\" + filename_input.Text + ".csv";
                Writer writer = new CSVWriter();
                writer.write(path, _testResults, delimiter_input.Text);
                this.Close();
            }

            if (!filename_input.Text.IsEmpty() && !directory_display.Text.IsEmpty() && delimiter_input.Text.IsEmpty())
            {
                string path = directory_display.Text + @"\" + filename_input.Text + ".csv";
                Writer writer = new CSVWriter();
                writer.write(path, _testResults);
                this.Close();
            }
        }
        
    }
}