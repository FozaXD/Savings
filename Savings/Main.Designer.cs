namespace Savings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yearlyMonthBills = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.monthlyIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyCatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyAmtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yearlyDataGridView = new System.Windows.Forms.DataGridView();
            this.yearlyIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlyDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlyCatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearlyAmtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeYearlyButton = new System.Windows.Forms.Button();
            this.addYearlyButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.removeMonthlyButton = new System.Windows.Forms.Button();
            this.addMonthlyButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.wantedDataGridView = new System.Windows.Forms.DataGridView();
            this.wantedIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wantedDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wantedCatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wantedAmtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeWantedButton = new System.Windows.Forms.Button();
            this.addWantedButton = new System.Windows.Forms.Button();
            this.monthlyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wantedContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yearlyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cat4Bar = new System.Windows.Forms.Panel();
            this.cat1Bar = new System.Windows.Forms.Panel();
            this.cat3Bar = new System.Windows.Forms.Panel();
            this.cat2Bar = new System.Windows.Forms.Panel();
            this.catBarChartLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearlyDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wantedDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.groupBox1.Controls.Add(this.catBarChartLabel);
            this.groupBox1.Controls.Add(this.cat4Bar);
            this.groupBox1.Controls.Add(this.cat3Bar);
            this.groupBox1.Controls.Add(this.cat2Bar);
            this.groupBox1.Controls.Add(this.cat1Bar);
            this.groupBox1.Controls.Add(this.yearlyMonthBills);
            this.groupBox1.Controls.Add(this.label2);
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
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totals";
            // 
            // yearlyMonthBills
            // 
            this.yearlyMonthBills.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yearlyMonthBills.AutoSize = true;
            this.yearlyMonthBills.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyMonthBills.ForeColor = System.Drawing.Color.White;
            this.yearlyMonthBills.Location = new System.Drawing.Point(458, 80);
            this.yearlyMonthBills.Name = "yearlyMonthBills";
            this.yearlyMonthBills.Size = new System.Drawing.Size(118, 18);
            this.yearlyMonthBills.TabIndex = 11;
            this.yearlyMonthBills.Text = "yearlyMonthlyTotal";
            this.yearlyMonthBills.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(315, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Yearly Month Bills:";
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(628, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Account:";
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameLabel.Location = new System.Drawing.Point(715, -2);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(106, 21);
            this.accountNameLabel.TabIndex = 6;
            this.accountNameLabel.Text = "accountname";
            // 
            // wantedTotalLabel
            // 
            this.wantedTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wantedTotalLabel.AutoSize = true;
            this.wantedTotalLabel.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wantedTotalLabel.ForeColor = System.Drawing.Color.White;
            this.wantedTotalLabel.Location = new System.Drawing.Point(771, 110);
            this.wantedTotalLabel.Name = "wantedTotalLabel";
            this.wantedTotalLabel.Size = new System.Drawing.Size(78, 18);
            this.wantedTotalLabel.TabIndex = 5;
            this.wantedTotalLabel.Text = "wantedTotal";
            this.wantedTotalLabel.Visible = false;
            // 
            // totWantedLabel
            // 
            this.totWantedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totWantedLabel.AutoSize = true;
            this.totWantedLabel.ForeColor = System.Drawing.Color.White;
            this.totWantedLabel.Location = new System.Drawing.Point(645, 110);
            this.totWantedLabel.Name = "totWantedLabel";
            this.totWantedLabel.Size = new System.Drawing.Size(120, 18);
            this.totWantedLabel.TabIndex = 4;
            this.totWantedLabel.Text = "Total of Wanted:";
            // 
            // monthlyTotalLabel
            // 
            this.monthlyTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthlyTotalLabel.AutoSize = true;
            this.monthlyTotalLabel.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyTotalLabel.ForeColor = System.Drawing.Color.White;
            this.monthlyTotalLabel.Location = new System.Drawing.Point(458, 110);
            this.monthlyTotalLabel.Name = "monthlyTotalLabel";
            this.monthlyTotalLabel.Size = new System.Drawing.Size(83, 18);
            this.monthlyTotalLabel.TabIndex = 3;
            this.monthlyTotalLabel.Text = "monthlyTotal";
            this.monthlyTotalLabel.Visible = false;
            // 
            // yearlyTotalLabel
            // 
            this.yearlyTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yearlyTotalLabel.AutoSize = true;
            this.yearlyTotalLabel.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyTotalLabel.ForeColor = System.Drawing.Color.White;
            this.yearlyTotalLabel.Location = new System.Drawing.Point(142, 110);
            this.yearlyTotalLabel.Name = "yearlyTotalLabel";
            this.yearlyTotalLabel.Size = new System.Drawing.Size(72, 18);
            this.yearlyTotalLabel.TabIndex = 2;
            this.yearlyTotalLabel.Text = "yearlyTotal";
            this.yearlyTotalLabel.Visible = false;
            // 
            // totMonthlyBillsLabel
            // 
            this.totMonthlyBillsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totMonthlyBillsLabel.AutoSize = true;
            this.totMonthlyBillsLabel.ForeColor = System.Drawing.Color.White;
            this.totMonthlyBillsLabel.Location = new System.Drawing.Point(312, 110);
            this.totMonthlyBillsLabel.Name = "totMonthlyBillsLabel";
            this.totMonthlyBillsLabel.Size = new System.Drawing.Size(140, 18);
            this.totMonthlyBillsLabel.TabIndex = 1;
            this.totMonthlyBillsLabel.Text = "Total Monthly Bills:";
            // 
            // totYearlyBillLabel
            // 
            this.totYearlyBillLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totYearlyBillLabel.AutoSize = true;
            this.totYearlyBillLabel.ForeColor = System.Drawing.Color.White;
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
            this.monthlyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthlyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.monthlyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.monthlyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.monthlyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.monthlyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthlyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monthlyIdColumn,
            this.monthlyDescriptionColumn,
            this.monthlyCatColumn,
            this.monthlyAmtColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.monthlyDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.monthlyDataGridView.EnableHeadersVisualStyles = false;
            this.monthlyDataGridView.Location = new System.Drawing.Point(6, 24);
            this.monthlyDataGridView.Name = "monthlyDataGridView";
            this.monthlyDataGridView.ReadOnly = true;
            this.monthlyDataGridView.RowHeadersVisible = false;
            this.monthlyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.monthlyDataGridView.Size = new System.Drawing.Size(268, 217);
            this.monthlyDataGridView.TabIndex = 7;
            this.monthlyDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.monthlyDataGridView_CellMouseDown);
            this.monthlyDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.monthlyDataGridView_MouseClick_1);
            // 
            // monthlyIdColumn
            // 
            this.monthlyIdColumn.FillWeight = 10F;
            this.monthlyIdColumn.HeaderText = "Id";
            this.monthlyIdColumn.MinimumWidth = 25;
            this.monthlyIdColumn.Name = "monthlyIdColumn";
            this.monthlyIdColumn.ReadOnly = true;
            this.monthlyIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // monthlyDescriptionColumn
            // 
            this.monthlyDescriptionColumn.FillWeight = 40F;
            this.monthlyDescriptionColumn.HeaderText = "Description";
            this.monthlyDescriptionColumn.MinimumWidth = 100;
            this.monthlyDescriptionColumn.Name = "monthlyDescriptionColumn";
            this.monthlyDescriptionColumn.ReadOnly = true;
            this.monthlyDescriptionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.monthlyDescriptionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // monthlyCatColumn
            // 
            this.monthlyCatColumn.FillWeight = 10F;
            this.monthlyCatColumn.HeaderText = "Category";
            this.monthlyCatColumn.MinimumWidth = 40;
            this.monthlyCatColumn.Name = "monthlyCatColumn";
            this.monthlyCatColumn.ReadOnly = true;
            this.monthlyCatColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.monthlyCatColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // monthlyAmtColumn
            // 
            this.monthlyAmtColumn.FillWeight = 40F;
            this.monthlyAmtColumn.HeaderText = "Amount";
            this.monthlyAmtColumn.MinimumWidth = 100;
            this.monthlyAmtColumn.Name = "monthlyAmtColumn";
            this.monthlyAmtColumn.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.yearlyDataGridView);
            this.groupBox2.Controls.Add(this.removeYearlyButton);
            this.groupBox2.Controls.Add(this.addYearlyButton);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yearly:";
            // 
            // yearlyDataGridView
            // 
            this.yearlyDataGridView.AllowUserToAddRows = false;
            this.yearlyDataGridView.AllowUserToDeleteRows = false;
            this.yearlyDataGridView.AllowUserToOrderColumns = true;
            this.yearlyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yearlyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.yearlyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearlyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.yearlyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.yearlyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yearlyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearlyIdColumn,
            this.yearlyDescriptionColumn,
            this.yearlyCatColumn,
            this.yearlyAmtColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.yearlyDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.yearlyDataGridView.EnableHeadersVisualStyles = false;
            this.yearlyDataGridView.Location = new System.Drawing.Point(6, 24);
            this.yearlyDataGridView.MultiSelect = false;
            this.yearlyDataGridView.Name = "yearlyDataGridView";
            this.yearlyDataGridView.ReadOnly = true;
            this.yearlyDataGridView.RowHeadersVisible = false;
            this.yearlyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.yearlyDataGridView.Size = new System.Drawing.Size(267, 217);
            this.yearlyDataGridView.TabIndex = 8;
            this.yearlyDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.yearlyDataGridView_CellMouseDown);
            this.yearlyDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.yearlyDataGridView_MouseClick);
            // 
            // yearlyIdColumn
            // 
            this.yearlyIdColumn.FillWeight = 10F;
            this.yearlyIdColumn.HeaderText = "Id";
            this.yearlyIdColumn.MinimumWidth = 25;
            this.yearlyIdColumn.Name = "yearlyIdColumn";
            this.yearlyIdColumn.ReadOnly = true;
            this.yearlyIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // yearlyDescriptionColumn
            // 
            this.yearlyDescriptionColumn.FillWeight = 40F;
            this.yearlyDescriptionColumn.HeaderText = "Description";
            this.yearlyDescriptionColumn.MinimumWidth = 100;
            this.yearlyDescriptionColumn.Name = "yearlyDescriptionColumn";
            this.yearlyDescriptionColumn.ReadOnly = true;
            this.yearlyDescriptionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.yearlyDescriptionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // yearlyCatColumn
            // 
            this.yearlyCatColumn.FillWeight = 10F;
            this.yearlyCatColumn.HeaderText = "Category";
            this.yearlyCatColumn.MinimumWidth = 38;
            this.yearlyCatColumn.Name = "yearlyCatColumn";
            this.yearlyCatColumn.ReadOnly = true;
            this.yearlyCatColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.yearlyCatColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // yearlyAmtColumn
            // 
            this.yearlyAmtColumn.FillWeight = 40F;
            this.yearlyAmtColumn.HeaderText = "Amount";
            this.yearlyAmtColumn.MinimumWidth = 100;
            this.yearlyAmtColumn.Name = "yearlyAmtColumn";
            this.yearlyAmtColumn.ReadOnly = true;
            // 
            // removeYearlyButton
            // 
            this.removeYearlyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeYearlyButton.BackColor = System.Drawing.Color.Silver;
            this.removeYearlyButton.Enabled = false;
            this.removeYearlyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeYearlyButton.ForeColor = System.Drawing.Color.White;
            this.removeYearlyButton.Image = ((System.Drawing.Image)(resources.GetObject("removeYearlyButton.Image")));
            this.removeYearlyButton.Location = new System.Drawing.Point(241, 247);
            this.removeYearlyButton.Name = "removeYearlyButton";
            this.removeYearlyButton.Size = new System.Drawing.Size(32, 32);
            this.removeYearlyButton.TabIndex = 1;
            this.removeYearlyButton.UseVisualStyleBackColor = false;
            this.removeYearlyButton.Click += new System.EventHandler(this.removeYearlyButton_Click);
            // 
            // addYearlyButton
            // 
            this.addYearlyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addYearlyButton.BackColor = System.Drawing.Color.Silver;
            this.addYearlyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addYearlyButton.ForeColor = System.Drawing.Color.White;
            this.addYearlyButton.Image = ((System.Drawing.Image)(resources.GetObject("addYearlyButton.Image")));
            this.addYearlyButton.Location = new System.Drawing.Point(203, 247);
            this.addYearlyButton.Name = "addYearlyButton";
            this.addYearlyButton.Size = new System.Drawing.Size(32, 32);
            this.addYearlyButton.TabIndex = 0;
            this.addYearlyButton.UseVisualStyleBackColor = false;
            this.addYearlyButton.Click += new System.EventHandler(this.addYearlyButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.removeMonthlyButton);
            this.groupBox3.Controls.Add(this.monthlyDataGridView);
            this.groupBox3.Controls.Add(this.addMonthlyButton);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(288, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 285);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monthly:";
            // 
            // removeMonthlyButton
            // 
            this.removeMonthlyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeMonthlyButton.BackColor = System.Drawing.Color.Silver;
            this.removeMonthlyButton.Enabled = false;
            this.removeMonthlyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeMonthlyButton.ForeColor = System.Drawing.Color.White;
            this.removeMonthlyButton.Image = ((System.Drawing.Image)(resources.GetObject("removeMonthlyButton.Image")));
            this.removeMonthlyButton.Location = new System.Drawing.Point(242, 247);
            this.removeMonthlyButton.Name = "removeMonthlyButton";
            this.removeMonthlyButton.Size = new System.Drawing.Size(32, 32);
            this.removeMonthlyButton.TabIndex = 3;
            this.removeMonthlyButton.UseVisualStyleBackColor = false;
            this.removeMonthlyButton.Click += new System.EventHandler(this.removeMonthlyButton_Click);
            // 
            // addMonthlyButton
            // 
            this.addMonthlyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addMonthlyButton.BackColor = System.Drawing.Color.Silver;
            this.addMonthlyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMonthlyButton.ForeColor = System.Drawing.Color.White;
            this.addMonthlyButton.Image = ((System.Drawing.Image)(resources.GetObject("addMonthlyButton.Image")));
            this.addMonthlyButton.Location = new System.Drawing.Point(204, 247);
            this.addMonthlyButton.Name = "addMonthlyButton";
            this.addMonthlyButton.Size = new System.Drawing.Size(32, 32);
            this.addMonthlyButton.TabIndex = 2;
            this.addMonthlyButton.UseVisualStyleBackColor = false;
            this.addMonthlyButton.Click += new System.EventHandler(this.addMonthlyButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.wantedDataGridView);
            this.groupBox4.Controls.Add(this.removeWantedButton);
            this.groupBox4.Controls.Add(this.addWantedButton);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(574, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 285);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wanted:";
            // 
            // wantedDataGridView
            // 
            this.wantedDataGridView.AllowUserToAddRows = false;
            this.wantedDataGridView.AllowUserToOrderColumns = true;
            this.wantedDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wantedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.wantedDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wantedDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.wantedDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.wantedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wantedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wantedIdColumn,
            this.wantedDescriptionColumn,
            this.wantedCatColumn,
            this.wantedAmtColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.wantedDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.wantedDataGridView.EnableHeadersVisualStyles = false;
            this.wantedDataGridView.Location = new System.Drawing.Point(6, 24);
            this.wantedDataGridView.MultiSelect = false;
            this.wantedDataGridView.Name = "wantedDataGridView";
            this.wantedDataGridView.ReadOnly = true;
            this.wantedDataGridView.RowHeadersVisible = false;
            this.wantedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wantedDataGridView.Size = new System.Drawing.Size(269, 217);
            this.wantedDataGridView.TabIndex = 6;
            this.wantedDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.wantedDataGridView_CellMouseDown);
            this.wantedDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.wantedDataGridView_MouseClick);
            // 
            // wantedIdColumn
            // 
            this.wantedIdColumn.FillWeight = 10F;
            this.wantedIdColumn.HeaderText = "Id";
            this.wantedIdColumn.MinimumWidth = 25;
            this.wantedIdColumn.Name = "wantedIdColumn";
            this.wantedIdColumn.ReadOnly = true;
            this.wantedIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // wantedDescriptionColumn
            // 
            this.wantedDescriptionColumn.FillWeight = 40F;
            this.wantedDescriptionColumn.HeaderText = "Description";
            this.wantedDescriptionColumn.MinimumWidth = 100;
            this.wantedDescriptionColumn.Name = "wantedDescriptionColumn";
            this.wantedDescriptionColumn.ReadOnly = true;
            this.wantedDescriptionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wantedDescriptionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // wantedCatColumn
            // 
            this.wantedCatColumn.FillWeight = 10F;
            this.wantedCatColumn.HeaderText = "Category";
            this.wantedCatColumn.MinimumWidth = 40;
            this.wantedCatColumn.Name = "wantedCatColumn";
            this.wantedCatColumn.ReadOnly = true;
            this.wantedCatColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wantedCatColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // wantedAmtColumn
            // 
            this.wantedAmtColumn.FillWeight = 40F;
            this.wantedAmtColumn.HeaderText = "Amount";
            this.wantedAmtColumn.MinimumWidth = 100;
            this.wantedAmtColumn.Name = "wantedAmtColumn";
            this.wantedAmtColumn.ReadOnly = true;
            // 
            // removeWantedButton
            // 
            this.removeWantedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeWantedButton.BackColor = System.Drawing.Color.Silver;
            this.removeWantedButton.Enabled = false;
            this.removeWantedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeWantedButton.ForeColor = System.Drawing.Color.White;
            this.removeWantedButton.Image = ((System.Drawing.Image)(resources.GetObject("removeWantedButton.Image")));
            this.removeWantedButton.Location = new System.Drawing.Point(243, 247);
            this.removeWantedButton.Name = "removeWantedButton";
            this.removeWantedButton.Size = new System.Drawing.Size(32, 32);
            this.removeWantedButton.TabIndex = 5;
            this.removeWantedButton.UseVisualStyleBackColor = false;
            this.removeWantedButton.Click += new System.EventHandler(this.removeWantedButton_Click);
            // 
            // addWantedButton
            // 
            this.addWantedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addWantedButton.BackColor = System.Drawing.Color.Silver;
            this.addWantedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWantedButton.ForeColor = System.Drawing.Color.White;
            this.addWantedButton.Image = ((System.Drawing.Image)(resources.GetObject("addWantedButton.Image")));
            this.addWantedButton.Location = new System.Drawing.Point(205, 247);
            this.addWantedButton.Name = "addWantedButton";
            this.addWantedButton.Size = new System.Drawing.Size(32, 32);
            this.addWantedButton.TabIndex = 4;
            this.addWantedButton.UseVisualStyleBackColor = false;
            this.addWantedButton.Click += new System.EventHandler(this.addWantedButton_Click);
            // 
            // monthlyContextMenu
            // 
            this.monthlyContextMenu.Name = "monthlyContextMenu";
            this.monthlyContextMenu.Size = new System.Drawing.Size(61, 4);
            this.monthlyContextMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.monthlyContextMenu_MouseClick);
            // 
            // wantedContextMenu
            // 
            this.wantedContextMenu.Name = "wantedContextMenu";
            this.wantedContextMenu.Size = new System.Drawing.Size(61, 4);
            this.wantedContextMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.wantedContextMenu_MouseClick);
            // 
            // yearlyContextMenu
            // 
            this.yearlyContextMenu.Name = "yearlyContextMenu";
            this.yearlyContextMenu.Size = new System.Drawing.Size(61, 4);
            this.yearlyContextMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.yearlyContextMenu_MouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 160);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 312F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(858, 291);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // cat4Bar
            // 
            this.cat4Bar.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.cat4Bar.BackColor = System.Drawing.Color.Red;
            this.cat4Bar.Location = new System.Drawing.Point(452, 24);
            this.cat4Bar.Name = "cat4Bar";
            this.cat4Bar.Size = new System.Drawing.Size(397, 10);
            this.cat4Bar.TabIndex = 14;
            // 
            // cat1Bar
            // 
            this.cat1Bar.BackColor = System.Drawing.Color.ForestGreen;
            this.cat1Bar.Location = new System.Drawing.Point(452, 24);
            this.cat1Bar.Name = "cat1Bar";
            this.cat1Bar.Size = new System.Drawing.Size(397, 10);
            this.cat1Bar.TabIndex = 12;
            // 
            // cat3Bar
            // 
            this.cat3Bar.BackColor = System.Drawing.Color.Gold;
            this.cat3Bar.Location = new System.Drawing.Point(452, 24);
            this.cat3Bar.Name = "cat3Bar";
            this.cat3Bar.Size = new System.Drawing.Size(397, 10);
            this.cat3Bar.TabIndex = 14;
            // 
            // cat2Bar
            // 
            this.cat2Bar.BackColor = System.Drawing.Color.YellowGreen;
            this.cat2Bar.Location = new System.Drawing.Point(452, 24);
            this.cat2Bar.Name = "cat2Bar";
            this.cat2Bar.Size = new System.Drawing.Size(397, 10);
            this.cat2Bar.TabIndex = 13;
            // 
            // catBarChartLabel
            // 
            this.catBarChartLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.catBarChartLabel.AutoSize = true;
            this.catBarChartLabel.ForeColor = System.Drawing.Color.White;
            this.catBarChartLabel.Location = new System.Drawing.Point(312, 18);
            this.catBarChartLabel.Name = "catBarChartLabel";
            this.catBarChartLabel.Size = new System.Drawing.Size(190, 18);
            this.catBarChartLabel.TabIndex = 15;
            this.catBarChartLabel.Text = "Category &Competitiveness:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(900, 500);
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
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label yearlyMonthBills;
        private System.Windows.Forms.ContextMenuStrip monthlyContextMenu;
        private System.Windows.Forms.ContextMenuStrip wantedContextMenu;
        private System.Windows.Forms.ContextMenuStrip yearlyContextMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.Panel cat4Bar;
        private System.Windows.Forms.Panel cat3Bar;
        private System.Windows.Forms.Panel cat2Bar;
        private System.Windows.Forms.Panel cat1Bar;
        private System.Windows.Forms.Label catBarChartLabel;
    }
}

