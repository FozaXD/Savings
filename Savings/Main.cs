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

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public static string connectionString = @" Data Source = F:\Databases\SavingsMaster.db; Version = 3 ";
        public static string addType;

        public Main()
        {
            InitializeComponent();

            DrawMonthlyDataGridView();
            DrawYearlyDataGridView();
            DrawWantedDataGridView();
        }

        public void DrawMonthlyDataGridView()
        {
            monthlyDataGridView.Rows.Clear();
            SQLiteConnection con = new SQLiteConnection(connectionString);
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
        }

        public void DrawYearlyDataGridView()
        {
            yearlyDataGridView.Rows.Clear();
            SQLiteConnection con = new SQLiteConnection(connectionString);
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
        }

        public void DrawWantedDataGridView()
        {
            wantedDataGridView.Rows.Clear();
            SQLiteConnection con = new SQLiteConnection(connectionString);
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
        }

        private void RemoveMonthlyRecord()
        {
            int selectedIndex = monthlyDataGridView.SelectedRows[0].Index;

            try
            {
                SQLiteConnection con = new SQLiteConnection(connectionString);
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
                SQLiteConnection con = new SQLiteConnection(connectionString);
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
                SQLiteConnection con = new SQLiteConnection(connectionString);
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
