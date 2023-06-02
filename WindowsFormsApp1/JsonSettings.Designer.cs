using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class JsonSettings
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
            this.beautifulModeCheckBox = new System.Windows.Forms.CheckBox();
            this.save_json = new System.Windows.Forms.Button();
            this.open_dir_json = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directory_display
            // 
            this.directory_display.Location = new System.Drawing.Point(90, 44);
            this.directory_display.Margin = new System.Windows.Forms.Padding(2);
            this.directory_display.Name = "directory_display";
            this.directory_display.Size = new System.Drawing.Size(152, 20);
            this.directory_display.TabIndex = 0;
            // 
            // filename_input
            // 
            this.filename_input.Location = new System.Drawing.Point(90, 85);
            this.filename_input.Margin = new System.Windows.Forms.Padding(2);
            this.filename_input.Name = "filename_input";
            this.filename_input.Size = new System.Drawing.Size(152, 20);
            this.filename_input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directory";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "FileName";
            // 
            // beautifulModeCheckBox
            // 
            this.beautifulModeCheckBox.Location = new System.Drawing.Point(12, 127);
            this.beautifulModeCheckBox.Name = "beautifulModeCheckBox";
            this.beautifulModeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.beautifulModeCheckBox.TabIndex = 6;
            this.beautifulModeCheckBox.Text = "Beautiful mode";
            this.beautifulModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // save_json
            // 
            this.save_json.Location = new System.Drawing.Point(209, 158);
            this.save_json.Name = "save_json";
            this.save_json.Size = new System.Drawing.Size(75, 23);
            this.save_json.TabIndex = 7;
            this.save_json.Text = "Save";
            this.save_json.UseVisualStyleBackColor = true;
            this.save_json.Click += new System.EventHandler(this.save_json_Click);
            // 
            // open_dir_json
            // 
            this.open_dir_json.Location = new System.Drawing.Point(257, 47);
            this.open_dir_json.Name = "open_dir_json";
            this.open_dir_json.Size = new System.Drawing.Size(27, 23);
            this.open_dir_json.TabIndex = 8;
            this.open_dir_json.Text = "...";
            this.open_dir_json.UseVisualStyleBackColor = true;
            this.open_dir_json.Click += new System.EventHandler(this.open_dir_json_Click);
            // 
            // JsonSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(296, 193);
            this.Controls.Add(this.open_dir_json);
            this.Controls.Add(this.save_json);
            this.Controls.Add(this.beautifulModeCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filename_input);
            this.Controls.Add(this.directory_display);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JsonSettings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button open_dir_json;

        private System.Windows.Forms.CheckBox beautifulModeCheckBox;

        private System.Windows.Forms.TextBox filename_input;

        private System.Windows.Forms.TextBox directory_display;
        private System.Windows.Forms.Button save_json;

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}