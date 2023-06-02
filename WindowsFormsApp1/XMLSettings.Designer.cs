using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class XMLSettings
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
            this.directory_display = new System.Windows.Forms.TextBox();
            this.filename_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save_xml = new System.Windows.Forms.Button();
            this.open_dir_xml = new System.Windows.Forms.Button();
            this.root_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directory_display
            // 
            this.directory_display.Location = new System.Drawing.Point(133, 24);
            this.directory_display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.directory_display.Name = "directory_display";
            this.directory_display.Size = new System.Drawing.Size(201, 22);
            this.directory_display.TabIndex = 9;
            // 
            // filename_input
            // 
            this.filename_input.Location = new System.Drawing.Point(133, 75);
            this.filename_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filename_input.Name = "filename_input";
            this.filename_input.Size = new System.Drawing.Size(201, 22);
            this.filename_input.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Directory";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(29, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "FileName";
            // 
            // save_xml
            // 
            this.save_xml.Location = new System.Drawing.Point(292, 164);
            this.save_xml.Margin = new System.Windows.Forms.Padding(4);
            this.save_xml.Name = "save_xml";
            this.save_xml.Size = new System.Drawing.Size(100, 28);
            this.save_xml.TabIndex = 14;
            this.save_xml.Text = "Save";
            this.save_xml.UseVisualStyleBackColor = true;
            this.save_xml.Click += new System.EventHandler(this.save_xml_Click);
            // 
            // open_dir_xml
            // 
            this.open_dir_xml.Location = new System.Drawing.Point(356, 28);
            this.open_dir_xml.Margin = new System.Windows.Forms.Padding(4);
            this.open_dir_xml.Name = "open_dir_xml";
            this.open_dir_xml.Size = new System.Drawing.Size(36, 28);
            this.open_dir_xml.TabIndex = 15;
            this.open_dir_xml.Text = "...";
            this.open_dir_xml.UseVisualStyleBackColor = true;
            this.open_dir_xml.Click += new System.EventHandler(this.open_dir_xml_Click);
            // 
            // root_input
            // 
            this.root_input.Location = new System.Drawing.Point(133, 114);
            this.root_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.root_input.Name = "root_input";
            this.root_input.Size = new System.Drawing.Size(201, 22);
            this.root_input.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(29, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Root";
            // 
            // XMLSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 222);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.root_input);
            this.Controls.Add(this.open_dir_xml);
            this.Controls.Add(this.save_xml);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filename_input);
            this.Controls.Add(this.directory_display);
            this.Name = "XMLSettings";
            this.Text = "XMLSettings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox root_input;

        private System.Windows.Forms.Button open_dir_xml;
        private System.Windows.Forms.Button save_xml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filename_input;
        private System.Windows.Forms.TextBox directory_display;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}