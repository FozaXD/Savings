namespace WindowsFormsApplication1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthlyDataGridView = new System.Windows.Forms.DataGridView();
            this.monthlyIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyCatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyAmtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addYearlyButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addMonthlyButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addWantedButton = new System.Windows.Forms.Button();
            this.removeMonthlyButton = new System.Windows.Forms.Button();
            this.removeWantedButton = new System.Windows.Forms.Button();
            this.removeYearlyButton = new System.Windows.Forms.Button();
            this.yearlyDataGridView = new System.Windows.Forms.DataGridView();
            this.wantedDataGridView = new System.Windows.Forms.DataGridView();
            this.wantedIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wantedDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wantedCatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wantedAmtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlyAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlyCatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlyDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlyIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearlyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wantedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totals";
            // 
            // monthlyDataGridView
            // 
            this.monthlyDataGridView.AllowUserToOrderColumns = true;
            this.monthlyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthlyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monthlyIdColumn,
            this.monthlyDescriptionColumn,
            this.monthlyCatColumn,
            this.monthlyAmtColumn});
            this.monthlyDataGridView.Location = new System.Drawing.Point(6, 24);
            this.monthlyDataGridView.MultiSelect = false;
            this.monthlyDataGridView.Name = "monthlyDataGridView";
            this.monthlyDataGridView.RowHeadersVisible = false;
            this.monthlyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.monthlyDataGridView.Size = new System.Drawing.Size(268, 220);
            this.monthlyDataGridView.TabIndex = 0;
            // 
            // monthlyIdColumn
            // 
            this.monthlyIdColumn.HeaderText = "Id";
            this.monthlyIdColumn.Name = "monthlyIdColumn";
            this.monthlyIdColumn.Width = 20;
            // 
            // monthlyDescriptionColumn
            // 
            this.monthlyDescriptionColumn.HeaderText = "Description";
            this.monthlyDescriptionColumn.Name = "monthlyDescriptionColumn";
            this.monthlyDescriptionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.monthlyDescriptionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // monthlyCatColumn
            // 
            this.monthlyCatColumn.HeaderText = "Cat*";
            this.monthlyCatColumn.Name = "monthlyCatColumn";
            this.monthlyCatColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.monthlyCatColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.monthlyCatColumn.Width = 35;
            // 
            // monthlyAmtColumn
            // 
            this.monthlyAmtColumn.HeaderText = "Amount";
            this.monthlyAmtColumn.Name = "monthlyAmtColumn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yearlyDataGridView);
            this.groupBox2.Controls.Add(this.removeYearlyButton);
            this.groupBox2.Controls.Add(this.addYearlyButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yearly:";
            // 
            // addYearlyButton
            // 
            this.addYearlyButton.Image = ((System.Drawing.Image)(resources.GetObject("addYearlyButton.Image")));
            this.addYearlyButton.Location = new System.Drawing.Point(204, 250);
            this.addYearlyButton.Name = "addYearlyButton";
            this.addYearlyButton.Size = new System.Drawing.Size(32, 32);
            this.addYearlyButton.TabIndex = 5;
            this.addYearlyButton.UseVisualStyleBackColor = true;
            this.addYearlyButton.Click += new System.EventHandler(this.addYearlyButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.removeMonthlyButton);
            this.groupBox3.Controls.Add(this.monthlyDataGridView);
            this.groupBox3.Controls.Add(this.addMonthlyButton);
            this.groupBox3.Location = new System.Drawing.Point(299, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 288);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monthly:";
            // 
            // addMonthlyButton
            // 
            this.addMonthlyButton.Image = ((System.Drawing.Image)(resources.GetObject("addMonthlyButton.Image")));
            this.addMonthlyButton.Location = new System.Drawing.Point(204, 250);
            this.addMonthlyButton.Name = "addMonthlyButton";
            this.addMonthlyButton.Size = new System.Drawing.Size(32, 32);
            this.addMonthlyButton.TabIndex = 4;
            this.addMonthlyButton.UseVisualStyleBackColor = true;
            this.addMonthlyButton.Click += new System.EventHandler(this.addMonthlyButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.wantedDataGridView);
            this.groupBox4.Controls.Add(this.removeWantedButton);
            this.groupBox4.Controls.Add(this.addWantedButton);
            this.groupBox4.Location = new System.Drawing.Point(585, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 288);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wanted:";
            // 
            // addWantedButton
            // 
            this.addWantedButton.Image = ((System.Drawing.Image)(resources.GetObject("addWantedButton.Image")));
            this.addWantedButton.Location = new System.Drawing.Point(210, 250);
            this.addWantedButton.Name = "addWantedButton";
            this.addWantedButton.Size = new System.Drawing.Size(32, 32);
            this.addWantedButton.TabIndex = 3;
            this.addWantedButton.UseVisualStyleBackColor = true;
            this.addWantedButton.Click += new System.EventHandler(this.addWantedButton_Click);
            // 
            // removeMonthlyButton
            // 
            this.removeMonthlyButton.Image = ((System.Drawing.Image)(resources.GetObject("removeMonthlyButton.Image")));
            this.removeMonthlyButton.Location = new System.Drawing.Point(242, 250);
            this.removeMonthlyButton.Name = "removeMonthlyButton";
            this.removeMonthlyButton.Size = new System.Drawing.Size(32, 32);
            this.removeMonthlyButton.TabIndex = 5;
            this.removeMonthlyButton.UseVisualStyleBackColor = true;
            this.removeMonthlyButton.Click += new System.EventHandler(this.removeMonthlyButton_Click);
            // 
            // removeWantedButton
            // 
            this.removeWantedButton.Image = ((System.Drawing.Image)(resources.GetObject("removeWantedButton.Image")));
            this.removeWantedButton.Location = new System.Drawing.Point(248, 250);
            this.removeWantedButton.Name = "removeWantedButton";
            this.removeWantedButton.Size = new System.Drawing.Size(32, 32);
            this.removeWantedButton.TabIndex = 6;
            this.removeWantedButton.UseVisualStyleBackColor = true;
            this.removeWantedButton.Click += new System.EventHandler(this.removeWantedButton_Click);
            // 
            // removeYearlyButton
            // 
            this.removeYearlyButton.Image = ((System.Drawing.Image)(resources.GetObject("removeYearlyButton.Image")));
            this.removeYearlyButton.Location = new System.Drawing.Point(242, 250);
            this.removeYearlyButton.Name = "removeYearlyButton";
            this.removeYearlyButton.Size = new System.Drawing.Size(32, 32);
            this.removeYearlyButton.TabIndex = 9;
            this.removeYearlyButton.UseVisualStyleBackColor = true;
            this.removeYearlyButton.Click += new System.EventHandler(this.removeYearlyButton_Click);
            // 
            // yearlyDataGridView
            // 
            this.yearlyDataGridView.AllowUserToOrderColumns = true;
            this.yearlyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yearlyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearlyIdColumn,
            this.yearlyDescriptionColumn,
            this.yearlyCatColumn,
            this.yearlyAmountColumn});
            this.yearlyDataGridView.Location = new System.Drawing.Point(6, 24);
            this.yearlyDataGridView.MultiSelect = false;
            this.yearlyDataGridView.Name = "yearlyDataGridView";
            this.yearlyDataGridView.RowHeadersVisible = false;
            this.yearlyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.yearlyDataGridView.Size = new System.Drawing.Size(268, 220);
            this.yearlyDataGridView.TabIndex = 6;
            // 
            // wantedDataGridView
            // 
            this.wantedDataGridView.AllowUserToOrderColumns = true;
            this.wantedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wantedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wantedIdColumn,
            this.wantedDescriptionColumn,
            this.wantedCatColumn,
            this.wantedAmtColumn});
            this.wantedDataGridView.Location = new System.Drawing.Point(6, 24);
            this.wantedDataGridView.MultiSelect = false;
            this.wantedDataGridView.Name = "wantedDataGridView";
            this.wantedDataGridView.RowHeadersVisible = false;
            this.wantedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wantedDataGridView.Size = new System.Drawing.Size(274, 220);
            this.wantedDataGridView.TabIndex = 6;
            // 
            // wantedIdColumn
            // 
            this.wantedIdColumn.HeaderText = "Id";
            this.wantedIdColumn.Name = "wantedIdColumn";
            this.wantedIdColumn.Width = 20;
            // 
            // wantedDescriptionColumn
            // 
            this.wantedDescriptionColumn.HeaderText = "Description";
            this.wantedDescriptionColumn.Name = "wantedDescriptionColumn";
            this.wantedDescriptionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wantedDescriptionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // wantedCatColumn
            // 
            this.wantedCatColumn.HeaderText = "Cat*";
            this.wantedCatColumn.Name = "wantedCatColumn";
            this.wantedCatColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wantedCatColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wantedCatColumn.Width = 35;
            // 
            // wantedAmtColumn
            // 
            this.wantedAmtColumn.HeaderText = "Amount";
            this.wantedAmtColumn.Name = "wantedAmtColumn";
            // 
            // yearlyAmountColumn
            // 
            this.yearlyAmountColumn.HeaderText = "Amount";
            this.yearlyAmountColumn.Name = "yearlyAmountColumn";
            // 
            // yearlyCatColumn
            // 
            this.yearlyCatColumn.HeaderText = "Cat*";
            this.yearlyCatColumn.Name = "yearlyCatColumn";
            this.yearlyCatColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.yearlyCatColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.yearlyCatColumn.Width = 35;
            // 
            // yearlyDescriptionColumn
            // 
            this.yearlyDescriptionColumn.HeaderText = "Description";
            this.yearlyDescriptionColumn.Name = "yearlyDescriptionColumn";
            this.yearlyDescriptionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.yearlyDescriptionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // yearlyIdColumn
            // 
            this.yearlyIdColumn.HeaderText = "Id";
            this.yearlyIdColumn.Name = "yearlyIdColumn";
            this.yearlyIdColumn.Width = 20;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Opacity = 0.98D;
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Savings";
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yearlyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wantedDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button addWantedButton;
        private System.Windows.Forms.Button addYearlyButton;
        private System.Windows.Forms.Button addMonthlyButton;
        private System.Windows.Forms.DataGridView monthlyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyCatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyAmtColumn;
        private System.Windows.Forms.Button removeYearlyButton;
        private System.Windows.Forms.Button removeMonthlyButton;
        private System.Windows.Forms.Button removeWantedButton;
        private System.Windows.Forms.DataGridView yearlyDataGridView;
        private System.Windows.Forms.DataGridView wantedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn wantedIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wantedDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wantedCatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wantedAmtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlyIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlyDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlyCatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlyAmountColumn;
    }
}

