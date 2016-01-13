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
            this.overallTotal = new System.Windows.Forms.Label();
            this.overallTotalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.wantedTotalLabel = new System.Windows.Forms.Label();
            this.totWantedLabel = new System.Windows.Forms.Label();
            this.monthlyTotalLabel = new System.Windows.Forms.Label();
            this.yearlyTotalLabel = new System.Windows.Forms.Label();
            this.totMonthlyBillsLabel = new System.Windows.Forms.Label();
            this.totYearlyBillLabel = new System.Windows.Forms.Label();
            this.monthlyDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yearlyDataGridView = new System.Windows.Forms.DataGridView();
            this.removeYearlyButton = new System.Windows.Forms.Button();
            this.addYearlyButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.removeMonthlyButton = new System.Windows.Forms.Button();
            this.addMonthlyButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.wantedDataGridView = new System.Windows.Forms.DataGridView();
            this.removeWantedButton = new System.Windows.Forms.Button();
            this.addWantedButton = new System.Windows.Forms.Button();
            this.yearlyIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlyDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlyCatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlyAmtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyCatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyAmtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wantedIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wantedDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wantedCatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wantedAmtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearlyDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wantedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.overallTotal);
            this.groupBox1.Controls.Add(this.overallTotalLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.accountNameLabel);
            this.groupBox1.Controls.Add(this.wantedTotalLabel);
            this.groupBox1.Controls.Add(this.totWantedLabel);
            this.groupBox1.Controls.Add(this.monthlyTotalLabel);
            this.groupBox1.Controls.Add(this.yearlyTotalLabel);
            this.groupBox1.Controls.Add(this.totMonthlyBillsLabel);
            this.groupBox1.Controls.Add(this.totYearlyBillLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totals";
            // 
            // overallTotal
            // 
            this.overallTotal.AutoSize = true;
            this.overallTotal.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallTotal.Location = new System.Drawing.Point(152, 21);
            this.overallTotal.Name = "overallTotal";
            this.overallTotal.Size = new System.Drawing.Size(112, 25);
            this.overallTotal.TabIndex = 9;
            this.overallTotal.Text = "overallTotal";
            // 
            // overallTotalLabel
            // 
            this.overallTotalLabel.AutoSize = true;
            this.overallTotalLabel.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overallTotalLabel.Location = new System.Drawing.Point(6, 21);
            this.overallTotalLabel.Name = "overallTotalLabel";
            this.overallTotalLabel.Size = new System.Drawing.Size(140, 25);
            this.overallTotalLabel.TabIndex = 8;
            this.overallTotalLabel.Text = "Overall Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(651, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Account:";
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameLabel.Location = new System.Drawing.Point(738, -2);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(106, 21);
            this.accountNameLabel.TabIndex = 6;
            this.accountNameLabel.Text = "accountname";
            // 
            // wantedTotalLabel
            // 
            this.wantedTotalLabel.AutoSize = true;
            this.wantedTotalLabel.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wantedTotalLabel.Location = new System.Drawing.Point(701, 110);
            this.wantedTotalLabel.Name = "wantedTotalLabel";
            this.wantedTotalLabel.Size = new System.Drawing.Size(78, 18);
            this.wantedTotalLabel.TabIndex = 5;
            this.wantedTotalLabel.Text = "wantedTotal";
            this.wantedTotalLabel.Visible = false;
            // 
            // totWantedLabel
            // 
            this.totWantedLabel.AutoSize = true;
            this.totWantedLabel.Location = new System.Drawing.Point(575, 110);
            this.totWantedLabel.Name = "totWantedLabel";
            this.totWantedLabel.Size = new System.Drawing.Size(120, 18);
            this.totWantedLabel.TabIndex = 4;
            this.totWantedLabel.Text = "Total of Wanted:";
            // 
            // monthlyTotalLabel
            // 
            this.monthlyTotalLabel.AutoSize = true;
            this.monthlyTotalLabel.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyTotalLabel.Location = new System.Drawing.Point(435, 110);
            this.monthlyTotalLabel.Name = "monthlyTotalLabel";
            this.monthlyTotalLabel.Size = new System.Drawing.Size(83, 18);
            this.monthlyTotalLabel.TabIndex = 3;
            this.monthlyTotalLabel.Text = "monthlyTotal";
            this.monthlyTotalLabel.Visible = false;
            // 
            // yearlyTotalLabel
            // 
            this.yearlyTotalLabel.AutoSize = true;
            this.yearlyTotalLabel.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyTotalLabel.Location = new System.Drawing.Point(142, 110);
            this.yearlyTotalLabel.Name = "yearlyTotalLabel";
            this.yearlyTotalLabel.Size = new System.Drawing.Size(72, 18);
            this.yearlyTotalLabel.TabIndex = 2;
            this.yearlyTotalLabel.Text = "yearlyTotal";
            this.yearlyTotalLabel.Visible = false;
            // 
            // totMonthlyBillsLabel
            // 
            this.totMonthlyBillsLabel.AutoSize = true;
            this.totMonthlyBillsLabel.Location = new System.Drawing.Point(289, 110);
            this.totMonthlyBillsLabel.Name = "totMonthlyBillsLabel";
            this.totMonthlyBillsLabel.Size = new System.Drawing.Size(140, 18);
            this.totMonthlyBillsLabel.TabIndex = 1;
            this.totMonthlyBillsLabel.Text = "Total Monthly Bills:";
            // 
            // totYearlyBillLabel
            // 
            this.totYearlyBillLabel.AutoSize = true;
            this.totYearlyBillLabel.Location = new System.Drawing.Point(6, 110);
            this.totYearlyBillLabel.Name = "totYearlyBillLabel";
            this.totYearlyBillLabel.Size = new System.Drawing.Size(130, 18);
            this.totYearlyBillLabel.TabIndex = 0;
            this.totYearlyBillLabel.Text = "Total Yearly Bills:";
            // 
            // monthlyDataGridView
            // 
            this.monthlyDataGridView.AllowUserToAddRows = false;
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
            // yearlyDataGridView
            // 
            this.yearlyDataGridView.AllowUserToAddRows = false;
            this.yearlyDataGridView.AllowUserToOrderColumns = true;
            this.yearlyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yearlyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearlyIdColumn,
            this.yearlyDescriptionColumn,
            this.yearlyCatColumn,
            this.yearlyAmtColumn});
            this.yearlyDataGridView.Location = new System.Drawing.Point(6, 24);
            this.yearlyDataGridView.MultiSelect = false;
            this.yearlyDataGridView.Name = "yearlyDataGridView";
            this.yearlyDataGridView.RowHeadersVisible = false;
            this.yearlyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.yearlyDataGridView.Size = new System.Drawing.Size(268, 220);
            this.yearlyDataGridView.TabIndex = 6;
            // 
            // removeYearlyButton
            // 
            this.removeYearlyButton.Enabled = false;
            this.removeYearlyButton.Image = ((System.Drawing.Image)(resources.GetObject("removeYearlyButton.Image")));
            this.removeYearlyButton.Location = new System.Drawing.Point(242, 250);
            this.removeYearlyButton.Name = "removeYearlyButton";
            this.removeYearlyButton.Size = new System.Drawing.Size(32, 32);
            this.removeYearlyButton.TabIndex = 9;
            this.removeYearlyButton.UseVisualStyleBackColor = true;
            this.removeYearlyButton.Click += new System.EventHandler(this.removeYearlyButton_Click);
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
            // removeMonthlyButton
            // 
            this.removeMonthlyButton.Enabled = false;
            this.removeMonthlyButton.Image = ((System.Drawing.Image)(resources.GetObject("removeMonthlyButton.Image")));
            this.removeMonthlyButton.Location = new System.Drawing.Point(242, 250);
            this.removeMonthlyButton.Name = "removeMonthlyButton";
            this.removeMonthlyButton.Size = new System.Drawing.Size(32, 32);
            this.removeMonthlyButton.TabIndex = 5;
            this.removeMonthlyButton.UseVisualStyleBackColor = true;
            this.removeMonthlyButton.Click += new System.EventHandler(this.removeMonthlyButton_Click);
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
            // wantedDataGridView
            // 
            this.wantedDataGridView.AllowUserToAddRows = false;
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
            // removeWantedButton
            // 
            this.removeWantedButton.Enabled = false;
            this.removeWantedButton.Image = ((System.Drawing.Image)(resources.GetObject("removeWantedButton.Image")));
            this.removeWantedButton.Location = new System.Drawing.Point(248, 250);
            this.removeWantedButton.Name = "removeWantedButton";
            this.removeWantedButton.Size = new System.Drawing.Size(32, 32);
            this.removeWantedButton.TabIndex = 6;
            this.removeWantedButton.UseVisualStyleBackColor = true;
            this.removeWantedButton.Click += new System.EventHandler(this.removeWantedButton_Click);
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
            // yearlyIdColumn
            // 
            this.yearlyIdColumn.HeaderText = "Id";
            this.yearlyIdColumn.Name = "yearlyIdColumn";
            this.yearlyIdColumn.Width = 25;
            // 
            // yearlyDescriptionColumn
            // 
            this.yearlyDescriptionColumn.HeaderText = "Description";
            this.yearlyDescriptionColumn.Name = "yearlyDescriptionColumn";
            this.yearlyDescriptionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.yearlyDescriptionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // yearlyCatColumn
            // 
            this.yearlyCatColumn.HeaderText = "Cat*";
            this.yearlyCatColumn.Name = "yearlyCatColumn";
            this.yearlyCatColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.yearlyCatColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.yearlyCatColumn.Width = 40;
            // 
            // yearlyAmtColumn
            // 
            this.yearlyAmtColumn.HeaderText = "Amount";
            this.yearlyAmtColumn.Name = "yearlyAmtColumn";
            // 
            // monthlyIdColumn
            // 
            this.monthlyIdColumn.HeaderText = "Id";
            this.monthlyIdColumn.Name = "monthlyIdColumn";
            this.monthlyIdColumn.Width = 25;
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
            this.monthlyCatColumn.Width = 40;
            // 
            // monthlyAmtColumn
            // 
            this.monthlyAmtColumn.HeaderText = "Amount";
            this.monthlyAmtColumn.Name = "monthlyAmtColumn";
            // 
            // wantedIdColumn
            // 
            this.wantedIdColumn.HeaderText = "Id";
            this.wantedIdColumn.Name = "wantedIdColumn";
            this.wantedIdColumn.Width = 25;
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
            this.wantedCatColumn.Width = 40;
            // 
            // wantedAmtColumn
            // 
            this.wantedAmtColumn.HeaderText = "Amount";
            this.wantedAmtColumn.Name = "wantedAmtColumn";
            this.wantedAmtColumn.Width = 106;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yearlyDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Button removeYearlyButton;
        private System.Windows.Forms.Button removeMonthlyButton;
        private System.Windows.Forms.Button removeWantedButton;
        private System.Windows.Forms.DataGridView yearlyDataGridView;
        private System.Windows.Forms.DataGridView wantedDataGridView;
        private System.Windows.Forms.Label wantedTotalLabel;
        private System.Windows.Forms.Label totWantedLabel;
        private System.Windows.Forms.Label monthlyTotalLabel;
        private System.Windows.Forms.Label yearlyTotalLabel;
        private System.Windows.Forms.Label totMonthlyBillsLabel;
        private System.Windows.Forms.Label totYearlyBillLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label overallTotal;
        private System.Windows.Forms.Label overallTotalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyCatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyAmtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlyIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlyDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlyCatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearlyAmtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wantedIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wantedDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wantedCatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wantedAmtColumn;
    }
}

