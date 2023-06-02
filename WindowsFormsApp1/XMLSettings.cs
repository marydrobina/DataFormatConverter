using System;
using System.Windows.Forms;
using ServiceStack;
using WindowsFormsApp1.XML;

namespace WindowsFormsApp1
{
    public partial class XMLSettings : Form
    {
        private string dirPath;
        private TestResults _testResults;
        public XMLSettings(TestResults testResults)
        {
            this.dirPath = "";
            _testResults = testResults;
            InitializeComponent();
        }
        
        private void open_dir_xml_Click(object sender, EventArgs e)
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

        private void save_xml_Click(object sender, EventArgs e)
        {
            if (!filename_input.Text.IsEmpty() && !directory_display.Text.IsEmpty() && !root_input.Text.IsEmpty())
            {
                string path = directory_display.Text + @"\" + filename_input.Text + ".xml";
                Writer writer = new XMLWriter();
                writer.write(path, _testResults, root_input.Text);
                this.Close();
            }

            if (!filename_input.Text.IsEmpty() && !directory_display.Text.IsEmpty() && root_input.Text.IsEmpty())
            {
                string path = directory_display.Text + @"\" + filename_input.Text + ".xml";
                Writer writer = new XMLWriter();
                writer.write(path, _testResults);
                this.Close();
            }
        }

        
    }
}