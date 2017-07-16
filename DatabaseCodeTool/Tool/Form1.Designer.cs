namespace Tool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_DatabaseType = new System.Windows.Forms.ComboBox();
            this.comboBox_Database = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_CodePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog_select = new System.Windows.Forms.FolderBrowserDialog();
            this.button_CreateCode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_CodeLanguage = new System.Windows.Forms.ComboBox();
            this.listBox_Columus = new System.Windows.Forms.ListBox();
            this.comboBox_CodeType = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox_Table = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBox_DatabaseType
            // 
            this.comboBox_DatabaseType.FormattingEnabled = true;
            this.comboBox_DatabaseType.Location = new System.Drawing.Point(16, 12);
            this.comboBox_DatabaseType.Name = "comboBox_DatabaseType";
            this.comboBox_DatabaseType.Size = new System.Drawing.Size(121, 23);
            this.comboBox_DatabaseType.TabIndex = 0;
            this.comboBox_DatabaseType.SelectedIndexChanged += new System.EventHandler(this.comboBox_DatabaseType_SelectedIndexChanged);
            // 
            // comboBox_Database
            // 
            this.comboBox_Database.FormattingEnabled = true;
            this.comboBox_Database.Location = new System.Drawing.Point(16, 62);
            this.comboBox_Database.Name = "comboBox_Database";
            this.comboBox_Database.Size = new System.Drawing.Size(213, 23);
            this.comboBox_Database.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 239);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1030, 265);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sql语句";
            // 
            // textBox_CodePath
            // 
            this.textBox_CodePath.Location = new System.Drawing.Point(178, 557);
            this.textBox_CodePath.Name = "textBox_CodePath";
            this.textBox_CodePath.Size = new System.Drawing.Size(492, 25);
            this.textBox_CodePath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "代码文件生成目录位置";
            // 
            // button_CreateCode
            // 
            this.button_CreateCode.Location = new System.Drawing.Point(678, 606);
            this.button_CreateCode.Name = "button_CreateCode";
            this.button_CreateCode.Size = new System.Drawing.Size(176, 55);
            this.button_CreateCode.TabIndex = 6;
            this.button_CreateCode.Text = "生成代码";
            this.button_CreateCode.UseVisualStyleBackColor = true;
            this.button_CreateCode.Click += new System.EventHandler(this.button_CreateCode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "状态";
            // 
            // comboBox_CodeLanguage
            // 
            this.comboBox_CodeLanguage.FormattingEnabled = true;
            this.comboBox_CodeLanguage.Location = new System.Drawing.Point(903, 12);
            this.comboBox_CodeLanguage.Name = "comboBox_CodeLanguage";
            this.comboBox_CodeLanguage.Size = new System.Drawing.Size(121, 23);
            this.comboBox_CodeLanguage.TabIndex = 8;
            // 
            // listBox_Columus
            // 
            this.listBox_Columus.FormattingEnabled = true;
            this.listBox_Columus.ItemHeight = 15;
            this.listBox_Columus.Location = new System.Drawing.Point(596, 12);
            this.listBox_Columus.Name = "listBox_Columus";
            this.listBox_Columus.Size = new System.Drawing.Size(258, 184);
            this.listBox_Columus.TabIndex = 11;
            // 
            // comboBox_CodeType
            // 
            this.comboBox_CodeType.FormattingEnabled = true;
            this.comboBox_CodeType.Items.AddRange(new object[] {
            "五种基础操作",
            "特定sql方法"});
            this.comboBox_CodeType.Location = new System.Drawing.Point(16, 157);
            this.comboBox_CodeType.Name = "comboBox_CodeType";
            this.comboBox_CodeType.Size = new System.Drawing.Size(121, 23);
            this.comboBox_CodeType.TabIndex = 12;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "全类",
            "函数"});
            this.comboBox4.Location = new System.Drawing.Point(178, 522);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 23);
            this.comboBox4.TabIndex = 13;
            this.comboBox4.Text = "全类";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(677, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "选择目录";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox_Table
            // 
            this.listBox_Table.FormattingEnabled = true;
            this.listBox_Table.ItemHeight = 15;
            this.listBox_Table.Location = new System.Drawing.Point(292, 12);
            this.listBox_Table.Name = "listBox_Table";
            this.listBox_Table.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_Table.Size = new System.Drawing.Size(258, 184);
            this.listBox_Table.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 686);
            this.Controls.Add(this.listBox_Table);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox_CodeType);
            this.Controls.Add(this.listBox_Columus);
            this.Controls.Add(this.comboBox_CodeLanguage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_CreateCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_CodePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox_Database);
            this.Controls.Add(this.comboBox_DatabaseType);
            this.Name = "Form1";
            this.Text = "数据代码生成效率工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_DatabaseType;
        private System.Windows.Forms.ComboBox comboBox_Database;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_CodePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_select;
        private System.Windows.Forms.Button button_CreateCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_CodeLanguage;
        private System.Windows.Forms.ListBox listBox_Columus;
        private System.Windows.Forms.ComboBox comboBox_CodeType;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox_Table;
    }
}

