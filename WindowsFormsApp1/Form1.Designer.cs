namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.open_file_button = new System.Windows.Forms.Button();
            this.json_convert_button = new System.Windows.Forms.Button();
            this.xml_convert_button = new System.Windows.Forms.Button();
            this.csv_convert_button = new System.Windows.Forms.Button();
            this.xlsx_convert_button = new System.Windows.Forms.Button();
            this.path_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // open_file_button
            // 
            this.open_file_button.Location = new System.Drawing.Point(69, 125);
            this.open_file_button.Name = "open_file_button";
            this.open_file_button.Size = new System.Drawing.Size(220, 141);
            this.open_file_button.TabIndex = 0;
            this.open_file_button.Text = "Open File";
            this.open_file_button.UseVisualStyleBackColor = true;
            this.open_file_button.Click += new System.EventHandler(this.open_file_button_Click);
            // 
            // json_convert_button
            // 
            this.json_convert_button.Location = new System.Drawing.Point(555, 29);
            this.json_convert_button.Name = "json_convert_button";
            this.json_convert_button.Size = new System.Drawing.Size(106, 84);
            this.json_convert_button.TabIndex = 1;
            this.json_convert_button.Text = "Convert to JSON";
            this.json_convert_button.UseVisualStyleBackColor = true;
            this.json_convert_button.Click += new System.EventHandler(this.json_convert_button_Click);
            // 
            // xml_convert_button
            // 
            this.xml_convert_button.Location = new System.Drawing.Point(555, 119);
            this.xml_convert_button.Name = "xml_convert_button";
            this.xml_convert_button.Size = new System.Drawing.Size(106, 84);
            this.xml_convert_button.TabIndex = 2;
            this.xml_convert_button.Text = "Convert to XML";
            this.xml_convert_button.UseVisualStyleBackColor = true;
            this.xml_convert_button.Click += new System.EventHandler(this.xml_convert_button_Click);
            // 
            // csv_convert_button
            // 
            this.csv_convert_button.Location = new System.Drawing.Point(555, 209);
            this.csv_convert_button.Name = "csv_convert_button";
            this.csv_convert_button.Size = new System.Drawing.Size(106, 84);
            this.csv_convert_button.TabIndex = 3;
            this.csv_convert_button.Text = "Convert to CSV";
            this.csv_convert_button.UseVisualStyleBackColor = true;
            this.csv_convert_button.Click += new System.EventHandler(this.csv_convert_button_Click);
            // 
            // xlsx_convert_button
            // 
            this.xlsx_convert_button.Location = new System.Drawing.Point(555, 299);
            this.xlsx_convert_button.Name = "xlsx_convert_button";
            this.xlsx_convert_button.Size = new System.Drawing.Size(106, 84);
            this.xlsx_convert_button.TabIndex = 4;
            this.xlsx_convert_button.Text = "Convert to XLSX";
            this.xlsx_convert_button.UseVisualStyleBackColor = true;
            this.xlsx_convert_button.Click += new System.EventHandler(this.xlsx_convert_button_Click);
            // 
            // path_output
            // 
            this.path_output.Location = new System.Drawing.Point(69, 360);
            this.path_output.Name = "path_output";
            this.path_output.Size = new System.Drawing.Size(421, 23);
            this.path_output.TabIndex = 5;
            this.path_output.Text = "No file is opened";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.path_output);
            this.Controls.Add(this.xlsx_convert_button);
            this.Controls.Add(this.csv_convert_button);
            this.Controls.Add(this.xml_convert_button);
            this.Controls.Add(this.json_convert_button);
            this.Controls.Add(this.open_file_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label path_output;

        private System.Windows.Forms.Button xlsx_convert_button;

        private System.Windows.Forms.Button json_convert_button;

        private System.Windows.Forms.Button open_file_button;

        private System.Windows.Forms.Button xml_convert_button;
        private System.Windows.Forms.Button csv_convert_button;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;

        #endregion

        private System.Windows.Forms.Button button1;
    }
}

