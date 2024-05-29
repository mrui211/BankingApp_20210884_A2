namespace BankingApp_20210884
{
    partial class ManageCustomers
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
            this.chkBoxCustomerBankStaff = new System.Windows.Forms.CheckBox();
            this.txtCustomerContactDetails = new System.Windows.Forms.TextBox();
            this.lblCustomerContactDetails = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lsBoxCustomers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCustomerAccountsList = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lsBoxCustomerAccounts = new System.Windows.Forms.ListBox();
            this.cmboxAccountType = new System.Windows.Forms.ComboBox();
            this.lblSelectAccount = new System.Windows.Forms.Label();
            this.lblCustomersList = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkBoxCustomerBankStaff
            // 
            this.chkBoxCustomerBankStaff.AutoSize = true;
            this.chkBoxCustomerBankStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxCustomerBankStaff.Location = new System.Drawing.Point(173, 297);
            this.chkBoxCustomerBankStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBoxCustomerBankStaff.Name = "chkBoxCustomerBankStaff";
            this.chkBoxCustomerBankStaff.Size = new System.Drawing.Size(105, 21);
            this.chkBoxCustomerBankStaff.TabIndex = 4;
            this.chkBoxCustomerBankStaff.Text = "Bank Staff";
            this.chkBoxCustomerBankStaff.UseVisualStyleBackColor = true;
            // 
            // txtCustomerContactDetails
            // 
            this.txtCustomerContactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerContactDetails.Location = new System.Drawing.Point(173, 248);
            this.txtCustomerContactDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerContactDetails.Name = "txtCustomerContactDetails";
            this.txtCustomerContactDetails.Size = new System.Drawing.Size(161, 23);
            this.txtCustomerContactDetails.TabIndex = 3;
            // 
            // lblCustomerContactDetails
            // 
            this.lblCustomerContactDetails.AutoSize = true;
            this.lblCustomerContactDetails.Location = new System.Drawing.Point(58, 252);
            this.lblCustomerContactDetails.Name = "lblCustomerContactDetails";
            this.lblCustomerContactDetails.Size = new System.Drawing.Size(100, 16);
            this.lblCustomerContactDetails.TabIndex = 3;
            this.lblCustomerContactDetails.Text = "Contact Details:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(173, 195);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 23);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(123, 199);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(47, 16);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customer Information";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(168, 347);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(93, 35);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(301, 347);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 35);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(431, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 35);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lsBoxCustomers
            // 
            this.lsBoxCustomers.FormattingEnabled = true;
            this.lsBoxCustomers.ItemHeight = 16;
            this.lsBoxCustomers.Location = new System.Drawing.Point(698, 170);
            this.lsBoxCustomers.Name = "lsBoxCustomers";
            this.lsBoxCustomers.Size = new System.Drawing.Size(768, 244);
            this.lsBoxCustomers.TabIndex = 12;
            this.lsBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.lsBoxCustomers_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCustomerAccountsList);
            this.groupBox1.Controls.Add(this.btnAddAccount);
            this.groupBox1.Controls.Add(this.txtDeposit);
            this.groupBox1.Controls.Add(this.lblDeposit);
            this.groupBox1.Controls.Add(this.lsBoxCustomerAccounts);
            this.groupBox1.Controls.Add(this.cmboxAccountType);
            this.groupBox1.Controls.Add(this.lblSelectAccount);
            this.groupBox1.Location = new System.Drawing.Point(165, 501);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1454, 267);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Account Details";
            // 
            // lblCustomerAccountsList
            // 
            this.lblCustomerAccountsList.AutoSize = true;
            this.lblCustomerAccountsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAccountsList.Location = new System.Drawing.Point(342, 18);
            this.lblCustomerAccountsList.Name = "lblCustomerAccountsList";
            this.lblCustomerAccountsList.Size = new System.Drawing.Size(241, 25);
            this.lblCustomerAccountsList.TabIndex = 15;
            this.lblCustomerAccountsList.Text = "Customer Accounts List";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(122, 139);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(107, 36);
            this.btnAddAccount.TabIndex = 8;
            this.btnAddAccount.Text = "Create Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(122, 100);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(100, 22);
            this.txtDeposit.TabIndex = 7;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(64, 106);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(54, 16);
            this.lblDeposit.TabIndex = 6;
            this.lblDeposit.Text = "Deposit";
            // 
            // lsBoxCustomerAccounts
            // 
            this.lsBoxCustomerAccounts.FormattingEnabled = true;
            this.lsBoxCustomerAccounts.ItemHeight = 16;
            this.lsBoxCustomerAccounts.Location = new System.Drawing.Point(345, 60);
            this.lsBoxCustomerAccounts.Name = "lsBoxCustomerAccounts";
            this.lsBoxCustomerAccounts.Size = new System.Drawing.Size(956, 196);
            this.lsBoxCustomerAccounts.TabIndex = 5;
            // 
            // cmboxAccountType
            // 
            this.cmboxAccountType.FormattingEnabled = true;
            this.cmboxAccountType.Location = new System.Drawing.Point(122, 51);
            this.cmboxAccountType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmboxAccountType.Name = "cmboxAccountType";
            this.cmboxAccountType.Size = new System.Drawing.Size(185, 24);
            this.cmboxAccountType.TabIndex = 4;
            // 
            // lblSelectAccount
            // 
            this.lblSelectAccount.AutoSize = true;
            this.lblSelectAccount.Location = new System.Drawing.Point(23, 54);
            this.lblSelectAccount.Name = "lblSelectAccount";
            this.lblSelectAccount.Size = new System.Drawing.Size(93, 16);
            this.lblSelectAccount.TabIndex = 3;
            this.lblSelectAccount.Text = "Account Type:";
            // 
            // lblCustomersList
            // 
            this.lblCustomersList.AutoSize = true;
            this.lblCustomersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersList.Location = new System.Drawing.Point(695, 123);
            this.lblCustomersList.Name = "lblCustomersList";
            this.lblCustomersList.Size = new System.Drawing.Size(180, 25);
            this.lblCustomersList.TabIndex = 14;
            this.lblCustomersList.Text = "List of Customers";
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 780);
            this.Controls.Add(this.lblCustomersList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsBoxCustomers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBoxCustomerBankStaff);
            this.Controls.Add(this.txtCustomerContactDetails);
            this.Controls.Add(this.lblCustomerContactDetails);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "ManageCustomers";
            this.Text = "Manage Customers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBoxCustomerBankStaff;
        private System.Windows.Forms.TextBox txtCustomerContactDetails;
        private System.Windows.Forms.Label lblCustomerContactDetails;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lsBoxCustomers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmboxAccountType;
        private System.Windows.Forms.Label lblSelectAccount;
        private System.Windows.Forms.ListBox lsBoxCustomerAccounts;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblCustomerAccountsList;
        private System.Windows.Forms.Label lblCustomersList;
    }
}