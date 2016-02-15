namespace Savings
{
    partial class Assests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assests));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.assestsDataGridView = new System.Windows.Forms.DataGridView();
            this.assestIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asssestDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assestCatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assestAmtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeAssestButton = new System.Windows.Forms.Button();
            this.addAssestButton = new System.Windows.Forms.Button();
            this.avaliableFunds = new System.Windows.Forms.Label();
            this.avaliableLabel = new System.Windows.Forms.Label();
            this.spendingFunds = new System.Windows.Forms.Label();
            this.spendingLabel = new System.Windows.Forms.Label();
            this.assestsFig = new System.Windows.Forms.Label();
            this.assestsLabel = new System.Windows.Forms.Label();
            this.assestContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.chart6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.noValues2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assestsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).BeginInit();
            this.SuspendLayout();
            // 
            // assestsDataGridView
            // 
            this.assestsDataGridView.AllowUserToAddRows = false;
            this.assestsDataGridView.AllowUserToDeleteRows = false;
            this.assestsDataGridView.AllowUserToOrderColumns = true;
            this.assestsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assestsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.assestsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.assestsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.assestsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.assestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assestsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assestIdColumn,
            this.asssestDescriptionColumn,
            this.assestCatColumn,
            this.assestAmtColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.assestsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.assestsDataGridView.EnableHeadersVisualStyles = false;
            this.assestsDataGridView.Location = new System.Drawing.Point(13, 190);
            this.assestsDataGridView.MultiSelect = false;
            this.assestsDataGridView.Name = "assestsDataGridView";
            this.assestsDataGridView.ReadOnly = true;
            this.assestsDataGridView.RowHeadersVisible = false;
            this.assestsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assestsDataGridView.Size = new System.Drawing.Size(414, 341);
            this.assestsDataGridView.TabIndex = 11;
            this.assestsDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.assestsDataGridView_CellMouseDown);
            this.assestsDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.assestsDataGridView_MouseClick);
            // 
            // assestIdColumn
            // 
            this.assestIdColumn.FillWeight = 10F;
            this.assestIdColumn.HeaderText = "Id";
            this.assestIdColumn.MinimumWidth = 25;
            this.assestIdColumn.Name = "assestIdColumn";
            this.assestIdColumn.ReadOnly = true;
            this.assestIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // asssestDescriptionColumn
            // 
            this.asssestDescriptionColumn.FillWeight = 50F;
            this.asssestDescriptionColumn.HeaderText = "Description";
            this.asssestDescriptionColumn.MinimumWidth = 100;
            this.asssestDescriptionColumn.Name = "asssestDescriptionColumn";
            this.asssestDescriptionColumn.ReadOnly = true;
            this.asssestDescriptionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.asssestDescriptionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // assestCatColumn
            // 
            this.assestCatColumn.FillWeight = 20F;
            this.assestCatColumn.HeaderText = "Category";
            this.assestCatColumn.MinimumWidth = 38;
            this.assestCatColumn.Name = "assestCatColumn";
            this.assestCatColumn.ReadOnly = true;
            this.assestCatColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.assestCatColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // assestAmtColumn
            // 
            this.assestAmtColumn.FillWeight = 20F;
            this.assestAmtColumn.HeaderText = "Amount";
            this.assestAmtColumn.MinimumWidth = 100;
            this.assestAmtColumn.Name = "assestAmtColumn";
            this.assestAmtColumn.ReadOnly = true;
            // 
            // removeAssestButton
            // 
            this.removeAssestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeAssestButton.BackColor = System.Drawing.Color.Silver;
            this.removeAssestButton.Enabled = false;
            this.removeAssestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAssestButton.ForeColor = System.Drawing.Color.White;
            this.removeAssestButton.Image = ((System.Drawing.Image)(resources.GetObject("removeAssestButton.Image")));
            this.removeAssestButton.Location = new System.Drawing.Point(395, 537);
            this.removeAssestButton.Name = "removeAssestButton";
            this.removeAssestButton.Size = new System.Drawing.Size(32, 32);
            this.removeAssestButton.TabIndex = 10;
            this.removeAssestButton.UseVisualStyleBackColor = false;
            this.removeAssestButton.Click += new System.EventHandler(this.removeAssestButton_Click);
            // 
            // addAssestButton
            // 
            this.addAssestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addAssestButton.BackColor = System.Drawing.Color.Silver;
            this.addAssestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAssestButton.ForeColor = System.Drawing.Color.White;
            this.addAssestButton.Image = ((System.Drawing.Image)(resources.GetObject("addAssestButton.Image")));
            this.addAssestButton.Location = new System.Drawing.Point(357, 537);
            this.addAssestButton.Name = "addAssestButton";
            this.addAssestButton.Size = new System.Drawing.Size(32, 32);
            this.addAssestButton.TabIndex = 9;
            this.addAssestButton.UseVisualStyleBackColor = false;
            this.addAssestButton.Click += new System.EventHandler(this.addAssestButton_Click);
            // 
            // avaliableFunds
            // 
            this.avaliableFunds.AutoSize = true;
            this.avaliableFunds.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avaliableFunds.ForeColor = System.Drawing.Color.YellowGreen;
            this.avaliableFunds.Location = new System.Drawing.Point(125, 10);
            this.avaliableFunds.Name = "avaliableFunds";
            this.avaliableFunds.Size = new System.Drawing.Size(142, 25);
            this.avaliableFunds.TabIndex = 13;
            this.avaliableFunds.Text = "avaliableFunds";
            this.avaliableFunds.Visible = false;
            // 
            // avaliableLabel
            // 
            this.avaliableLabel.AutoSize = true;
            this.avaliableLabel.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avaliableLabel.ForeColor = System.Drawing.Color.White;
            this.avaliableLabel.Location = new System.Drawing.Point(13, 10);
            this.avaliableLabel.Name = "avaliableLabel";
            this.avaliableLabel.Size = new System.Drawing.Size(106, 25);
            this.avaliableLabel.TabIndex = 12;
            this.avaliableLabel.Text = "Avaliable:";
            // 
            // spendingFunds
            // 
            this.spendingFunds.AutoSize = true;
            this.spendingFunds.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spendingFunds.ForeColor = System.Drawing.Color.Red;
            this.spendingFunds.Location = new System.Drawing.Point(125, 44);
            this.spendingFunds.Name = "spendingFunds";
            this.spendingFunds.Size = new System.Drawing.Size(143, 25);
            this.spendingFunds.TabIndex = 15;
            this.spendingFunds.Text = "spendingFunds";
            this.spendingFunds.Visible = false;
            // 
            // spendingLabel
            // 
            this.spendingLabel.AutoSize = true;
            this.spendingLabel.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spendingLabel.ForeColor = System.Drawing.Color.White;
            this.spendingLabel.Location = new System.Drawing.Point(12, 44);
            this.spendingLabel.Name = "spendingLabel";
            this.spendingLabel.Size = new System.Drawing.Size(107, 25);
            this.spendingLabel.TabIndex = 14;
            this.spendingLabel.Text = "Spending:";
            // 
            // assestsFig
            // 
            this.assestsFig.AutoSize = true;
            this.assestsFig.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assestsFig.ForeColor = System.Drawing.Color.Orange;
            this.assestsFig.Location = new System.Drawing.Point(125, 77);
            this.assestsFig.Name = "assestsFig";
            this.assestsFig.Size = new System.Drawing.Size(79, 25);
            this.assestsFig.TabIndex = 17;
            this.assestsFig.Text = "assests";
            this.assestsFig.Visible = false;
            // 
            // assestsLabel
            // 
            this.assestsLabel.AutoSize = true;
            this.assestsLabel.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assestsLabel.ForeColor = System.Drawing.Color.White;
            this.assestsLabel.Location = new System.Drawing.Point(25, 77);
            this.assestsLabel.Name = "assestsLabel";
            this.assestsLabel.Size = new System.Drawing.Size(94, 25);
            this.assestsLabel.TabIndex = 16;
            this.assestsLabel.Text = "Assests:";
            // 
            // assestContextMenu
            // 
            this.assestContextMenu.Name = "assestContextMenu";
            this.assestContextMenu.Size = new System.Drawing.Size(61, 4);
            this.assestContextMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.assestContextMenu_MouseClick);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(279, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 25);
            this.label14.TabIndex = 64;
            this.label14.Text = "Spent vs Saved:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // chart6
            // 
            this.chart6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chart6.BackColor = System.Drawing.Color.Transparent;
            this.chart6.BorderlineColor = System.Drawing.Color.DimGray;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "BreakdownTotal";
            this.chart6.ChartAreas.Add(chartArea1);
            this.chart6.Location = new System.Drawing.Point(276, 30);
            this.chart6.Name = "chart6";
            this.chart6.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "BreakdownTotal";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.White;
            series1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            series1.IsVisibleInLegend = false;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Name = "Breakdown";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ToolTip = "Overall Total for Category 1.";
            this.chart6.Series.Add(series1);
            this.chart6.Size = new System.Drawing.Size(160, 158);
            this.chart6.TabIndex = 63;
            this.chart6.Text = "Category Totals";
            // 
            // noValues2
            // 
            this.noValues2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noValues2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.noValues2.ForeColor = System.Drawing.Color.White;
            this.noValues2.Location = new System.Drawing.Point(312, 81);
            this.noValues2.Name = "noValues2";
            this.noValues2.Size = new System.Drawing.Size(87, 37);
            this.noValues2.TabIndex = 65;
            this.noValues2.Text = "No Values Exist";
            this.noValues2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.noValues2.Visible = false;
            // 
            // Assests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(440, 582);
            this.Controls.Add(this.noValues2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chart6);
            this.Controls.Add(this.assestsFig);
            this.Controls.Add(this.assestsLabel);
            this.Controls.Add(this.spendingFunds);
            this.Controls.Add(this.spendingLabel);
            this.Controls.Add(this.avaliableFunds);
            this.Controls.Add(this.avaliableLabel);
            this.Controls.Add(this.assestsDataGridView);
            this.Controls.Add(this.removeAssestButton);
            this.Controls.Add(this.addAssestButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(456, 621);
            this.Name = "Assests";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assests";
            ((System.ComponentModel.ISupportInitialize)(this.assestsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView assestsDataGridView;
        private System.Windows.Forms.Button removeAssestButton;
        private System.Windows.Forms.Button addAssestButton;
        private System.Windows.Forms.Label avaliableFunds;
        private System.Windows.Forms.Label avaliableLabel;
        private System.Windows.Forms.Label spendingFunds;
        private System.Windows.Forms.Label spendingLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn assestIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asssestDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assestCatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assestAmtColumn;
        private System.Windows.Forms.Label assestsFig;
        private System.Windows.Forms.Label assestsLabel;
        private System.Windows.Forms.ContextMenuStrip assestContextMenu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart6;
        private System.Windows.Forms.Label noValues2;
    }
}