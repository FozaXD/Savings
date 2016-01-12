using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savings
{
    public partial class StartupWindow : Form
    {
        public string path;

        public StartupWindow()
        {
            InitializeComponent();
        }

        public void GetDatabasePath()
        {
            DialogResult dr = new DialogResult();

            DatabasePath dataBasePath = new DatabasePath();
            dr = dataBasePath.ShowDialog();
            if (dr == DialogResult.OK)
            {
                path = dataBasePath.DataFilePath;
                SetDatabasePath();
                this.Close();
            }
            else
            {
                MessageBox.Show("The file path for the database is invalid, goodbye.", "Invalid File Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void SetDatabasePath()
        {
            Variables.dataPath = Variables.connectionString + path;
        }

        private void existingAccountButton_Click(object sender, EventArgs e)
        {
            GetDatabasePath();      
        }
    }
}
