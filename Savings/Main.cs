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
            GetCategoryCounts();
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DrawYearlyDataGridView()
        {
            yearlyDataGridView.Rows.Clear();
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DrawWantedDataGridView()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        public void GetCategoryCounts()
        {

            cat3Bar.Size = new Size(0, cat3Bar.Height);
            cat4Bar.Size = new Size(0, cat3Bar.Height);
            cat2Bar.Size = new Size(0, cat3Bar.Height);
            cat1Bar.Size = new Size(0, cat3Bar.Height);

            decimal yearlyCat1 = yearlyDataGridView.Rows.Cast<DataGridViewRow>()
               .Count(row => row.Cells[2].Value.ToString() == "1");

            decimal yearlyCat2 = yearlyDataGridView.Rows.Cast<DataGridViewRow>()
              .Count(row => row.Cells[2].Value.ToString() == "2");

            decimal yearlyCat3 = yearlyDataGridView.Rows.Cast<DataGridViewRow>()
              .Count(row => row.Cells[2].Value.ToString() == "3");

            decimal yearlyCat4 = yearlyDataGridView.Rows.Cast<DataGridViewRow>()
              .Count(row => row.Cells[2].Value.ToString() == "4");

            decimal monthlyCat1 = monthlyDataGridView.Rows.Cast<DataGridViewRow>()
              .Count(row => row.Cells[2].Value.ToString() == "1");

            decimal monthlyCat2 = monthlyDataGridView.Rows.Cast<DataGridViewRow>()
              .Count(row => row.Cells[2].Value.ToString() == "2");

            decimal monthlyCat3 = monthlyDataGridView.Rows.Cast<DataGridViewRow>()
              .Count(row => row.Cells[2].Value.ToString() == "3");

            decimal monthlyCat4 = monthlyDataGridView.Rows.Cast<DataGridViewRow>()
              .Count(row => row.Cells[2].Value.ToString() == "4");

            decimal wantedCat1 = wantedDataGridView.Rows.Cast<DataGridViewRow>()
              .Count(row => row.Cells[2].Value.ToString() == "1");

            decimal wantedCat2 = wantedDataGridView.Rows.Cast<DataGridViewRow>()
              .Count(row => row.Cells[2].Value.ToString() == "2");

            decimal wantedCat3 = wantedDataGridView.Rows.Cast<DataGridViewRow>()
              .Count(row => row.Cells[2].Value.ToString() == "3");

            decimal wantedCat4 = wantedDataGridView.Rows.Cast<DataGridViewRow>()
              .Count(row => row.Cells[2].Value.ToString() == "4");

            decimal totalCat1 = yearlyCat1 + monthlyCat1 + wantedCat1;
            decimal totalCat2 = yearlyCat2 + monthlyCat2 + wantedCat2;
            decimal totalCat3 = yearlyCat3 + monthlyCat3 + wantedCat3;
            decimal totalCat4 = yearlyCat4 + monthlyCat4 + wantedCat4;
            decimal totalCats = totalCat1 + totalCat2 + totalCat3 + totalCat4;

            if (totalCats != 0)
            {
                decimal percentTotalCat1 = (totalCat1 / totalCats) * 100;
                decimal percentTotalCat2 = (totalCat2 / totalCats) * 100;
                decimal percentTotalCat3 = (totalCat3 / totalCats) * 100;
                decimal percentTotalCat4 = (totalCat4 / totalCats) * 100;

                cat1Bar.Size = new Size(Convert.ToInt32(percentTotalCat1) * 4, cat1Bar.Height);

                cat2Bar.Size = new Size(Convert.ToInt32(percentTotalCat2) * 4, cat2Bar.Height);
                cat2Bar.Location = new Point(cat1Bar.Left + cat1Bar.Size.Width, cat2Bar.Top);

                cat3Bar.Size = new Size(Convert.ToInt32(percentTotalCat3) * 4, cat3Bar.Height);
                cat3Bar.Location = new Point(cat2Bar.Left + cat2Bar.Size.Width, cat3Bar.Top);

                cat4Bar.Size = new Size(Convert.ToInt32(percentTotalCat4) * 4, cat4Bar.Height);
                cat4Bar.Location = new Point(cat3Bar.Left + cat3Bar.Size.Width, cat4Bar.Top);
            }
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
