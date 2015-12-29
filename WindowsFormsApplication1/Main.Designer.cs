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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yearlyListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.monthlyListBox = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addWantedButton = new System.Windows.Forms.Button();
            this.wantedListBox = new System.Windows.Forms.ListBox();
            this.addMonthlyButton = new System.Windows.Forms.Button();
            this.addYearlyButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totals";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addYearlyButton);
            this.groupBox2.Controls.Add(this.yearlyListBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yearly:";
            // 
            // yearlyListBox
            // 
            this.yearlyListBox.FormattingEnabled = true;
            this.yearlyListBox.HorizontalScrollbar = true;
            this.yearlyListBox.ItemHeight = 18;
            this.yearlyListBox.Location = new System.Drawing.Point(6, 24);
            this.yearlyListBox.MultiColumn = true;
            this.yearlyListBox.Name = "yearlyListBox";
            this.yearlyListBox.ScrollAlwaysVisible = true;
            this.yearlyListBox.Size = new System.Drawing.Size(224, 220);
            this.yearlyListBox.Sorted = true;
            this.yearlyListBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addMonthlyButton);
            this.groupBox3.Controls.Add(this.monthlyListBox);
            this.groupBox3.Location = new System.Drawing.Point(255, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 288);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monthly:";
            // 
            // monthlyListBox
            // 
            this.monthlyListBox.FormattingEnabled = true;
            this.monthlyListBox.HorizontalScrollbar = true;
            this.monthlyListBox.ItemHeight = 18;
            this.monthlyListBox.Location = new System.Drawing.Point(6, 24);
            this.monthlyListBox.MultiColumn = true;
            this.monthlyListBox.Name = "monthlyListBox";
            this.monthlyListBox.ScrollAlwaysVisible = true;
            this.monthlyListBox.Size = new System.Drawing.Size(224, 220);
            this.monthlyListBox.Sorted = true;
            this.monthlyListBox.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addWantedButton);
            this.groupBox4.Controls.Add(this.wantedListBox);
            this.groupBox4.Location = new System.Drawing.Point(497, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 288);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wanted:";
            // 
            // addWantedButton
            // 
            this.addWantedButton.Image = ((System.Drawing.Image)(resources.GetObject("addWantedButton.Image")));
            this.addWantedButton.Location = new System.Drawing.Point(236, 250);
            this.addWantedButton.Name = "addWantedButton";
            this.addWantedButton.Size = new System.Drawing.Size(32, 32);
            this.addWantedButton.TabIndex = 3;
            this.addWantedButton.UseVisualStyleBackColor = true;
            this.addWantedButton.Click += new System.EventHandler(this.addWantedButton_Click);
            // 
            // wantedListBox
            // 
            this.wantedListBox.FormattingEnabled = true;
            this.wantedListBox.HorizontalScrollbar = true;
            this.wantedListBox.ItemHeight = 18;
            this.wantedListBox.Location = new System.Drawing.Point(6, 24);
            this.wantedListBox.MultiColumn = true;
            this.wantedListBox.Name = "wantedListBox";
            this.wantedListBox.ScrollAlwaysVisible = true;
            this.wantedListBox.Size = new System.Drawing.Size(262, 220);
            this.wantedListBox.Sorted = true;
            this.wantedListBox.TabIndex = 2;
            // 
            // addMonthlyButton
            // 
            this.addMonthlyButton.Image = ((System.Drawing.Image)(resources.GetObject("addMonthlyButton.Image")));
            this.addMonthlyButton.Location = new System.Drawing.Point(198, 250);
            this.addMonthlyButton.Name = "addMonthlyButton";
            this.addMonthlyButton.Size = new System.Drawing.Size(32, 32);
            this.addMonthlyButton.TabIndex = 4;
            this.addMonthlyButton.UseVisualStyleBackColor = true;
            this.addMonthlyButton.Click += new System.EventHandler(this.addMonthlyButton_Click);
            // 
            // addYearlyButton
            // 
            this.addYearlyButton.Image = ((System.Drawing.Image)(resources.GetObject("addYearlyButton.Image")));
            this.addYearlyButton.Location = new System.Drawing.Point(198, 250);
            this.addYearlyButton.Name = "addYearlyButton";
            this.addYearlyButton.Size = new System.Drawing.Size(32, 32);
            this.addYearlyButton.TabIndex = 5;
            this.addYearlyButton.UseVisualStyleBackColor = true;
            this.addYearlyButton.Click += new System.EventHandler(this.addYearlyButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox yearlyListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox monthlyListBox;
        private System.Windows.Forms.Button addWantedButton;
        private System.Windows.Forms.ListBox wantedListBox;
        private System.Windows.Forms.Button addYearlyButton;
        private System.Windows.Forms.Button addMonthlyButton;
    }
}

