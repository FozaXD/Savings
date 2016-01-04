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
    public partial class AddItem : Form
    {
        int cat;
        private Main mainForm;

        public AddItem(Main form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex >= 0)
            {
                switch (Main.addType)
                {
                    case "Monthly":
                        try
                        {
                            using (SQLiteConnection con = new SQLiteConnection(Main.connectionString))
                            {
                                SQLiteCommand cmd = new SQLiteCommand();
                                cmd.CommandText = @"INSERT INTO Monthly (Active, Description, Category, Amount) VALUES (@active,@description,@category,@amount) ";
                                cmd.Connection = con;
                                cmd.Parameters.Add(new SQLiteParameter("@active", 1));
                                cmd.Parameters.Add(new SQLiteParameter("@description", descriptionTextBox.Text));
                                cmd.Parameters.Add(new SQLiteParameter("@category", cat));
                                cmd.Parameters.Add(new SQLiteParameter("@amount", amountTextBox.Text));

                                con.Open();

                                int i = cmd.ExecuteNonQuery();

                                if (i != 1)
                                {
                                    MessageBox.Show("The database isn't being friendly at the moment. He doesn't want to talk to me.");
                                }
                                mainForm.DrawMonthlyDataGridView();
                                Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;

                    case "Yearly":
                        try
                        {
                            using (SQLiteConnection con = new SQLiteConnection(Main.connectionString))
                            {
                                SQLiteCommand cmd = new SQLiteCommand();
                                cmd.CommandText = @"INSERT INTO Yearly (Active, Description, Category, Amount) VALUES (@active,@description,@category,@amount) ";
                                cmd.Connection = con;
                                cmd.Parameters.Add(new SQLiteParameter("@active", 1));
                                cmd.Parameters.Add(new SQLiteParameter("@description", descriptionTextBox.Text));
                                cmd.Parameters.Add(new SQLiteParameter("@category", cat));
                                cmd.Parameters.Add(new SQLiteParameter("@amount", amountTextBox.Text));

                                con.Open();

                                int i = cmd.ExecuteNonQuery();

                                if (i != 1)
                                {
                                    MessageBox.Show("The database isn't being friendly at the moment. He doesn't want to talk to me.");
                                }
                                mainForm.DrawYearlyDataGridView();
                                Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;

                    case "Wanted":
                        try
                        {
                            using (SQLiteConnection con = new SQLiteConnection(Main.connectionString))
                            {
                                SQLiteCommand cmd = new SQLiteCommand();
                                cmd.CommandText = @"INSERT INTO Wanted (Active, Description, Category, Amount) VALUES (@active,@description,@category,@amount) ";
                                cmd.Connection = con;
                                cmd.Parameters.Add(new SQLiteParameter("@active", 1));
                                cmd.Parameters.Add(new SQLiteParameter("@description", descriptionTextBox.Text));
                                cmd.Parameters.Add(new SQLiteParameter("@category", cat));
                                cmd.Parameters.Add(new SQLiteParameter("@amount", amountTextBox.Text));

                                con.Open();

                                int i = cmd.ExecuteNonQuery();

                                if (i != 1)
                                {
                                    MessageBox.Show("The database isn't being friendly at the moment. He doesn't want to talk to me.");
                                }
                                mainForm.DrawWantedDataGridView();
                                Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;

                    default:
                        MessageBox.Show("Stop trying to confuse me! You have to tell me where you want me to add to.");
                        break;
                }
            }

            else
            {
                MessageBox.Show("Please select a valid category.", "Invalid Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (categoryComboBox.SelectedText)
            {
                case "1 - Critical":
                    cat = 1;
                    break;

                case "2 - Future":
                    cat = 2;
                    break;

                case "3 - Non - Essential":
                    cat = 3;
                    break;

                case "4 - Luxury":
                    cat = 4;
                    break;

                default:
                    cat = 1;
                    break;
            }

        }
    }
}
