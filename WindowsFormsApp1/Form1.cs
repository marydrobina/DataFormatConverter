using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly TestResultsService _testResultsService;
        public Form1()
        {
            InitializeComponent();
            _testResultsService = new TestResultsServiceImpl();
        }

        private void open_file_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Supported files (*.json;*.xml;*.xlsx;*.csv)|*.json;*.xml;*.xlsx;*.csv|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName;
                path_output.Text = filePath;
                String extension = Path.GetExtension(filePath);
                _testResultsService.readData(filePath, extension);
            }
        }

        private void json_convert_button_Click(object sender, EventArgs e)
        {
            var dialogForm = new JsonSettings(_testResultsService.getTestResults());
            dialogForm.Show();
        }

        private void xml_convert_button_Click(object sender, EventArgs e)
        {
            var dialogForm = new XMLSettings(_testResultsService.getTestResults());
            dialogForm.Show();
        }

        private void csv_convert_button_Click(object sender, EventArgs e)
        {
            var dialogForm = new CSVSettings(_testResultsService.getTestResults());
            dialogForm.Show();
        }

        private void xlsx_convert_button_Click(object sender, EventArgs e)
        {
            var dialogForm = new XLSXSettings(_testResultsService.getTestResults());
            dialogForm.Show();
        }
    }
}
