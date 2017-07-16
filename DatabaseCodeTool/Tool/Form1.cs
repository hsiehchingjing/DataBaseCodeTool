using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tool.Common;
using Tool.Model;

namespace Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitComponetData();
        }

        private void InitComponetData()
        {
         
            List<DatabaseType> listDatabaseType = JsonConvert.DeserializeObject<List<DatabaseType>>(ConfigurationManager.AppSettings["DatabaseType"]);
            comboBox_DatabaseType.DataSource = listDatabaseType;
            comboBox_DatabaseType.DisplayMember = "name";
            comboBox_DatabaseType.ValueMember = "value";
            comboBox_DatabaseType.SelectedIndex = 0;
            List<Database> listDatabase = JsonConvert.DeserializeObject<List<Database>>(ConfigurationManager.AppSettings["Database"]);
            comboBox_Database.DataSource = listDatabase.FindAll(a=>a.type== comboBox_DatabaseType.SelectedValue.ToString());
            comboBox_Database.DisplayMember = "name";
            comboBox_Database.ValueMember = "value";
            comboBox_Database.SelectedIndex = 0;
            List<CodeLanguage> listCodeLanguage = JsonConvert.DeserializeObject<List<CodeLanguage>>(ConfigurationManager.AppSettings["CodeLanguage"]);
            comboBox_CodeLanguage.DataSource = listCodeLanguage;
            comboBox_CodeLanguage.DisplayMember = "name";
            comboBox_CodeLanguage.ValueMember = "type";
            comboBox_CodeLanguage.SelectedIndex = 0;
            var databaseService= DatabaseFactory.GetIDatabase(comboBox_DatabaseType.SelectedValue.ToString());
            List<string> listTables = databaseService.GetTables(((Database)comboBox_Database.SelectedItem).name, ((Database)comboBox_Database.SelectedItem).value);
            listBox_Table.DataSource = listTables;
            comboBox_CodeType.SelectedIndex = 0;
        }

        private void comboBox_DatabaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Database> listDatabase = JsonConvert.DeserializeObject<List<Database>>(ConfigurationManager.AppSettings["Database"]);
            comboBox_Database.DataSource = listDatabase.FindAll(a => a.type == comboBox_DatabaseType.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (folderBrowserDialog_select.ShowDialog() == DialogResult.OK || folderBrowserDialog_select.ShowDialog() == DialogResult.Yes)
            {
                textBox_CodePath.Text = folderBrowserDialog_select.SelectedPath;
            }
        }

        private void button_CreateCode_Click(object sender, EventArgs e)
        {
            string codeTpl = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Template/dal.cst");
            List<string> tables = new List<string>();
            for(var i=0;i< listBox_Table.SelectedItems.Count; i++)
            {
                tables.Add(listBox_Table.SelectedItems[i].ToString());
            }
            var path = textBox_CodePath.Text + "/{Table}dal.cs";
            tables.ForEach(table => {
                string codeTxt = codeTpl.Replace("{Table}", table);
                File.WriteAllText(path.Replace("{Table}", table), codeTxt);
            });
         }
    }
}
