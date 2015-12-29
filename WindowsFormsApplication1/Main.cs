using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Buttons
        private void addWantedButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the AddItem class
            AddItem addItemForm = new AddItem();

            // Show the AddItem form
            addItemForm.Show();
        }

        private void addMonthlyButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the AddItem class
            AddItem addItemForm = new AddItem();

            // Show the AddItem form
            addItemForm.Show();
        }

        private void addYearlyButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the AddItem class
            AddItem addItemForm = new AddItem();

            // Show the AddItem form
            addItemForm.Show();
        }
        #endregion
    }
}
