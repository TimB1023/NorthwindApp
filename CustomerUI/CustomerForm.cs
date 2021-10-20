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
        
        Customer selectedCustomer = new Customer();

        List<Order> ordersBySelectedCustomer = new();

        

        public CustomerForm()
        {
            InitializeComponent();
            updateSearchResultsList();
            refreshCustomerFields();
            //Initialise orders list:
            ordersListView.View = View.Details; //Adds column headers
            ordersListView.FullRowSelect = true;
            ordersListView.GridLines = true;
        }

        private void refreshCustomerFields()
        {
            if (customersFoundListBox.SelectedItem != null)
            {
                customerNameHeading.Text = selectedCustomer.customerDisplayName;
                contactTextBox.Text = selectedCustomer.ContactName;
                contactTitleTextBox.Text = selectedCustomer.ContactTitle;
                addressTextBox.Text = selectedCustomer.Address;
                cityTextBox.Text = selectedCustomer.City;
                regionTextBox.Text = selectedCustomer.Region;
                postcodeTextBox.Text = selectedCustomer.PostalCode;
                countryTextBox.Text = selectedCustomer.Country;
                phoneNumberTextBox.Text = selectedCustomer.Phone;

                DataAccess db = new NorthwindLibrary.DataAccess();
                selectedCustomer.OrdersToDate = db.GetSumOfOrdersByCustomerID(selectedCustomer.CustomerID);
                ordersToDateSQLTextBox.Text = selectedCustomer.OrdersToDate.ToString("C");

                ordersListCustomerLabel.Text = selectedCustomer.customerDisplayName;

                updateOrdersList();
                ordersToDateCalcTextBox.Text = NorthwindMethods.SumOfOrdersByCustomerID(selectedCustomer.CustomerID).ToString("C");

            }
            else
            {
                customerNameHeading.Text = "";
                contactTextBox.Text = "";
                contactTitleTextBox.Text = "";
                addressTextBox.Text = "";
                cityTextBox.Text = "";
                regionTextBox.Text = "";
                postcodeTextBox.Text = "";
                countryTextBox.Text = "";
                phoneNumberTextBox.Text = "";
                ordersToDateSQLTextBox.Text = "";
                ordersListCustomerLabel.Text = "selected customer";
                ordersToDateCalcTextBox.Text = "";
                ordersListView.Items.Clear();
            }
        }
        private void updateSearchResultsList()
        {
            //DataAccess db = new DataAccess();
            //customers = db.GetCustomers(customerNameTextBox.Text);
            customersFoundListBox.DataSource = customers;
            customersFoundListBox.DisplayMember = "customerDisplayName"; //Defined in Customer class
        }
        private void updateOrdersList()
        {
            DataAccess db = new DataAccess();
            ordersBySelectedCustomer = db.GetOrdersByCustomerID (selectedCustomer.CustomerID);

            ordersListView.Items.Clear();

            ordersListView.View = View.Details; //Other settings added in CustomerForm.Designer.cs

            foreach (Order order in ordersBySelectedCustomer)
            {
                string[] row = { order.OrderID, order.ProductName, order.ProductID, order.UnitPrice.ToString("C"), order.ExtendedPrice.ToString("C") };
                var listViewItem = new ListViewItem(row);
                ordersListView.Items.Add(listViewItem);
            }

        }

        private void searchByPartialName()
        {
            if (customerNameTextBox.Text.Length >1) //Needs at least two characters
            {
                DataAccess db = new NorthwindLibrary.DataAccess();
                customers = db.GetCustomers(customerNameTextBox.Text);
                updateSearchResultsList();
            }
            else
            {
                customers = null;
                selectedCustomer = null;
            }
            updateSearchResultsList();
            refreshCustomerFields();
        }

        //private void searchButtom_Click(object sender, EventArgs e)
        //{
        //    searchByPartialName();
        //}

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            searchByPartialName();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void customersFoundListBox_SelectedItemChanged(object sender, EventArgs e)
        {
            
            if (customersFoundListBox.SelectedItem != null)
            {
                selectedCustomer = (Customer)customersFoundListBox.SelectedItem;
                refreshCustomerFields();
            }
        }
    }
}
