using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

using Savings;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        private string connectionString = @" Data Source =";
        public static string addType;
        public string path;
        int sumYearly = 0;
        int sumMonthly = 0;
        int sumWanted = 0;

        public Main()
        {
            InitializeComponent();
            GetDatabasePath();
            DrawMonthlyDataGridView();
            DrawYearlyDataGridView();
            DrawWantedDataGridView();
            GetTotals();
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
            }
            else
            {
                MessageBox.Show("The file path for the database is invalid, goodbye.", "Invalid File Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void SetDatabasePath()
        {
            Variables.dataPath = connectionString + path;
        }

        public void DrawMonthlyDataGridView()
        {
            monthlyDataGridView.Rows.Clear();
            SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
            con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Monthly", con);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    monthlyDataGridView.Rows.Add(new object[] {
                    read.GetValue(0),  // U can use column index
                    read.GetValue(read.GetOrdinal("Description")),  // Or column name like this
                    read.GetValue(read.GetOrdinal("Category")),
                    read.GetValue(read.GetOrdinal("Amount"))
                    });
                }
            }
            con.Close();
            //Set amount column to currency format
            monthlyDataGridView.Columns["monthlyAmtColumn"].DefaultCellStyle.Format = "c";
            GetTotals();
        }

        public void DrawYearlyDataGridView()
        {
            yearlyDataGridView.Rows.Clear();
            SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
            con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Yearly", con);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    yearlyDataGridView.Rows.Add(new object[] {
                    read.GetValue(0),  // U can use column index
                    read.GetValue(read.GetOrdinal("Description")),  // Or column name like this
                    read.GetValue(read.GetOrdinal("Category")),
                    read.GetValue(read.GetOrdinal("Amount"))
                    });
                }
            }
            con.Close();
            //Set amount column to currency format
            yearlyDataGridView.Columns["yearlyAmtColumn"].DefaultCellStyle.Format = "c";
            GetTotals();
        }

        public void DrawWantedDataGridView()
        {
            wantedDataGridView.Rows.Clear();
            SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
            con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From Wanted", con);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    wantedDataGridView.Rows.Add(new object[] {
                    read.GetValue(0),  // U can use column index
                    read.GetValue(read.GetOrdinal("Description")),  // Or column name like this
                    read.GetValue(read.GetOrdinal("Category")),
                    read.GetValue(read.GetOrdinal("Amount"))
                    });
                }
            }
            con.Close();
            //Set amount column to currency format
            wantedDataGridView.Columns["wantedAmtColumn"].DefaultCellStyle.Format = "c";
            GetTotals();
        }

        public void GetTotals()
        {
            sumYearly = 0;
            sumMonthly = 0;
            sumWanted = 0;

            for (int i = 0; i < yearlyDataGridView.Rows.Count; ++i)
            {
                sumYearly += Convert.ToInt32(yearlyDataGridView.Rows[i].Cells[3].Value);
            }

            for (int i = 0; i < monthlyDataGridView.Rows.Count; ++i)
            {
                sumMonthly += Convert.ToInt32(monthlyDataGridView.Rows[i].Cells[3].Value);
            }

            for (int i = 0; i < wantedDataGridView.Rows.Count; ++i)
            {
                sumWanted += Convert.ToInt32(wantedDataGridView.Rows[i].Cells[3].Value);
            }

            SetTotalLabels();
        }

        public void SetTotalLabels()
        {
            yearlyTotalLabel.Text = sumYearly.ToString("C", CultureInfo.CurrentCulture);
            monthlyTotalLabel.Text = sumMonthly.ToString("C", CultureInfo.CurrentCulture);
            wantedTotalLabel.Text = sumWanted.ToString("C", CultureInfo.CurrentCulture);
        }

        private void RemoveMonthlyRecord()
        {
            int selectedIndex = monthlyDataGridView.SelectedRows[0].Index;

            try
            {
                SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM Monthly WHERE Id=" + int.Parse(monthlyDataGridView[0, selectedIndex].Value.ToString()), con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                DrawMonthlyDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetTotals();
        }

        private void RemoveYearlyRecord()
        {
            int selectedIndex = yearlyDataGridView.SelectedRows[0].Index;

            try
            {
                SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM Yearly WHERE Id=" + int.Parse(yearlyDataGridView[0, selectedIndex].Value.ToString()), con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                DrawYearlyDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetTotals();
        }

        private void RemoveWantedRecord()
        {
            int selectedIndex = wantedDataGridView.SelectedRows[0].Index;

            try
            {
                SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = String.Format("DELETE FROM Yearly WHERE Id=" + int.Parse(wantedDataGridView[0, selectedIndex].Value.ToString()), con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                DrawWantedDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GetTotals();
        }

        #region Buttons
        private void addWantedButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the AddItem class
            AddItem addItemForm = new AddItem(this);

            // Set the add type
            addType = "Wanted";

            // Show the AddItem form
            addItemForm.Show();
        }

        private void addMonthlyButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the AddItem class
            AddItem addItemForm = new AddItem(this);

            // Set the add type
            addType = "Monthly";

            // Show the AddItem form
            addItemForm.Show();
        }

        private void addYearlyButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the AddItem class
            AddItem addItemForm = new AddItem(this);

            // Set the add type
            addType = "Yearly";

            // Show the AddItem form
            addItemForm.Show();
        }

        private void removeMonthlyButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to remove the selected record?", "Remove Record?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                RemoveMonthlyRecord();
            }

        }

        private void removeYearlyButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to remove the selected record?", "Remove Record?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                RemoveYearlyRecord();
            }
        }

        private void removeWantedButton_Click(object sender, EventArgs e)
        {
            if (wantedDataGridView.Rows.Count != 0)
            {
                if (MessageBox.Show("Are you sure you wish to remove the selected record?", "Remove Record?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    RemoveWantedRecord();
                }
            }
            else
            {
                MessageBox.Show("Trying to imploded the universe are we? I can't delete nothing.");
            }
        }
        #endregion
    }
}
