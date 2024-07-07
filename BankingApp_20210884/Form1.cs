using System;
using System.Windows.Forms;

namespace BankingApp_20210884
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ManageCustomers mc = new ManageCustomers();
            mc.Show();
        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            SelectCurstomerForm sc = new SelectCurstomerForm();
            sc.Show();
        }
    }
}
