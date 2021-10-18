using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindLibrary;


namespace NorthwindUI
{
    public partial class CustomerForm : Form
    {
        List<Customer> customers = new List<Customer>(); //Initialise customer list so that the list box is empty on startup
        public CustomerForm()
        {
            InitializeComponent();
            updateSearchResultsList();
        }

        private void updateSearchResultsList()
        {
            //DataAccess db = new DataAccess();
            //customers = db.GetCustomers(customerNameTextBox.Text);
            customersFoundListBox.DataSource = customers;
            customersFoundListBox.DisplayMember = "customerDisplayName"; //Defined in Customer class
        }

        private void searchByPartialName()
        {
            if (customerNameTextBox.Text.Length >1) //Needs at least two characters
            {
                DataAccess db = new NorthwindLibrary.DataAccess();
                customers = db.GetCustomers(customerNameTextBox.Text);
                updateSearchResultsList();
            }
        }

        //private void searchButtom_Click(object sender, EventArgs e)
        //{
        //    searchByPartialName();
        //}

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            searchByPartialName();
        }
    }
}
