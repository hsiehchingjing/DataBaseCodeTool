using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            comboBox_DatabaseType.SelectedIndex = 0;
            List<CodeLanguage> listCodeLanguage = JsonConvert.DeserializeObject<List<CodeLanguage>>(ConfigurationManager.AppSettings["CodeLanguage"]);
            comboBox_CodeLanguage.DataSource = listCodeLanguage;
            comboBox_CodeLanguage.DisplayMember = "name";
            comboBox_CodeLanguage.ValueMember = "type";
            comboBox_DatabaseType.SelectedIndex = 0;
        }

        private void comboBox_DatabaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Database> listDatabase = JsonConvert.DeserializeObject<List<Database>>(ConfigurationManager.AppSettings["Database"]);
            comboBox_Database.DataSource = listDatabase.FindAll(a => a.type == comboBox_DatabaseType.SelectedValue.ToString());
        }
    }
}
