namespace BankingApp_20210884
{
    partial class SelectCurstomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCurstomerForm));
            this.lblSelecctCustomer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbBoxCustomers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelecctCustomer
            // 
            this.lblSelecctCustomer.AutoSize = true;
            this.lblSelecctCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecctCustomer.ForeColor = System.Drawing.Color.White;
            this.lblSelecctCustomer.Location = new System.Drawing.Point(250, 106);
            this.lblSelecctCustomer.Name = "lblSelecctCustomer";
            this.lblSelecctCustomer.Size = new System.Drawing.Size(378, 25);
            this.lblSelecctCustomer.TabIndex = 0;
            this.lblSelecctCustomer.Text = "Please select customer from list below";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // cmbBoxCustomers
            // 
            this.cmbBoxCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxCustomers.FormattingEnabled = true;
            this.cmbBoxCustomers.Location = new System.Drawing.Point(253, 145);
            this.cmbBoxCustomers.Name = "cmbBoxCustomers";
            this.cmbBoxCustomers.Size = new System.Drawing.Size(719, 24);
            this.cmbBoxCustomers.TabIndex = 21;
            this.cmbBoxCustomers.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCustomers_SelectedIndexChanged);
            // 
            // SelectCurstomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1123, 333);
            this.Controls.Add(this.cmbBoxCustomers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSelecctCustomer);
            this.Name = "SelectCurstomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectCurstomerForm";
            this.Load += new System.EventHandler(this.SelectCurstomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelecctCustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbBoxCustomers;
    }
}