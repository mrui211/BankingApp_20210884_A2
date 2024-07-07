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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAccouts));
            this.lblCustomersList = new System.Windows.Forms.Label();
            this.lsBoxCustomers = new System.Windows.Forms.ListBox();
            this.btnAddInterest = new System.Windows.Forms.Button();
            this.btnCalculateInterest = new System.Windows.Forms.Button();
            this.lblTransactionHistory = new System.Windows.Forms.Label();
            this.lstBoxTransactionsHistory = new System.Windows.Forms.ListBox();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.btnConfirmTransfer = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBoxTransfer = new System.Windows.Forms.GroupBox();
            this.lblTransferto = new System.Windows.Forms.Label();
            this.LblTransferFrom = new System.Windows.Forms.Label();
            this.lblTransferAmount = new System.Windows.Forms.Label();
            this.cmBoxTransferTo = new System.Windows.Forms.ComboBox();
            this.cmBoxTransferFrom = new System.Windows.Forms.ComboBox();
            this.txtTotalTransfer = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomersList
            // 
            this.lblCustomersList.AutoSize = true;
            this.lblCustomersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersList.ForeColor = System.Drawing.Color.White;
            this.lblCustomersList.Location = new System.Drawing.Point(1227, 97);
            this.lblCustomersList.Name = "lblCustomersList";
            this.lblCustomersList.Size = new System.Drawing.Size(180, 25);
            this.lblCustomersList.TabIndex = 18;
            this.lblCustomersList.Text = "List of Customers";
            this.lblCustomersList.Visible = false;
            // 
            // lsBoxCustomers
            // 
            this.lsBoxCustomers.FormattingEnabled = true;
            this.lsBoxCustomers.ItemHeight = 16;
            this.lsBoxCustomers.Location = new System.Drawing.Point(1297, 74);
            this.lsBoxCustomers.Name = "lsBoxCustomers";
            this.lsBoxCustomers.Size = new System.Drawing.Size(90, 20);
            this.lsBoxCustomers.TabIndex = 17;
            this.lsBoxCustomers.Visible = false;
            this.lsBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.lsBoxCustomers_SelectedIndexChanged);
            // 
            // btnAddInterest
            // 
            this.btnAddInterest.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddInterest.Location = new System.Drawing.Point(1474, 356);
            this.btnAddInterest.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddInterest.Name = "btnAddInterest";
            this.btnAddInterest.Size = new System.Drawing.Size(107, 42);
            this.btnAddInterest.TabIndex = 33;
            this.btnAddInterest.Text = "Add Interest";
            this.btnAddInterest.UseVisualStyleBackColor = false;
            this.btnAddInterest.Click += new System.EventHandler(this.btnAddInterest_Click);
            // 
            // btnCalculateInterest
            // 
            this.btnCalculateInterest.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCalculateInterest.Location = new System.Drawing.Point(1359, 356);
            this.btnCalculateInterest.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateInterest.Name = "btnCalculateInterest";
            this.btnCalculateInterest.Size = new System.Drawing.Size(107, 42);
            this.btnCalculateInterest.TabIndex = 34;
            this.btnCalculateInterest.Text = "Calculate Interest";
            this.btnCalculateInterest.UseVisualStyleBackColor = false;
            this.btnCalculateInterest.Click += new System.EventHandler(this.btnCalculateInterest_Click);
            // 
            // lblTransactionHistory
            // 
            this.lblTransactionHistory.AutoSize = true;
            this.lblTransactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionHistory.ForeColor = System.Drawing.Color.White;
            this.lblTransactionHistory.Location = new System.Drawing.Point(32, 533);
            this.lblTransactionHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionHistory.Name = "lblTransactionHistory";
            this.lblTransactionHistory.Size = new System.Drawing.Size(150, 16);
            this.lblTransactionHistory.TabIndex = 32;
            this.lblTransactionHistory.Text = "Transactions History";
            // 
            // lstBoxTransactionsHistory
            // 
            this.lstBoxTransactionsHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxTransactionsHistory.FormattingEnabled = true;
            this.lstBoxTransactionsHistory.ItemHeight = 16;
            this.lstBoxTransactionsHistory.Location = new System.Drawing.Point(39, 553);
            this.lstBoxTransactionsHistory.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxTransactionsHistory.Name = "lstBoxTransactionsHistory";
            this.lstBoxTransactionsHistory.Size = new System.Drawing.Size(1675, 452);
            this.lstBoxTransactionsHistory.TabIndex = 31;
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.BackColor = System.Drawing.Color.ForestGreen;
            this.btnWithdrawal.Location = new System.Drawing.Point(1248, 356);
            this.btnWithdrawal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(107, 42);
            this.btnWithdrawal.TabIndex = 29;
            this.btnWithdrawal.Text = "Withdrawal";
            this.btnWithdrawal.UseVisualStyleBackColor = false;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // btnConfirmTransfer
            // 
            this.btnConfirmTransfer.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmTransfer.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmTransfer.Location = new System.Drawing.Point(1518, 44);
            this.btnConfirmTransfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmTransfer.Name = "btnConfirmTransfer";
            this.btnConfirmTransfer.Size = new System.Drawing.Size(107, 34);
            this.btnConfirmTransfer.TabIndex = 30;
            this.btnConfirmTransfer.Text = "Confirm";
            this.btnConfirmTransfer.UseVisualStyleBackColor = false;
            this.btnConfirmTransfer.Click += new System.EventHandler(this.btnConfirmTransfer_Click);
            // 
            // txtOverdraftPermitted
            // 
            this.txtOverdraftPermitted.Enabled = false;
            this.txtOverdraftPermitted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverdraftPermitted.Location = new System.Drawing.Point(1307, 320);
            this.txtOverdraftPermitted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOverdraftPermitted.Name = "txtOverdraftPermitted";
            this.txtOverdraftPermitted.Size = new System.Drawing.Size(100, 23);
            this.txtOverdraftPermitted.TabIndex = 25;
            // 
            // lblOverdraftPermitted
            // 
            this.lblOverdraftPermitted.AutoSize = true;
            this.lblOverdraftPermitted.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdraftPermitted.ForeColor = System.Drawing.Color.White;
            this.lblOverdraftPermitted.Location = new System.Drawing.Point(1155, 323);
            this.lblOverdraftPermitted.Name = "lblOverdraftPermitted";
            this.lblOverdraftPermitted.Size = new System.Drawing.Size(145, 16);
            this.lblOverdraftPermitted.TabIndex = 21;
            this.lblOverdraftPermitted.Text = "Overdraft Permitted:";
            // 
            // txtInterest
            // 
            this.txtInterest.Enabled = false;
            this.txtInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterest.Location = new System.Drawing.Point(1307, 289);
            this.txtInterest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(100, 23);
            this.txtInterest.TabIndex = 26;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.ForeColor = System.Drawing.Color.White;
            this.lblInterest.Location = new System.Drawing.Point(1239, 293);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(62, 16);
            this.lblInterest.TabIndex = 22;
            this.lblInterest.Text = "Interest:";
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(1307, 229);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 23);
            this.txtBalance.TabIndex = 27;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(1234, 229);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(68, 16);
            this.lblBalance.TabIndex = 23;
            this.lblBalance.Text = "Balance:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(1307, 260);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 28;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(1238, 260);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(62, 16);
            this.lblAmount.TabIndex = 24;
            this.lblAmount.Text = "Amount:";
            // 
            // lblCustomerAccountsList
            // 
            this.lblCustomerAccountsList.AutoSize = true;
            this.lblCustomerAccountsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAccountsList.ForeColor = System.Drawing.Color.White;
            this.lblCustomerAccountsList.Location = new System.Drawing.Point(33, 193);
            this.lblCustomerAccountsList.Name = "lblCustomerAccountsList";
            this.lblCustomerAccountsList.Size = new System.Drawing.Size(241, 25);
            this.lblCustomerAccountsList.TabIndex = 36;
            this.lblCustomerAccountsList.Text = "Customer Accounts List";
            // 
            // lsBoxCustomerAccounts
            // 
            this.lsBoxCustomerAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsBoxCustomerAccounts.FormattingEnabled = true;
            this.lsBoxCustomerAccounts.ItemHeight = 16;
            this.lsBoxCustomerAccounts.Location = new System.Drawing.Point(39, 233);
            this.lsBoxCustomerAccounts.Name = "lsBoxCustomerAccounts";
            this.lsBoxCustomerAccounts.Size = new System.Drawing.Size(1021, 164);
            this.lsBoxCustomerAccounts.TabIndex = 35;
            this.lsBoxCustomerAccounts.SelectedIndexChanged += new System.EventHandler(this.lsBoxCustomerAccounts_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // grpBoxTransfer
            // 
            this.grpBoxTransfer.Controls.Add(this.lblTransferto);
            this.grpBoxTransfer.Controls.Add(this.LblTransferFrom);
            this.grpBoxTransfer.Controls.Add(this.lblTransferAmount);
            this.grpBoxTransfer.Controls.Add(this.cmBoxTransferTo);
            this.grpBoxTransfer.Controls.Add(this.cmBoxTransferFrom);
            this.grpBoxTransfer.Controls.Add(this.txtTotalTransfer);
            this.grpBoxTransfer.Controls.Add(this.btnConfirmTransfer);
            this.grpBoxTransfer.ForeColor = System.Drawing.Color.White;
            this.grpBoxTransfer.Location = new System.Drawing.Point(39, 411);
            this.grpBoxTransfer.Name = "grpBoxTransfer";
            this.grpBoxTransfer.Size = new System.Drawing.Size(1657, 121);
            this.grpBoxTransfer.TabIndex = 38;
            this.grpBoxTransfer.TabStop = false;
            this.grpBoxTransfer.Text = "Transfer money";
            this.grpBoxTransfer.Visible = false;
            // 
            // lblTransferto
            // 
            this.lblTransferto.AutoSize = true;
            this.lblTransferto.ForeColor = System.Drawing.Color.White;
            this.lblTransferto.Location = new System.Drawing.Point(709, 53);
            this.lblTransferto.Name = "lblTransferto";
            this.lblTransferto.Size = new System.Drawing.Size(27, 16);
            this.lblTransferto.TabIndex = 1;
            this.lblTransferto.Text = "To:";
            // 
            // LblTransferFrom
            // 
            this.LblTransferFrom.AutoSize = true;
            this.LblTransferFrom.ForeColor = System.Drawing.Color.White;
            this.LblTransferFrom.Location = new System.Drawing.Point(49, 53);
            this.LblTransferFrom.Name = "LblTransferFrom";
            this.LblTransferFrom.Size = new System.Drawing.Size(41, 16);
            this.LblTransferFrom.TabIndex = 1;
            this.LblTransferFrom.Text = "From:";
            // 
            // lblTransferAmount
            // 
            this.lblTransferAmount.AutoSize = true;
            this.lblTransferAmount.ForeColor = System.Drawing.Color.White;
            this.lblTransferAmount.Location = new System.Drawing.Point(1308, 53);
            this.lblTransferAmount.Name = "lblTransferAmount";
            this.lblTransferAmount.Size = new System.Drawing.Size(48, 16);
            this.lblTransferAmount.TabIndex = 1;
            this.lblTransferAmount.Text = "Total $";
            // 
            // cmBoxTransferTo
            // 
            this.cmBoxTransferTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxTransferTo.FormattingEnabled = true;
            this.cmBoxTransferTo.Location = new System.Drawing.Point(761, 49);
            this.cmBoxTransferTo.Name = "cmBoxTransferTo";
            this.cmBoxTransferTo.Size = new System.Drawing.Size(502, 24);
            this.cmBoxTransferTo.TabIndex = 0;
            // 
            // cmBoxTransferFrom
            // 
            this.cmBoxTransferFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxTransferFrom.FormattingEnabled = true;
            this.cmBoxTransferFrom.Location = new System.Drawing.Point(122, 48);
            this.cmBoxTransferFrom.Name = "cmBoxTransferFrom";
            this.cmBoxTransferFrom.Size = new System.Drawing.Size(502, 24);
            this.cmBoxTransferFrom.TabIndex = 0;
            this.cmBoxTransferFrom.SelectedIndexChanged += new System.EventHandler(this.cmBoxTransferFrom_SelectedIndexChanged);
            // 
            // txtTotalTransfer
            // 
            this.txtTotalTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTransfer.Location = new System.Drawing.Point(1376, 49);
            this.txtTotalTransfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalTransfer.Name = "txtTotalTransfer";
            this.txtTotalTransfer.Size = new System.Drawing.Size(100, 23);
            this.txtTotalTransfer.TabIndex = 27;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDeposit.Location = new System.Drawing.Point(1135, 356);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(107, 42);
            this.btnDeposit.TabIndex = 29;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTransfer.Location = new System.Drawing.Point(1589, 356);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(107, 42);
            this.btnTransfer.TabIndex = 33;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // ManageAccouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.grpBoxTransfer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCustomerAccountsList);
            this.Controls.Add(this.lsBoxCustomerAccounts);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnAddInterest);
            this.Controls.Add(this.btnCalculateInterest);
            this.Controls.Add(this.lblTransactionHistory);
            this.Controls.Add(this.lstBoxTransactionsHistory);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdrawal);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAccouts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageAccouts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxTransfer.ResumeLayout(false);
            this.grpBoxTransfer.PerformLayout();
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
        private System.Windows.Forms.Button btnConfirmTransfer;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBoxTransfer;
        private System.Windows.Forms.Label lblTransferAmount;
        private System.Windows.Forms.ComboBox cmBoxTransferTo;
        private System.Windows.Forms.ComboBox cmBoxTransferFrom;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblTransferto;
        private System.Windows.Forms.TextBox txtTotalTransfer;
        private System.Windows.Forms.Label LblTransferFrom;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnTransfer;
    }
}