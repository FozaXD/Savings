using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Savings
{
    public partial class Assests : Form
    {
        public Assests()
        {
            InitializeComponent();
            DrawAssestsDataGridView();            
            SetLabels();
        }

        public void LoadSpentVSavedChart()
        {
            noValues2.Visible = false;
            foreach (var series in chart6.Series)
            {
                series.Points.Clear();
            }

            if (Figures.overallTotal > 0)
            {
                chart6.Series["Breakdown"].Points.AddXY("Spent", Figures.overallTotal);
                chart6.Series["Breakdown"].Points[0].Color = Color.Firebrick;
            }
            if (Figures.assestTotal > 0)
            {
                chart6.Series["Breakdown"].Points.AddXY("Saved", Figures.assestTotal);
                chart6.Series["Breakdown"].Points[1].Color = Color.YellowGreen;
            }
            if (chart6.Series["Breakdown"].Points.Count == 0)
            {
                noValues2.Visible = true;
            }
        }

        public void SetLabels()
        {
            avaliableFunds.Visible = false;
            assestsFig.Visible = false;
            spendingFunds.Visible = false;

            avaliableFunds.Text = (Figures.assestTotal - Figures.overallTotal).ToString("C", CultureInfo.CurrentCulture);
            assestsFig.Text = Figures.assestTotal.ToString("C", CultureInfo.CurrentCulture);
            spendingFunds.Text = Figures.overallTotal.ToString("C", CultureInfo.CurrentCulture);

            avaliableFunds.Visible = true;
            assestsFig.Visible = true;
            spendingFunds.Visible = true;
        }



        public void DrawAssestsDataGridView()
        {
            assestsDataGridView.Rows.Clear();
            try
            {
                SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
                con.Open();
                SQLiteCommand comm = new SQLiteCommand("Select * From Assests", con);
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        assestsDataGridView.Rows.Add(new object[] {
                    read.GetValue(0),  // U can use column index
                    read.GetValue(read.GetOrdinal("Description")),  // Or column name like this
                    read.GetValue(read.GetOrdinal("Category")),
                    read.GetValue(read.GetOrdinal("Amount"))
                    });
                    }
                }
                con.Close();
                //Set amount column to currency format
                assestsDataGridView.Columns["assestAmtColumn"].DefaultCellStyle.Format = "c";
                if (assestsDataGridView.Rows.Count != 0)
                {
                    removeAssestButton.Enabled = true;
                }
                else
                {
                    removeAssestButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadSpentVSavedChart();
        }

        private void addAssestButton_Click(object sender, EventArgs e)
        {
            // Set the add type
            string addType = "Assests";

            // Create a new instance of the AddItem class
            AddItem addItemForm = new AddItem(addType);

            // Show the AddItem form
            addItemForm.ShowDialog();
            DrawAssestsDataGridView();
        }

        private void assestsDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (assestsDataGridView.RowCount > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex != -1)
                    {
                        assestsDataGridView.CurrentCell = assestsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        assestsDataGridView.Rows[e.RowIndex].Selected = true;
                        assestsDataGridView.Focus();
                    }
                }
            }
        }

        private void assestsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                assestContextMenu.Items.Clear();
                assestContextMenu.Items.Add("Edit Selected");
                var ht = assestsDataGridView.HitTest(e.X, e.Y);

                if (ht.Type != DataGridViewHitTestType.None && ht.Type != DataGridViewHitTestType.ColumnHeader)
                {
                    assestContextMenu.Show(assestsDataGridView, new Point(e.X, e.Y));
                }
            }
        }

        private void assestContextMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (assestsDataGridView.SelectedRows.Count == 1)
            {
                int selectedrowindex = assestsDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = assestsDataGridView.Rows[selectedrowindex];

                Variables.Id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Variables.Description = Convert.ToString(selectedRow.Cells[1].Value);
                Variables.CategoryIndex = Convert.ToInt32(selectedRow.Cells[2].Value) - 1;
                Variables.Amount = Convert.ToString(selectedRow.Cells[3].Value);

                string editType = "Assests";

                EditItem editItem = new EditItem(editType);
                editItem.ShowDialog();
                DrawAssestsDataGridView();
            }
        }

        private void removeAssestButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to remove the selected assest?", "Assest?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                RemoveAssest();
            }
            DrawAssestsDataGridView();
        }

        private void RemoveAssest()
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
                con.Open();
                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    foreach (DataGridViewRow row in assestsDataGridView.SelectedRows)
                    {
                        cmd.CommandText = String.Format("DELETE FROM Assests WHERE Id=" + int.Parse(assestsDataGridView[0, row.Index].Value.ToString()), con);
                        cmd.ExecuteNonQuery();
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
