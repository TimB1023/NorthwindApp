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
using System.Diagnostics;



namespace NorthwindUI
{
    public partial class CustomerForm : Form
    {
        readonly int minCharsToEnter = 2; //User must enter at least 2 characters of customer name
        //Instatiate classes
        List<Customer> customers = new List<Customer>();

        Customer selectedCustomer = new Customer();
        List<Order> ordersBySelectedCustomer = new();

        

        //Set limits for date filters. Assumes static db
        public DateTime latestOrderDateInDB = NorthwindMethods.LatestOrderDateInDB();
        public DateTime earliestOrderDateInDB = NorthwindMethods.EarliestOrderDateInDB();
        
        public CustomerForm()
        {
            InitializeComponent(); //Winforms stuff, generated automatically
            ResetMinMaxDatesAndPickersToDBLimits();
        } // Initiates Form

        // ////////////////// General Methods ////////////////////////
        private void ResetMinMaxDatesAndPickersToDBLimits()
        {
            earliestDatePicker.MinDate = earliestOrderDateInDB;
            earliestDatePicker.MaxDate = latestOrderDateInDB;
            earliestDatePicker.Value = earliestOrderDateInDB;

            latestDatePicker.MinDate = earliestOrderDateInDB;
            latestDatePicker.MaxDate = latestOrderDateInDB;
            latestDatePicker.Value = latestOrderDateInDB;

            earlyFilterIconPictureBox.Visible = false;
            lateFilterIconPictureBox.Visible = false;
            clearFilterPictureBox.Visible = false;
        }
        private void ResetMinMaxDatesAndPickersToCustLimits()
        {
            if (customerNameTextBox.TextLength >= minCharsToEnter) //Ignored if there is no selected customer
            {
                earliestDatePicker.MinDate = selectedCustomer.EarliestOrderDate;
                earliestDatePicker.MaxDate = selectedCustomer.LatestOrderDate;
                earliestDatePicker.Value = selectedCustomer.EarliestOrderDate;
                latestDatePicker.MinDate = selectedCustomer.EarliestOrderDate;
                latestDatePicker.MaxDate = selectedCustomer.LatestOrderDate;
                latestDatePicker.Value = selectedCustomer.LatestOrderDate;
            }

            earlyFilterIconPictureBox.Visible = false;
            lateFilterIconPictureBox.Visible = false;
            clearFilterPictureBox.Visible = false;
        }
        private void ClearCustomerFields()
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
            selectedCustomer = new Customer(); // So that the (data driven) orders list can be updated
            ordersDataGridView.DataSource = null;
            ordersDataGridView.Refresh();
        }
        private void RefreshCustomerFields() // Including list of orders in grid
        {
            if (customersFoundListBox.SelectedItem != null && customerNameTextBox.TextLength >= minCharsToEnter) // iff there is a valid entry in the search box
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

                // Sum of customer orders using stored procedure
                DataAccess db = new NorthwindLibrary.DataAccess();
                selectedCustomer.OrdersToDate = db.GetSumOfOrdersByCustomerID(selectedCustomer.CustomerID);
                ordersToDateSQLTextBox.Text = selectedCustomer.OrdersToDate.ToString("C");

                // Sum of customer orders using method in library
                ordersToDateCalcTextBox.Text = NorthwindMethods.SumOfOrdersByCustomerID(selectedCustomer.CustomerID).ToString("C");

                ordersListCustomerLabel.Text = selectedCustomer.customerDisplayName; // For orders grid

                ResetMinMaxDatesAndPickersToCustLimits();

                PopulateDataGridView();

            }
            else // No customers found based on user entry
            {
                ClearCustomerFields();
                MessageBox.Show("No valid entries, please try again");
            }
        }
        private void UpdateCustomerSearchResultsList() // Lists customers from user entry in search box
        {
            if (customerNameTextBox.TextLength >= minCharsToEnter)
            {
                customersFoundListBox.DataSource = customers;
                customersFoundListBox.DisplayMember = "customerDisplayName"; //Defined in Customer class
            }
            else // Clear customer list
            {
                customers = new List<Customer>();
                customersFoundListBox.DataSource = customers;
            }
        }
        private void UpdateOrdersList() // Filtered by date pickers
        {
            DataAccess db = new DataAccess();
            ordersBySelectedCustomer = db.GetOrdersByCustomerID (selectedCustomer.CustomerID);
            (var filteredOrders, var minDate, var maxDate) = NorthwindMethods.OrdersByCustIDAndDateFilter(ordersBySelectedCustomer, selectedCustomer, earliestDatePicker.Value, latestDatePicker.Value);

            foreach (Order order in filteredOrders)
            {
                string[] row = { order.OrderID, order.OrderDate.ToString("dd/MM/yy"), order.ShippedDate.ToString("dd/MM/yy"), order.SumOfOrder.ToString("C")};
                //var listViewItem = new ListViewItem(row);
            }
            // Ensures that there are never no orders in the list:
            if (earliestDatePicker.MaxDate >maxDate) 
            {
                earliestDatePicker.MaxDate = maxDate;
            }

            if (latestDatePicker.MinDate < minDate)
            {
                latestDatePicker.MinDate = minDate;
            }

        }
        private void PopulateDataGridView() // Fills grid with orders from selected customer
        {
            DataAccess db = new(); //db Must be instatiated to get data
            ordersBySelectedCustomer = db.GetOrdersByCustomerID(selectedCustomer.CustomerID); //list <order>

            (List<Order> filteredOrders, DateTime minDate, DateTime maxDate) = NorthwindMethods.OrdersByCustIDAndDateFilter(ordersBySelectedCustomer, selectedCustomer, earliestDatePicker.Value, latestDatePicker.Value);
            // My< first tuple!

            var columns = from order in filteredOrders //ordersBySelectedCustomer, selectes which data to show in grid
                          orderby order.OrderID
                          select new
                          {
                              OrderID = order.OrderID,
                              OrderDate = order.OrderDate,
                              ShippedDate = order.ShippedDate,
                              OrderValue = order.SumOfOrder.ToString("C"), // Calculated in Methods library
                          };
            ordersDataGridView.DataSource = columns.ToList();

            if(filteredOrders.Count >=1)
            {

                //MessageBox.Show($"{minDate} - {maxDate}");
            }
        }
        private void FindCustomersByPartialName() // And populate customer list and fields for selected customer (1st by default)
        {
            ResetMinMaxDatesAndPickersToDBLimits();

            if (customerNameTextBox.Text.Length >= minCharsToEnter) // Needs a minimum number of characters to start search
            {
                DataAccess db = new();
                customers = db.GetCustomers(customerNameTextBox.Text);
            }
            else
            {
                //customers = null;
                //selectedCustomer = null;
                ResetMinMaxDatesAndPickersToDBLimits(); // Added in case user has hit backspace to get < min chars

            }
            UpdateCustomerSearchResultsList();
            RefreshCustomerFields();
        }
        private void ClearCustomerForm()
        {
            UpdateCustomerSearchResultsList();
            ResetMinMaxDatesAndPickersToDBLimits();
            ClearCustomerFields();
        }



        // ///////////////////// Form interaction methods /////////////////////
        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e) // User entry in cust search box
        {
            if (customerNameTextBox.TextLength < minCharsToEnter) ClearCustomerForm();
            if (customerNameTextBox.TextLength >= minCharsToEnter) FindCustomersByPartialName();
        }
        private void CustomersFoundListBox_SelectedItemChanged(object sender, EventArgs e) // User clicks on entry in customer list
        {
            if (customersFoundListBox.SelectedItem != null)
            {
                selectedCustomer = (Customer)customersFoundListBox.SelectedItem;
                ResetMinMaxDatesAndPickersToDBLimits();
                RefreshCustomerFields();
                ResetMinMaxDatesAndPickersToCustLimits();
            }
            else
            {
                ClearCustomerForm();
            }
        }
        private void EarliestDatePicker_ValueChanged(object sender, EventArgs e)
        {
            latestDatePicker.MinDate = earliestDatePicker.Value;
            UpdateOrdersList();
            PopulateDataGridView();
            earlyFilterIconPictureBox.Visible=true;
            clearFilterPictureBox.Visible = true;
        }
        private void LatestDatePicker_ValueChanged(object sender, EventArgs e)
        {
            earliestDatePicker.MaxDate = latestDatePicker.Value;
            UpdateOrdersList();
            PopulateDataGridView();
            lateFilterIconPictureBox.Visible = true;
            clearFilterPictureBox.Visible = true;
        }
        private void OrdersDataGridView_DoubleClick(object sender, EventArgs e) // View order details
        {
            var selectedOrderID = "-";

            selectedOrderID = this.ordersDataGridView.CurrentRow.Cells[0].Value.ToString();

            Order selectedOrder = ordersBySelectedCustomer.Where(x => x.OrderID == selectedOrderID).FirstOrDefault();
            OrderDetailsForm orderform = new(selectedCustomer, selectedOrder); //Calls form, passing parameters
            orderform.ShowDialog(); //Opens the form, not allowing access to other form whilst open
        }
        private void ShowAllCustomersButton_Click(object sender, EventArgs e)
        {
            customerNameTextBox.Text = "%%";
            // CustomerNameTextBox_TextChanged() takes care of the everything else
        }

        private void newCLearFilterPictureBox_Click(object sender, EventArgs e)
        {
            ResetMinMaxDatesAndPickersToCustLimits();
            UpdateOrdersList();
            PopulateDataGridView();
            clearFilterPictureBox.Visible = false;
        }
    }
}
