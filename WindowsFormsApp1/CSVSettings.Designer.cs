using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class CSVSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.delimiter_input = new System.Windows.Forms.TextBox();
            this.open_dir_csv = new System.Windows.Forms.Button();
            this.save_csv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filename_input = new System.Windows.Forms.TextBox();
            this.directory_display = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(43, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Delimiter";
            // 
            // delimiter_input
            // 
            this.delimiter_input.Location = new System.Drawing.Point(147, 117);
            this.delimiter_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delimiter_input.Name = "delimiter_input";
            this.delimiter_input.Size = new System.Drawing.Size(201, 22);
            this.delimiter_input.TabIndex = 24;
            // 
            // open_dir_csv
            // 
            this.open_dir_csv.Location = new System.Drawing.Point(370, 31);
            this.open_dir_csv.Margin = new System.Windows.Forms.Padding(4);
            this.open_dir_csv.Name = "open_dir_csv";
            this.open_dir_csv.Size = new System.Drawing.Size(36, 28);
            this.open_dir_csv.TabIndex = 23;
            this.open_dir_csv.Text = "...";
            this.open_dir_csv.UseVisualStyleBackColor = true;
            this.open_dir_csv.Click += new System.EventHandler(this.open_dir_csv_Click);
            // 
            // save_csv
            // 
            this.save_csv.Location = new System.Drawing.Point(306, 167);
            this.save_csv.Margin = new System.Windows.Forms.Padding(4);
            this.save_csv.Name = "save_csv";
            this.save_csv.Size = new System.Drawing.Size(100, 28);
            this.save_csv.TabIndex = 22;
            this.save_csv.Text = "Save";
            this.save_csv.UseVisualStyleBackColor = true;
            this.save_csv.Click += new System.EventHandler(this.save_csv_Click_1);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "FileName";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Directory";
            // 
            // filename_input
            // 
            this.filename_input.Location = new System.Drawing.Point(147, 78);
            this.filename_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filename_input.Name = "filename_input";
            this.filename_input.Size = new System.Drawing.Size(201, 22);
            this.filename_input.TabIndex = 19;
            // 
            // directory_display
            // 
            this.directory_display.Location = new System.Drawing.Point(147, 27);
            this.directory_display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.directory_display.Name = "directory_display";
            this.directory_display.Size = new System.Drawing.Size(201, 22);
            this.directory_display.TabIndex = 18;
            // 
            // CSVSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 226);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delimiter_input);
            this.Controls.Add(this.open_dir_csv);
            this.Controls.Add(this.save_csv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filename_input);
            this.Controls.Add(this.directory_display);
            this.Name = "CSVSettings";
            this.Text = "CSVSettings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox delimiter_input;
        private System.Windows.Forms.Button open_dir_csv;
        private System.Windows.Forms.Button save_csv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filename_input;
        private System.Windows.Forms.TextBox directory_display;

        #endregion
    }
}