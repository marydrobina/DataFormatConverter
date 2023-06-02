using System;
using System.IO;
using System.Windows.Forms;
using ServiceStack;
using ServiceStack.Text;
using WindowsFormsApp1.JSON;

namespace WindowsFormsApp1
{
    public partial class JsonSettings : Form
    {
        private string dirPath;
        private TestResults _testResults;
        public JsonSettings(TestResults testResults)
        {
            this.dirPath = "";
            _testResults = testResults;
            InitializeComponent();
        }

        private void open_dir_json_Click(object sender, EventArgs e)
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

        private void save_json_Click(object sender, EventArgs e)
        {
            if (!filename_input.Text.IsEmpty() && !directory_display.Text.IsEmpty() && beautifulModeCheckBox.Checked)
            {
                string path = directory_display.Text + @"\" + filename_input.Text + ".json";
                Writer writer = new JsonWriter();
                writer.write(path, _testResults, true);
                this.Close();
            }

            if (!filename_input.Text.IsEmpty() && !directory_display.Text.IsEmpty() && !beautifulModeCheckBox.Checked)
            {
                string path = directory_display.Text + @"\" + filename_input.Text + ".json";
                Writer writer = new JsonWriter();
                writer.write(path, _testResults);
                this.Close();
            }
        }
    }
}