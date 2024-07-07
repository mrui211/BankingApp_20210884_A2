using System;
using System.Windows.Forms;

namespace BankingApp_20210884
{
    public partial class SelectCurstomerForm : Form
    {
        Customer c;
        string filenameCustomerData = "customer.dat";
        public SelectCurstomerForm()
        {
            InitializeComponent();
        }

        private void SelectCurstomerForm_Load(object sender, EventArgs e)
        {
            refreshCmbBoxClientes();
        }

        private void refreshCmbBoxClientes()
        {
            cmbBoxCustomers.Items.Clear();
            LstCustomers.Clientes = PersistenceData.DeserializeFromXmlFile<Customer>(filenameCustomerData);

            if (LstCustomers.Clientes.Count == 0)
            {
                cmbBoxCustomers.Text = "No customers registered.";
                return;
            }
            else
                cmbBoxCustomers.Text = "Select a customer from the list.";


            foreach (var cliente in LstCustomers.Clientes)
            {
                //cmbBoxCustomers.Items.Add(cliente.Name + " " + cliente.ContactDetails);
                //cmbBoxCustomers.Items.Add($"{cliente.Name} - {cliente.ContactDetails}");
                cmbBoxCustomers.Items.Add(cliente);
            }


        }

        private void cmbBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {           
            //if (c == null)
            if (cmbBoxCustomers.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer from the list of customers");
                return;
            }
            else
            {
                c = (Customer)cmbBoxCustomers.SelectedItem;
                ManageAccouts ma = new ManageAccouts();
                ma.setCustomer(c);
                ma.Show();
            }
        }
    }
}
