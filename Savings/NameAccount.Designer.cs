namespace Savings
{
    partial class NameAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.accountNameTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.errorProviderNameAccount = new System.Windows.Forms.ErrorProvider(this.components);
            this.useLocal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNameAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // accountNameTextBox
            // 
            this.accountNameTextBox.Location = new System.Drawing.Point(56, 26);
            this.accountNameTextBox.Name = "accountNameTextBox";
            this.accountNameTextBox.Size = new System.Drawing.Size(265, 20);
            this.accountNameTextBox.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.Silver;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(246, 60);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // errorProviderNameAccount
            // 
            this.errorProviderNameAccount.ContainerControl = this;
            this.errorProviderNameAccount.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderNameAccount.Icon")));
            // 
            // useLocal
            // 
            this.useLocal.AutoSize = true;
            this.useLocal.Checked = true;
            this.useLocal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useLocal.ForeColor = System.Drawing.Color.White;
            this.useLocal.Location = new System.Drawing.Point(56, 52);
            this.useLocal.Name = "useLocal";
            this.useLocal.Size = new System.Drawing.Size(181, 17);
            this.useLocal.TabIndex = 2;
            this.useLocal.Text = "Use &Savings folder on local drive";
            this.useLocal.UseVisualStyleBackColor = true;
            // 
            // NameAccount
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ClientSize = new System.Drawing.Size(333, 95);
            this.Controls.Add(this.useLocal);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.accountNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NameAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Account";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNameAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountNameTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ErrorProvider errorProviderNameAccount;
        private System.Windows.Forms.CheckBox useLocal;
    }
}