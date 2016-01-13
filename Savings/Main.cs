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
        public static string addType;
        decimal sumYearly = 0.00m;
        decimal sumMonthly = 0.00m;
        decimal sumWanted = 0.00m;

        public Main()
        {
            InitializeComponent();

            Startup1();

            Draw();
            DrawUserInfo();
        }

        public void Draw()
        {
            DrawYearlyDataGridView();
            DrawMonthlyDataGridView();
            DrawWantedDataGridView();
            GetTotals();
        }

        public void DrawUserInfo()
        {
            accountNameLabel.Text = Variables.accountName;
            accountNameLabel.Visible = true;
        }

        public void Startup1()
        {
            StartupWindow startup = new StartupWindow();
            var dialogResult = startup.ShowDialog();
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
            if (monthlyDataGridView.Rows.Count != 0)
            {
                removeMonthlyButton.Enabled = true;
            }
            else
            {
                removeMonthlyButton.Enabled = false;
            }
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
            if (yearlyDataGridView.Rows.Count != 0)
            {
                removeYearlyButton.Enabled = true;
            }
            else
            {
                removeYearlyButton.Enabled = false;
            }
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
            if (wantedDataGridView.Rows.Count != 0)
            {
                removeWantedButton.Enabled = true;
            }
            else
            {
                removeWantedButton.Enabled = false;
            }
        }

        public void GetTotals()
        {
            sumYearly = 0.00m;
            sumMonthly = 0.00m;
            sumWanted = 0.00m;

            yearlyTotalLabel.Visible = false;
            monthlyTotalLabel.Visible = false;
            wantedTotalLabel.Visible = false;
            overallTotal.Visible = false;

            for (int i = 0; i < yearlyDataGridView.Rows.Count; ++i)
            {
                sumYearly += Convert.ToDecimal(yearlyDataGridView.Rows[i].Cells[3].Value);
            }

            for (int e = 0; e < monthlyDataGridView.Rows.Count; ++e)
            {
                sumMonthly += Convert.ToDecimal(monthlyDataGridView.Rows[e].Cells[3].Value);
            }

            for (int f = 0; f < wantedDataGridView.Rows.Count; ++f)
            {
                sumWanted += Convert.ToDecimal(wantedDataGridView.Rows[f].Cells[3].Value);
            }

            SetTotalLabels();
        }

        public void SetTotalLabels()
        {
            yearlyTotalLabel.Text = sumYearly.ToString("C", CultureInfo.CurrentCulture);
            monthlyTotalLabel.Text = sumMonthly.ToString("C", CultureInfo.CurrentCulture);
            wantedTotalLabel.Text = sumWanted.ToString("C", CultureInfo.CurrentCulture);

            overallTotal.Text = decimal.Add(decimal.Add(sumYearly, sumMonthly), sumWanted).ToString("C", CultureInfo.CurrentCulture);
            yearlyTotalLabel.Visible = true;
            monthlyTotalLabel.Visible = true;
            wantedTotalLabel.Visible = true;
            overallTotal.Visible = true;
        }

        #region Buttons

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
                    cmd.CommandText = String.Format("DELETE FROM Wanted WHERE Id=" + int.Parse(wantedDataGridView[0, selectedIndex].Value.ToString()), con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                DrawWantedDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addWantedButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the AddItem class
            AddItem addItemForm = new AddItem(this);

            // Set the add type
            addType = "Wanted";

            // Show the AddItem form
            addItemForm.ShowDialog();
            Draw();
        }

        private void addMonthlyButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the AddItem class
            AddItem addItemForm = new AddItem(this);

            // Set the add type
            addType = "Monthly";

            // Show the AddItem form
            addItemForm.ShowDialog();
            Draw();
        }

        private void addYearlyButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the AddItem class
            AddItem addItemForm = new AddItem(this);

            // Set the add type
            addType = "Yearly";

            // Show the AddItem form
            addItemForm.ShowDialog();
            Draw();
        }

        private void removeMonthlyButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to remove the selected record?", "Remove Record?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                RemoveMonthlyRecord();
            }      
            Draw();
        }

        private void removeYearlyButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to remove the selected record?", "Remove Record?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                RemoveYearlyRecord();
            }
            Draw();
        }

        private void removeWantedButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to remove the selected record?", "Remove Record?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                RemoveWantedRecord();
            }
            Draw();
        }
        #endregion
    }
}
