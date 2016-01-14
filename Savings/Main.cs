﻿using System;
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

namespace Savings
{
    public partial class Main : Form
    {
        public static string addType;
        public static string editType;
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
            yearlyMonthBills.Visible = false;

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
            decimal twelveMonthMonthly = decimal.Multiply(sumMonthly, 12);
            overallTotal.Text = decimal.Add(decimal.Add(sumYearly, twelveMonthMonthly), sumWanted).ToString("C", CultureInfo.CurrentCulture);

            yearlyTotalLabel.Text = sumYearly.ToString("C", CultureInfo.CurrentCulture);
            monthlyTotalLabel.Text = sumMonthly.ToString("C", CultureInfo.CurrentCulture);
            wantedTotalLabel.Text = sumWanted.ToString("C", CultureInfo.CurrentCulture);
            yearlyMonthBills.Text = twelveMonthMonthly.ToString("C", CultureInfo.CurrentCulture);

            yearlyTotalLabel.Visible = true;
            monthlyTotalLabel.Visible = true;
            wantedTotalLabel.Visible = true;
            overallTotal.Visible = true;
            yearlyMonthBills.Visible = true;
        }

        #region Buttons

        private void RemoveMonthlyRecord()
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    foreach (DataGridViewRow row in monthlyDataGridView.SelectedRows)
                    {
                        cmd.CommandText = String.Format("DELETE FROM Monthly WHERE Id=" + int.Parse(monthlyDataGridView[0, row.Index].Value.ToString()), con);
                        cmd.ExecuteNonQuery();
                    }
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
            try
            {
                SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    foreach (DataGridViewRow row in monthlyDataGridView.SelectedRows)
                    {
                        cmd.CommandText = String.Format("DELETE FROM Yearly WHERE Id=" + int.Parse(yearlyDataGridView[0, row.Index].Value.ToString()), con);
                        cmd.ExecuteNonQuery();
                    }
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
            try
            {
                SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    foreach (DataGridViewRow row in monthlyDataGridView.SelectedRows)
                    {
                        cmd.CommandText = String.Format("DELETE FROM Wanted WHERE Id=" + int.Parse(wantedDataGridView[0, row.Index].Value.ToString()), con);
                        cmd.ExecuteNonQuery();
                    }
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

        private void monthlyDataGridView_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                monthlyContextMenu.Items.Clear();
                monthlyContextMenu.Items.Add("Edit Selected");
                var ht = monthlyDataGridView.HitTest(e.X, e.Y);

                if (ht.Type != DataGridViewHitTestType.None)
                {
                    monthlyContextMenu.Show(monthlyDataGridView, new Point(e.X, e.Y));
                }
                
            }
        }

        private void monthlyContextMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (monthlyDataGridView.SelectedRows.Count == 1)
            {
                int selectedrowindex = monthlyDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = monthlyDataGridView.Rows[selectedrowindex];

                Variables.Id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Variables.Description = Convert.ToString(selectedRow.Cells[1].Value);
                Variables.CategoryIndex = Convert.ToInt32(selectedRow.Cells[2].Value) - 1;
                Variables.Amount = Convert.ToString(selectedRow.Cells[3].Value);

                editType = "Monthly";

                EditItem editItem = new EditItem(this);
                editItem.ShowDialog();
            }
        }

        private void monthlyDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (monthlyDataGridView.RowCount > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    monthlyDataGridView.CurrentCell = monthlyDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    monthlyDataGridView.Rows[e.RowIndex].Selected = true;
                    monthlyDataGridView.Focus();
                }
            }
        }

        private void wantedContextMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (wantedDataGridView.SelectedRows.Count == 1)
            {
                int selectedrowindex = wantedDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = wantedDataGridView.Rows[selectedrowindex];

                Variables.Id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Variables.Description = Convert.ToString(selectedRow.Cells[1].Value);
                Variables.CategoryIndex = Convert.ToInt32(selectedRow.Cells[2].Value) - 1;
                Variables.Amount = Convert.ToString(selectedRow.Cells[3].Value);

                editType = "Wanted";

                EditItem editItem = new EditItem(this);
                editItem.ShowDialog();
            }
        }

        private void wantedDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                wantedContextMenu.Items.Clear();
                wantedContextMenu.Items.Add("Edit Selected");
                var ht = wantedDataGridView.HitTest(e.X, e.Y);

                if (ht.Type != DataGridViewHitTestType.None)
                {
                    wantedContextMenu.Show(wantedDataGridView, new Point(e.X, e.Y));
                }

            }
        }

        private void wantedDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (wantedDataGridView.RowCount > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    wantedDataGridView.CurrentCell = wantedDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    wantedDataGridView.Rows[e.RowIndex].Selected = true;
                    wantedDataGridView.Focus();
                }
            }
        }

        private void yearlyContextMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (yearlyDataGridView.SelectedRows.Count == 1)
            {
                int selectedrowindex = yearlyDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = yearlyDataGridView.Rows[selectedrowindex];

                Variables.Id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Variables.Description = Convert.ToString(selectedRow.Cells[1].Value);
                Variables.CategoryIndex = Convert.ToInt32(selectedRow.Cells[2].Value) - 1;
                Variables.Amount = Convert.ToString(selectedRow.Cells[3].Value);

                editType = "Yearly";

                EditItem editItem = new EditItem(this);
                editItem.ShowDialog();
            }
        }

        private void yearlyDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                yearlyContextMenu.Items.Clear();
                yearlyContextMenu.Items.Add("Edit Selected");
                var ht = yearlyDataGridView.HitTest(e.X, e.Y);

                if (ht.Type != DataGridViewHitTestType.None)
                {
                    yearlyContextMenu.Show(yearlyDataGridView, new Point(e.X, e.Y));
                }

            }
        }

        private void yearlyDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (yearlyDataGridView.RowCount > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    yearlyDataGridView.CurrentCell = yearlyDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    yearlyDataGridView.Rows[e.RowIndex].Selected = true;
                    yearlyDataGridView.Focus();
                }
            }
        }
    }
}
