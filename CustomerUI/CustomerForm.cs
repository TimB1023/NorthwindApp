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
            UpdateSearchResultsList();
            RefreshCustomerFields();
            //Initialise orders list:
            ordersListView.View = View.Details; //Adds column headers
            ordersListView.FullRowSelect = true;
            ordersListView.GridLines = true;
        }

        private void RefreshCustomerFields()
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

                

                ordersToDateCalcTextBox.Text = NorthwindMethods.SumOfOrdersByCustomerID(selectedCustomer.CustomerID).ToString("C");

                earliestDatePicker.MinDate = selectedCustomer.EarliestOrderDate;
                earliestDatePicker.MaxDate = selectedCustomer.LatestOrderDate;

                latestDatePicker.MinDate = selectedCustomer.EarliestOrderDate;
                latestDatePicker.MaxDate = selectedCustomer.LatestOrderDate;

                earliestDatePicker.Value = selectedCustomer.EarliestOrderDate;
                latestDatePicker.Value = selectedCustomer.LatestOrderDate;

                UpdateOrdersList();

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
                earliestDatePicker.Value = DateTime.Today;
                latestDatePicker.Value = DateTime.Today;
            }
        }
        private void UpdateSearchResultsList()
        {
            //DataAccess db = new DataAccess();
            //customers = db.GetCustomers(customerNameTextBox.Text);
            customersFoundListBox.DataSource = customers;
            customersFoundListBox.DisplayMember = "customerDisplayName"; //Defined in Customer class
        }
        private void UpdateOrdersList()
        {
            DataAccess db = new DataAccess();
            ordersBySelectedCustomer = db.GetOrdersByCustomerID (selectedCustomer.CustomerID);
            var filteredOrders = NorthwindMethods.OrdersByCustIDAndDateFilter(ordersBySelectedCustomer, selectedCustomer, earliestDatePicker.Value, latestDatePicker.Value);

            ordersListView.Items.Clear();

            ordersListView.View = View.Details; //Other settings added in CustomerForm.Designer.cs

            foreach (Order order in filteredOrders)
            {
                string[] row = { order.OrderID, order.OrderDate.ToString("dd/MM/yy"), order.ShippedDate.ToString("dd/MM/yy"), order.SumOfOrder.ToString("C")};
                var listViewItem = new ListViewItem(row);
                ordersListView.Items.Add(listViewItem);
            }

        }

        private void SearchByPartialName()
        {
            if (customerNameTextBox.Text.Length >1) //Needs at least two characters
            {
                DataAccess db = new NorthwindLibrary.DataAccess();
                customers = db.GetCustomers(customerNameTextBox.Text);
                UpdateSearchResultsList();
            }
            else
            {
                customers = null;
                selectedCustomer = null;
            }
            UpdateSearchResultsList();
            RefreshCustomerFields();
        }

        //private void searchButtom_Click(object sender, EventArgs e)
        //{
        //    searchByPartialName();
        //}

        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchByPartialName();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void CustomersFoundListBox_SelectedItemChanged(object sender, EventArgs e)
        {
            
            if (customersFoundListBox.SelectedItem != null)
            {
                selectedCustomer = (Customer)customersFoundListBox.SelectedItem;
                RefreshCustomerFields();
            }
            earliestDatePicker.Value = selectedCustomer.EarliestOrderDate;
            latestDatePicker.Value = selectedCustomer.LatestOrderDate;

        }

        private void EarliestDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (latestDatePicker.Value < earliestDatePicker.Value)
            { 
                latestDatePicker.Value = earliestDatePicker.Value;
            }
            latestDatePicker.MinDate = earliestDatePicker.Value;
            UpdateOrdersList();
        }

        private void LatestDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (latestDatePicker.Value > earliestDatePicker.Value)
            {
                earliestDatePicker.Value = latestDatePicker.MinDate;
            }
            earliestDatePicker.Value = latestDatePicker.Value;
            UpdateOrdersList();
        }
    }
}
