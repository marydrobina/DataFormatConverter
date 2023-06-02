using System;
using System.Windows.Forms;
using ServiceStack;
using WindowsFormsApp1.XLSX;
using WindowsFormsApp1.XML;

namespace WindowsFormsApp1
{
    public partial class XLSXSettings : Form
    {
        private string dirPath;
        private TestResults _testResults;
        public XLSXSettings(TestResults testResults)
        {
            this.dirPath = "";
            _testResults = testResults;
            InitializeComponent();
        }

        private void open_dir_xlsx_Click(object sender, EventArgs e)
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

        private void save_xlsx_Click(object sender, EventArgs e)
        {
            if (!filename_input.Text.IsEmpty() && !directory_display.Text.IsEmpty() && !sheet_name_input.Text.IsEmpty())
            {
                string path = directory_display.Text + @"\" + filename_input.Text + ".xlsx";
                Writer writer = new XLSXWriter();
                writer.write(path, _testResults, sheet_name_input.Text);
                this.Close();
            }

            if (!filename_input.Text.IsEmpty() && !directory_display.Text.IsEmpty() && sheet_name_input.Text.IsEmpty())
            {
                string path = directory_display.Text + @"\" + filename_input.Text + ".xlsx";
                Writer writer = new XLSXWriter();
                writer.write(path, _testResults);
                this.Close();
            }
        }
    }
}