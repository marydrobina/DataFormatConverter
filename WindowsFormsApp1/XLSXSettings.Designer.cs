using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class XLSXSettings
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
            this.sheet_label = new System.Windows.Forms.Label();
            this.sheet_name_input = new System.Windows.Forms.TextBox();
            this.open_dir_xlsx = new System.Windows.Forms.Button();
            this.save_xlsx = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filename_input = new System.Windows.Forms.TextBox();
            this.directory_display = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sheet_label
            // 
            this.sheet_label.Location = new System.Drawing.Point(32, 108);
            this.sheet_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sheet_label.Name = "sheet_label";
            this.sheet_label.Size = new System.Drawing.Size(97, 28);
            this.sheet_label.TabIndex = 25;
            this.sheet_label.Text = "Sheet name";
            // 
            // sheet_name_input
            // 
            this.sheet_name_input.Location = new System.Drawing.Point(136, 108);
            this.sheet_name_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sheet_name_input.Name = "sheet_name_input";
            this.sheet_name_input.Size = new System.Drawing.Size(201, 22);
            this.sheet_name_input.TabIndex = 24;
            // 
            // open_dir_xlsx
            // 
            this.open_dir_xlsx.Location = new System.Drawing.Point(359, 22);
            this.open_dir_xlsx.Margin = new System.Windows.Forms.Padding(4);
            this.open_dir_xlsx.Name = "open_dir_xlsx";
            this.open_dir_xlsx.Size = new System.Drawing.Size(36, 28);
            this.open_dir_xlsx.TabIndex = 23;
            this.open_dir_xlsx.Text = "...";
            this.open_dir_xlsx.UseVisualStyleBackColor = true;
            this.open_dir_xlsx.Click += new System.EventHandler(this.open_dir_xlsx_Click);
            // 
            // save_xlsx
            // 
            this.save_xlsx.Location = new System.Drawing.Point(295, 158);
            this.save_xlsx.Margin = new System.Windows.Forms.Padding(4);
            this.save_xlsx.Name = "save_xlsx";
            this.save_xlsx.Size = new System.Drawing.Size(100, 28);
            this.save_xlsx.TabIndex = 22;
            this.save_xlsx.Text = "Save";
            this.save_xlsx.UseVisualStyleBackColor = true;
            this.save_xlsx.Click += new System.EventHandler(this.save_xlsx_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "FileName";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Directory";
            // 
            // filename_input
            // 
            this.filename_input.Location = new System.Drawing.Point(136, 69);
            this.filename_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filename_input.Name = "filename_input";
            this.filename_input.Size = new System.Drawing.Size(201, 22);
            this.filename_input.TabIndex = 19;
            // 
            // directory_display
            // 
            this.directory_display.Location = new System.Drawing.Point(136, 18);
            this.directory_display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.directory_display.Name = "directory_display";
            this.directory_display.Size = new System.Drawing.Size(201, 22);
            this.directory_display.TabIndex = 18;
            // 
            // XLSXSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 226);
            this.Controls.Add(this.sheet_label);
            this.Controls.Add(this.sheet_name_input);
            this.Controls.Add(this.open_dir_xlsx);
            this.Controls.Add(this.save_xlsx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filename_input);
            this.Controls.Add(this.directory_display);
            this.Name = "XLSXSettings";
            this.Text = "XLSXSettings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label sheet_label;
        private System.Windows.Forms.TextBox sheet_name_input;
        private System.Windows.Forms.Button open_dir_xlsx;
        private System.Windows.Forms.Button save_xlsx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filename_input;
        private System.Windows.Forms.TextBox directory_display;

        #endregion
    }
}