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
        readonly int minCharsToEnter = 2;

        List<Customer> customers = new List<Customer>(); //Initialise customer list so that the list box is empty on startup

        Customer selectedCustomer = new Customer();

        List<Order> ordersBySelectedCustomer = new();

        public DateTime latestOrderDateInDB = NorthwindMethods.LatestOrderDateInDB();
        public DateTime earliestOrderDateInDB = NorthwindMethods.EarliestOrderDateInDB();
        


        public CustomerForm()
        {
            InitializeComponent();
            ResetMinMaxDatesAndPickers();
        }

        private void ResetMinMaxDatesAndPickers()
        {
            earliestDatePicker.MinDate = earliestOrderDateInDB;
            earliestDatePicker.MaxDate = latestOrderDateInDB;
            earliestDatePicker.Value = earliestOrderDateInDB;

            latestDatePicker.MinDate = earliestOrderDateInDB;
            latestDatePicker.MaxDate = latestOrderDateInDB;
            latestDatePicker.Value = latestOrderDateInDB; 
        }

        private void InitializeDataGridView()
        {
            DataAccess db = new DataAccess();
            ordersBySelectedCustomer = db.GetOrdersByCustomerID(selectedCustomer.CustomerID);
            var filteredOrders = NorthwindMethods.OrdersByCustIDAndDateFilter(ordersBySelectedCustomer, selectedCustomer, earliestDatePicker.Value, latestDatePicker.Value);

            var columns = from order in filteredOrders //ordersBySelectedCustomer
                          orderby order.OrderID
                          select new 
                          {
                              OrderID = order.OrderID,
                              OrderDate = order.OrderDate,
                              ShippedDate = order.ShippedDate,
                              OrderValue = order.SumOfOrder.ToString("C"),
                          };
            ordersDataGridView.DataSource = columns.ToList();
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
            //ordersListView.Items.Clear();
            selectedCustomer = new Customer(); // So that the (data driven) orders list can be updated
                                               //A simple .clear() does not work
                                               //UpdateOrdersList();
            ordersDataGridView.DataSource = null;
            ordersDataGridView.Refresh();
            //ResetMinMaxDatesAndPickers();
        }
        private void RefreshCustomerFields()
        {
            if (customersFoundListBox.SelectedItem != null && customerNameTextBox.TextLength >= minCharsToEnter)
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

                //UpdateOrdersList();

                InitializeDataGridView();

            }
            else
            {
                MessageBox.Show("Shouldn't be seeing this");
                //customerNameHeading.Text = "";
                //contactTextBox.Text = "";
                //contactTitleTextBox.Text = "";
                //addressTextBox.Text = "";
                //cityTextBox.Text = "";
                //regionTextBox.Text = "";
                //postcodeTextBox.Text = "";
                //countryTextBox.Text = "";
                //phoneNumberTextBox.Text = "";
                //ordersToDateSQLTextBox.Text = "";
                //ordersListCustomerLabel.Text = "selected customer";
                //ordersToDateCalcTextBox.Text = "";
                ////ordersListView.Items.Clear();
                //selectedCustomer = new Customer(); // So that the (data driven) orders list can be updated
                ////A simple .clear() does not work
                ////UpdateOrdersList();
                //ordersDataGridView.DataSource = null;
                //ordersDataGridView.Refresh();
                ////ResetMinMaxDatesAndPickers();
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

            var a = 2;
            //ordersListView.View = View.Details; //Other settings added in CustomerForm.Designer.cs

            foreach (Order order in filteredOrders)
            {
                string[] row = { order.OrderID, order.OrderDate.ToString("dd/MM/yy"), order.ShippedDate.ToString("dd/MM/yy"), order.SumOfOrder.ToString("C")};
                var listViewItem = new ListViewItem(row);
                //ordersListView.Items.Add(listViewItem);
            }



        }

        private void SearchByPartialName()
        {
            ResetMinMaxDatesAndPickers();

            if (customerNameTextBox.Text.Length >1) //Needs at least two characters
            {
                DataAccess db = new NorthwindLibrary.DataAccess();
                customers = db.GetCustomers(customerNameTextBox.Text);
            }
            else
            {
                customers = null;
                selectedCustomer = null;
                ResetMinMaxDatesAndPickers();
            }
            UpdateSearchResultsList();
            RefreshCustomerFields();
        }

        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (customerNameTextBox.TextLength < minCharsToEnter)  ClearCustomerForm();
            if (customerNameTextBox.TextLength >= minCharsToEnter )  SearchByPartialName(); 
        }

        private void ClearCustomerForm()
        {
            UpdateSearchResultsList();
            ResetMinMaxDatesAndPickers();
            ClearCustomerFields();
        }

        private void CustomersFoundListBox_SelectedItemChanged(object sender, EventArgs e)
        {
            
            if (customersFoundListBox.SelectedItem != null)
            {
                selectedCustomer = (Customer)customersFoundListBox.SelectedItem;
                ResetMinMaxDatesAndPickers();
                RefreshCustomerFields();
                
                earliestDatePicker.MinDate = selectedCustomer.EarliestOrderDate;
                earliestDatePicker.Value = selectedCustomer.EarliestOrderDate; 

                latestDatePicker.MaxDate = selectedCustomer.LatestOrderDate;
                latestDatePicker.Value = selectedCustomer.LatestOrderDate;
            }

            else
            {
                ResetMinMaxDatesAndPickers();
                //selectedCustomer = new Customer();
                //ordersDataGridView.Refresh();
                //InitializeDataGridView();

            }
        }

        public void ShowPickerValues(string message)
        {
            var earlypickervalue = earliestDatePicker.Value;
            var earlypickermin = earliestDatePicker.MinDate;
            var earlypickermax = earliestDatePicker.MaxDate;
            var latestmindate = latestDatePicker.MinDate;
            var latestmaxdate = latestDatePicker.MaxDate;
            var latestpickervalue = latestDatePicker.Value;

            MessageBox.Show($"{message}\nearlypickervalue = {earliestDatePicker.Value}\nearlypickermin { earliestDatePicker.MinDate}\n earlypickermax = { earliestDatePicker.MaxDate}\nlatestmindate = { latestDatePicker.MinDate}\nlatestmaxdate = { latestDatePicker.MaxDate}\nlatestpickervalue = { latestDatePicker.Value} ");
        }
        private void EarliestDatePicker_ValueChanged(object sender, EventArgs e)
        {
            //StackTrace stackTrace = new StackTrace();
            //// Get calling method name
            //MessageBox.Show($"Earliest caller: {stackTrace.GetFrame(1).GetMethod().Name}");


            if (earliestDatePicker.Value > latestDatePicker.MinDate && customerNameTextBox.TextLength >= minCharsToEnter)
            {
                //ShowPickerValues("Earliest Picker changed, before action");

                latestDatePicker.MinDate = earliestDatePicker.Value;


                //ShowPickerValues("Earliest Picker changed, after action");
            }
            UpdateOrdersList();
            InitializeDataGridView();

        }

        private void LatestDatePicker_ValueChanged(object sender, EventArgs e)
        {
            //StackTrace stackTrace = new StackTrace();
            //// Get calling method name
            //MessageBox.Show($"Latest caller: {stackTrace.GetFrame(1).GetMethod().Name}");
            latestDatePicker.MinDate = earliestDatePicker.Value; //Shouldn't be needed. Included to fix bug on clicking dropdown for earliestdatepicker
            if (latestDatePicker.Value < earliestDatePicker.MaxDate && customerNameTextBox.TextLength >= minCharsToEnter)
            {
                //var mindate = earliestDatePicker.Value;
                //var maxdate = latestDatePicker.Value;
                //ShowPickerValues("Latest Picker changed, before action");

                earliestDatePicker.MaxDate = latestDatePicker.Value;


                //ShowPickerValues("Latest Picker changed, after action");
            }
            UpdateOrdersList();
            InitializeDataGridView();

        }

        private void ClearFiltersBbutton_Click(object sender, EventArgs e)
        {
            ResetMinMaxDatesAndPickers();
            //earliestDatePicker.MinDate = earliestOrderDateInDB;
            //earliestDatePicker.MaxDate = latestOrderDateInDB;
            //latestDatePicker.MinDate = earliestOrderDateInDB;
            //latestDatePicker.MaxDate = latestOrderDateInDB;
            //var custearliest = selectedCustomer.EarliestOrderDate;
            //var custlatest = selectedCustomer.LatestOrderDate;
            //earliestDatePicker.Value = selectedCustomer.EarliestOrderDate;
            //latestDatePicker.Value = selectedCustomer.LatestOrderDate;
            UpdateOrdersList();
            InitializeDataGridView();
        }

        private void OrdersListView_DoubleClick(object sender, EventArgs e)
        {
            //var myOrder = ordersListView.SelectedItems[0].SubItems[0];
            
            //var itemSelected = ordersListView.SelectedItems;


            //var orderID = itemSelected[0].ToString();
            ////producing "ListViewItem: {10927}"
            ////MessageBox.Show(orderID);
            //Order selectedOrder = ordersBySelectedCustomer.Where(x => x.OrderID.ToString() == orderID).Select(s => s).FirstOrDefault();
            //OrderDetailsForm orderform = new(selectedCustomer, selectedOrder);
            //orderform.ShowDialog();
        }

        private void OrdersDataGridView_DoubleClick(object sender, EventArgs e)
        {
            var selectedOrderID = "-";

            selectedOrderID = this.ordersDataGridView.CurrentRow.Cells[0].Value.ToString();

            Order selectedOrder = ordersBySelectedCustomer.Where(x => x.OrderID == selectedOrderID).FirstOrDefault();
            OrderDetailsForm orderform = new(selectedCustomer, selectedOrder); //Calls form, passing parameters
            orderform.ShowDialog(); //Opens the form, not allowing access to other form whilst open

            //foreach (DataGridViewRow row in this.ordersDataGridView.SelectedRows)
            //{
            //    Order order = row.DataBoundItem as Order;
            //    if (order != null)
            //    {
            //        selectedOrderID = order.OrderID;
            //    }
            //}
            //

            //Order selectedOrder = ordersBySelectedCustomer.Where(x => x.OrderID.ToString() == orderID).Select(s => s).FirstOrDefault();

            //Type type = ordersDataGridView.SelectedRows.GetType();
            //var selectedRows = (type)ordersDataGridView.SelectedRows[0];
            //var b = selectedRows.DataBoundItem.OrderID;
            //var selectedOrder2 = ordersDataGridView.SelectedRows;

            //var selectedOrder = (Order)ordersDataGridView.CurrentRow.DataBoundItem; 
            //var source = ordersDataGridView.DataSource;




            //var selectedID = (String)type.GetProperty("OrderID").GetValue(DataGridViewRow.DataBoundItem, null);
            //var selectedOrder = DataGridViewRow   ordersDataGridView CurrentRow.DataBoundItem.;
            //var selectedID = selectedOrder.OrderID;
            //MessageBox.Show(selectedID);


        }


    }
}
