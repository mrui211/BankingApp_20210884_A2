namespace BankingApp_20210884
{
    partial class ManageAccouts
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
            this.lblCustomersList = new System.Windows.Forms.Label();
            this.lsBoxCustomers = new System.Windows.Forms.ListBox();
            this.btnAddInterest = new System.Windows.Forms.Button();
            this.btnCalculateInterest = new System.Windows.Forms.Button();
            this.lblTransactionHistory = new System.Windows.Forms.Label();
            this.lstBoxTransactionsHistory = new System.Windows.Forms.ListBox();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtOverdraftPermitted = new System.Windows.Forms.TextBox();
            this.lblOverdraftPermitted = new System.Windows.Forms.Label();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCustomerAccountsList = new System.Windows.Forms.Label();
            this.lsBoxCustomerAccounts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCustomersList
            // 
            this.lblCustomersList.AutoSize = true;
            this.lblCustomersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersList.Location = new System.Drawing.Point(51, 15);
            this.lblCustomersList.Name = "lblCustomersList";
            this.lblCustomersList.Size = new System.Drawing.Size(180, 25);
            this.lblCustomersList.TabIndex = 18;
            this.lblCustomersList.Text = "List of Customers";
            // 
            // lsBoxCustomers
            // 
            this.lsBoxCustomers.FormattingEnabled = true;
            this.lsBoxCustomers.ItemHeight = 16;
            this.lsBoxCustomers.Location = new System.Drawing.Point(54, 54);
            this.lsBoxCustomers.Name = "lsBoxCustomers";
            this.lsBoxCustomers.Size = new System.Drawing.Size(946, 164);
            this.lsBoxCustomers.TabIndex = 17;
            this.lsBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.lsBoxCustomers_SelectedIndexChanged);
            // 
            // btnAddInterest
            // 
            this.btnAddInterest.Location = new System.Drawing.Point(353, 460);
            this.btnAddInterest.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddInterest.Name = "btnAddInterest";
            this.btnAddInterest.Size = new System.Drawing.Size(107, 42);
            this.btnAddInterest.TabIndex = 33;
            this.btnAddInterest.Text = "Add Interest";
            this.btnAddInterest.UseVisualStyleBackColor = true;
            this.btnAddInterest.Click += new System.EventHandler(this.btnAddInterest_Click);
            // 
            // btnCalculateInterest
            // 
            this.btnCalculateInterest.Location = new System.Drawing.Point(238, 460);
            this.btnCalculateInterest.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateInterest.Name = "btnCalculateInterest";
            this.btnCalculateInterest.Size = new System.Drawing.Size(107, 42);
            this.btnCalculateInterest.TabIndex = 34;
            this.btnCalculateInterest.Text = "Calculate Interest";
            this.btnCalculateInterest.UseVisualStyleBackColor = true;
            this.btnCalculateInterest.Click += new System.EventHandler(this.btnCalculateInterest_Click);
            // 
            // lblTransactionHistory
            // 
            this.lblTransactionHistory.AutoSize = true;
            this.lblTransactionHistory.Location = new System.Drawing.Point(557, 286);
            this.lblTransactionHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionHistory.Name = "lblTransactionHistory";
            this.lblTransactionHistory.Size = new System.Drawing.Size(130, 16);
            this.lblTransactionHistory.TabIndex = 32;
            this.lblTransactionHistory.Text = "Transactions History";
            // 
            // lstBoxTransactionsHistory
            // 
            this.lstBoxTransactionsHistory.FormattingEnabled = true;
            this.lstBoxTransactionsHistory.ItemHeight = 16;
            this.lstBoxTransactionsHistory.Location = new System.Drawing.Point(560, 306);
            this.lstBoxTransactionsHistory.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxTransactionsHistory.Name = "lstBoxTransactionsHistory";
            this.lstBoxTransactionsHistory.Size = new System.Drawing.Size(1228, 196);
            this.lstBoxTransactionsHistory.TabIndex = 31;
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Location = new System.Drawing.Point(127, 460);
            this.btnWithdrawal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(107, 42);
            this.btnWithdrawal.TabIndex = 29;
            this.btnWithdrawal.Text = "Withdrawal";
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(14, 460);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(107, 42);
            this.btnDeposit.TabIndex = 30;
            this.btnDeposit.Text = "Deposit ";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtOverdraftPermitted
            // 
            this.txtOverdraftPermitted.Enabled = false;
            this.txtOverdraftPermitted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverdraftPermitted.Location = new System.Drawing.Point(186, 424);
            this.txtOverdraftPermitted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOverdraftPermitted.Name = "txtOverdraftPermitted";
            this.txtOverdraftPermitted.Size = new System.Drawing.Size(100, 23);
            this.txtOverdraftPermitted.TabIndex = 25;
            // 
            // lblOverdraftPermitted
            // 
            this.lblOverdraftPermitted.AutoSize = true;
            this.lblOverdraftPermitted.Location = new System.Drawing.Point(56, 427);
            this.lblOverdraftPermitted.Name = "lblOverdraftPermitted";
            this.lblOverdraftPermitted.Size = new System.Drawing.Size(125, 16);
            this.lblOverdraftPermitted.TabIndex = 21;
            this.lblOverdraftPermitted.Text = "Overdraft Permitted:";
            // 
            // txtInterest
            // 
            this.txtInterest.Enabled = false;
            this.txtInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterest.Location = new System.Drawing.Point(186, 393);
            this.txtInterest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(100, 23);
            this.txtInterest.TabIndex = 26;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(128, 397);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(53, 16);
            this.lblInterest.TabIndex = 22;
            this.lblInterest.Text = "Interest:";
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(186, 333);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 23);
            this.txtBalance.TabIndex = 27;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(121, 333);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(60, 16);
            this.lblBalance.TabIndex = 23;
            this.lblBalance.Text = "Balance:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(186, 364);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 28;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(126, 364);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(55, 16);
            this.lblAmount.TabIndex = 24;
            this.lblAmount.Text = "Amount:";
            // 
            // lblCustomerAccountsList
            // 
            this.lblCustomerAccountsList.AutoSize = true;
            this.lblCustomerAccountsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAccountsList.Location = new System.Drawing.Point(1070, 15);
            this.lblCustomerAccountsList.Name = "lblCustomerAccountsList";
            this.lblCustomerAccountsList.Size = new System.Drawing.Size(241, 25);
            this.lblCustomerAccountsList.TabIndex = 36;
            this.lblCustomerAccountsList.Text = "Customer Accounts List";
            // 
            // lsBoxCustomerAccounts
            // 
            this.lsBoxCustomerAccounts.FormattingEnabled = true;
            this.lsBoxCustomerAccounts.ItemHeight = 16;
            this.lsBoxCustomerAccounts.Location = new System.Drawing.Point(1073, 57);
            this.lsBoxCustomerAccounts.Name = "lsBoxCustomerAccounts";
            this.lsBoxCustomerAccounts.Size = new System.Drawing.Size(1159, 164);
            this.lsBoxCustomerAccounts.TabIndex = 35;
            this.lsBoxCustomerAccounts.SelectedIndexChanged += new System.EventHandler(this.lsBoxCustomerAccounts_SelectedIndexChanged);
            // 
            // ManageAccouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2614, 1110);
            this.Controls.Add(this.lblCustomerAccountsList);
            this.Controls.Add(this.lsBoxCustomerAccounts);
            this.Controls.Add(this.btnAddInterest);
            this.Controls.Add(this.btnCalculateInterest);
            this.Controls.Add(this.lblTransactionHistory);
            this.Controls.Add(this.lstBoxTransactionsHistory);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtOverdraftPermitted);
            this.Controls.Add(this.lblOverdraftPermitted);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblCustomersList);
            this.Controls.Add(this.lsBoxCustomers);
            this.Name = "ManageAccouts";
            this.Text = "ManageAccouts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageAccouts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomersList;
        private System.Windows.Forms.ListBox lsBoxCustomers;
        private System.Windows.Forms.Button btnAddInterest;
        private System.Windows.Forms.Button btnCalculateInterest;
        private System.Windows.Forms.Label lblTransactionHistory;
        private System.Windows.Forms.ListBox lstBoxTransactionsHistory;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtOverdraftPermitted;
        private System.Windows.Forms.Label lblOverdraftPermitted;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCustomerAccountsList;
        private System.Windows.Forms.ListBox lsBoxCustomerAccounts;
    }
}