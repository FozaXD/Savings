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
        #region Variables

        public static string addType;
        public static string editType;
        decimal twelveMonthMonthly = 0.00m;

        #endregion

        #region Functions

        public Main()
        {
            InitializeComponent();

            Startup1();

            Draw();
            DrawUserInfo();
        }

        public void Draw()
        {
            ClearTotals();
            ClearSelected();
            DrawYearlyDataGridView();
            DrawMonthlyDataGridView();
            DrawWantedDataGridView();
            GetTotals();
            SetCatTotals();
            GetCategoryCounts();
            GetBreakdownCounts();
        }

        public void ClearTotals()
        {
            Figures.overallTotal = 0.00m;

            Figures.totalYearly = 0.00m;
            Figures.totalMonthly = 0.00m;
            Figures.totalWanted = 0.00m;

            Figures.sumYearlyCat1 = 0.00m;
            Figures.sumYearlyCat2 = 0.00m;
            Figures.sumYearlyCat3 = 0.00m;
            Figures.sumYearlyCat4 = 0.00m;

            Figures.sumMonthlyCat1 = 0.00m;
            Figures.sumMonthlyCat2 = 0.00m;
            Figures.sumMonthlyCat3 = 0.00m;
            Figures.sumMonthlyCat4 = 0.00m;

            Figures.sumWantedCat1 = 0.00m;
            Figures.sumWantedCat2 = 0.00m;
            Figures.sumWantedCat3 = 0.00m;
            Figures.sumWantedCat4 = 0.00m;
        }

        public void ClearSelected()
        {
            yearlyDataGridView.ClearSelection();
            monthlyDataGridView.ClearSelection();
            wantedDataGridView.ClearSelection();
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
            yearlyTotalLabel.Visible = false;
            monthlyTotalLabel.Visible = false;
            wantedTotalLabel.Visible = false;
            overallTotal.Visible = false;
            yearlyMonthBills.Visible = false;

            for (int i = 0; i < yearlyDataGridView.Rows.Count; ++i)
            {
                Figures.totalYearly += Convert.ToDecimal(yearlyDataGridView.Rows[i].Cells[3].Value);
            }

            for (int e = 0; e < monthlyDataGridView.Rows.Count; ++e)
            {
                Figures.totalMonthly += Convert.ToDecimal(monthlyDataGridView.Rows[e].Cells[3].Value);
            }

            for (int f = 0; f < wantedDataGridView.Rows.Count; ++f)
            {
                Figures.totalWanted += Convert.ToDecimal(wantedDataGridView.Rows[f].Cells[3].Value);
            }

            SetTotalLabels();
        }

        public void SetTotalLabels()
        {
            twelveMonthMonthly = decimal.Multiply(Figures.totalMonthly, 12);

            Figures.overallTotal = decimal.Add(decimal.Add(Figures.totalYearly, twelveMonthMonthly), Figures.totalWanted);
            overallTotal.Text = Figures.overallTotal.ToString("C", CultureInfo.CurrentCulture);

            yearlyTotalLabel.Text = Figures.totalYearly.ToString("C", CultureInfo.CurrentCulture);
            monthlyTotalLabel.Text = Figures.totalMonthly.ToString("C", CultureInfo.CurrentCulture);
            wantedTotalLabel.Text = Figures.totalWanted.ToString("C", CultureInfo.CurrentCulture);
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
            cat4Bar.Size = new Size(0, cat4Bar.Height);
            cat2Bar.Size = new Size(0, cat2Bar.Height);
            cat1Bar.Size = new Size(0, cat1Bar.Height);

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

        public void GetBreakdownCounts()
        {
            yearlyBar.Size = new Size(0, yearlyBar.Height);
            monthlyBar.Size = new Size(0, monthlyBar.Height);
            wantedBar.Size = new Size(0, wantedBar.Height);

            decimal total = Figures.totalYearly + twelveMonthMonthly + Figures.totalWanted;

            if (total != 0)
            {
                decimal percentYearly = (Figures.totalYearly / total) * 100;
                decimal percentMonthly = (twelveMonthMonthly / total) * 100;
                decimal percentWanted = (Figures.totalWanted / total) * 100;


                yearlyBar.Size = new Size(Convert.ToInt32(percentYearly) * 4, yearlyBar.Height);

                monthlyBar.Size = new Size(Convert.ToInt32(percentMonthly) * 4, monthlyBar.Height);
                monthlyBar.Location = new Point(yearlyBar.Left + yearlyBar.Size.Width, monthlyBar.Top);

                wantedBar.Size = new Size(Convert.ToInt32(percentWanted) * 4, wantedBar.Height);
                wantedBar.Location = new Point(monthlyBar.Left + monthlyBar.Size.Width, wantedBar.Top);
            }
        }

        public void SetCatTotals()
        {
            for (int i = 0; i < yearlyDataGridView.Rows.Count; ++i)
            {
                if (yearlyDataGridView.Rows[i].Cells[2].Value.ToString().Equals("1"))
                {
                    Figures.sumYearlyCat1 += Convert.ToDecimal(yearlyDataGridView.Rows[i].Cells[3].Value);
                }
                else if (yearlyDataGridView.Rows[i].Cells[2].Value.ToString().Equals("2"))
                {
                    Figures.sumYearlyCat2 += Convert.ToDecimal(yearlyDataGridView.Rows[i].Cells[3].Value);
                }
                else if (yearlyDataGridView.Rows[i].Cells[2].Value.ToString().Equals("3"))
                {
                    Figures.sumYearlyCat3 += Convert.ToDecimal(yearlyDataGridView.Rows[i].Cells[3].Value);
                }
                else if (yearlyDataGridView.Rows[i].Cells[2].Value.ToString().Equals("4"))
                {
                    Figures.sumYearlyCat4 += Convert.ToDecimal(yearlyDataGridView.Rows[i].Cells[3].Value);
                }
            }

            for (int i = 0; i < monthlyDataGridView.Rows.Count; ++i)
            {
                if (monthlyDataGridView.Rows[i].Cells[2].Value.ToString().Equals("1"))
                {
                    Figures.sumMonthlyCat1 += Convert.ToDecimal(monthlyDataGridView.Rows[i].Cells[3].Value);
                }
                else if (monthlyDataGridView.Rows[i].Cells[2].Value.ToString().Equals("2"))
                {
                    Figures.sumMonthlyCat2 += Convert.ToDecimal(monthlyDataGridView.Rows[i].Cells[3].Value);
                }
                else if (monthlyDataGridView.Rows[i].Cells[2].Value.ToString().Equals("3"))
                {
                    Figures.sumMonthlyCat3 += Convert.ToDecimal(monthlyDataGridView.Rows[i].Cells[3].Value);
                }
                else if (monthlyDataGridView.Rows[i].Cells[2].Value.ToString().Equals("4"))
                {
                    Figures.sumMonthlyCat4 += Convert.ToDecimal(monthlyDataGridView.Rows[i].Cells[3].Value);
                }
            }

            for (int i = 0; i < wantedDataGridView.Rows.Count; ++i)
            {
                if (wantedDataGridView.Rows[i].Cells[2].Value.ToString().Equals("1"))
                {
                    Figures.sumWantedCat1 += Convert.ToDecimal(wantedDataGridView.Rows[i].Cells[3].Value);
                }
                else if (wantedDataGridView.Rows[i].Cells[2].Value.ToString().Equals("2"))
                {
                    Figures.sumWantedCat2 += Convert.ToDecimal(wantedDataGridView.Rows[i].Cells[3].Value);
                }
                else if (wantedDataGridView.Rows[i].Cells[2].Value.ToString().Equals("3"))
                {
                    Figures.sumWantedCat3 += Convert.ToDecimal(wantedDataGridView.Rows[i].Cells[3].Value);
                }
                else if (wantedDataGridView.Rows[i].Cells[2].Value.ToString().Equals("4"))
                {
                    Figures.sumWantedCat4 += Convert.ToDecimal(wantedDataGridView.Rows[i].Cells[3].Value);
                }
            }
        }

        #endregion

        #region Events

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
                    foreach (DataGridViewRow row in yearlyDataGridView.SelectedRows)
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
                    foreach (DataGridViewRow row in wantedDataGridView.SelectedRows)
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

        private void monthlyDataGridView_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                monthlyContextMenu.Items.Clear();
                monthlyContextMenu.Items.Add("Edit Selected");
                var ht = monthlyDataGridView.HitTest(e.X, e.Y);

                if (ht.Type != DataGridViewHitTestType.None && ht.Type != DataGridViewHitTestType.ColumnHeader)
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
                    if (e.RowIndex != -1)
                    {
                        monthlyDataGridView.CurrentCell = monthlyDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        monthlyDataGridView.Rows[e.RowIndex].Selected = true;
                        monthlyDataGridView.Focus();
                    }
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

                if (ht.Type != DataGridViewHitTestType.None && ht.Type != DataGridViewHitTestType.ColumnHeader)
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
                    if (e.RowIndex != -1)
                    {
                        wantedDataGridView.CurrentCell = wantedDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        wantedDataGridView.Rows[e.RowIndex].Selected = true;
                        wantedDataGridView.Focus();
                    }
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

                if (ht.Type != DataGridViewHitTestType.None && ht.Type != DataGridViewHitTestType.ColumnHeader)
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
                    if (e.RowIndex != -1)
                    {
                        yearlyDataGridView.CurrentCell = yearlyDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        yearlyDataGridView.Rows[e.RowIndex].Selected = true;
                        yearlyDataGridView.Focus();
                    }
                }
            }
        }

        private void yearlyDataGridView_Leave_1(object sender, EventArgs e)
        {
            if (monthlyDataGridView.Focused == true || wantedDataGridView.Focused == true)
            {
                yearlyDataGridView.ClearSelection();
            }
        }

        private void monthlyDataGridView_Leave_1(object sender, EventArgs e)
        {
            if (yearlyDataGridView.Focused == true || wantedDataGridView.Focused == true)
            {
                monthlyDataGridView.ClearSelection();
            }
        }

        private void wantedDataGridView_Leave_1(object sender, EventArgs e)
        {
            if (monthlyDataGridView.Focused == true || yearlyDataGridView.Focused == true)
            {
                wantedDataGridView.ClearSelection();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ClearSelected();
        }

        private void breakdownButton_Click(object sender, EventArgs e)
        {
            Breakdown breakdown = new Breakdown();
            var dialogResult = breakdown.ShowDialog();
        }

        #endregion
    }
}
