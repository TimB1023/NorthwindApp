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
        int minCharsToEnter = 2;

        List<Customer> customers = new List<Customer>(); //Initialise customer list so that the list box is empty on startup

        Customer selectedCustomer = new Customer();

        List<Order> ordersBySelectedCustomer = new();

        public DateTime latestOrderDateInDB = NorthwindMethods.LatestOrderDateInDB();
        public DateTime earliestOrderDateInDB = NorthwindMethods.EarliestOrderDateInDB();

        public int a = 1;


        public CustomerForm()
        {
            InitializeComponent();

            UpdateSearchResultsList();
            RefreshCustomerFields();
            //Initialise orders list:

            //dataGridView1.DataSource = ordersBySelectedCustomer;

            InitializeDataGridView();

        //    ordersListView.View = View.Details; //Adds column headers
        //    ordersListView.FullRowSelect = true;
        //    ordersListView.GridLines = true;
        }

        //private void GetMinDate()
        //{
        //    DataAccess db = new NorthwindLibrary.DataAccess();
        //    var orders = db.GetOrderDates();
        //}

        private void ResetMinMaxDatesAndPickers()
        {
            earliestDatePicker.MaxDate = latestOrderDateInDB.AddDays(1);
            earliestDatePicker.MinDate = earliestOrderDateInDB.AddDays(-1);
            latestDatePicker.MinDate = earliestOrderDateInDB.AddDays(-1);
            latestDatePicker.MaxDate = latestOrderDateInDB.AddDays(1);
            earliestDatePicker.Value = earliestDatePicker.MinDate;

            latestDatePicker.Value = earliestDatePicker.MaxDate; 
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
                ResetMinMaxDatesAndPickers();
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
                UpdateSearchResultsList();
            }
            else
            {
                customers = null;
                selectedCustomer = null;
                ResetMinMaxDatesAndPickers();
                //earliestDatePicker.MaxDate = DateTime.Now.AddDays(1);
                //earliestDatePicker.MinDate = DateTime.Today.AddDays(-1);
                //earliestDatePicker.Value = DateTime.Today;
                //latestDatePicker.MaxDate = DateTime.Today.AddDays(1);
                //latestDatePicker.MinDate = DateTime.Today.AddDays(-1);
                //latestDatePicker.Value = DateTime.Now;
            }
            UpdateSearchResultsList();
            RefreshCustomerFields();
        }


        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (customerNameTextBox.TextLength<2)
            {
                ClearCustomerForm();
            }

            SearchByPartialName();
        }

        private void ClearCustomerForm()
        {
            UpdateSearchResultsList();
            ResetMinMaxDatesAndPickers();
            RefreshCustomerFields();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

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

        private void EarliestDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (latestDatePicker.Value < earliestDatePicker.Value && customerNameTextBox.TextLength >= minCharsToEnter)
            {
                latestDatePicker.MaxDate = latestOrderDateInDB;
                latestDatePicker.MinDate = earliestOrderDateInDB;
                //latestDatePicker.Value = earliestOrderDateInDB;
                var mindate = earliestDatePicker.Value;
                var latestmindate = latestDatePicker.MinDate;
                var maxdate = latestDatePicker.Value;
                var testcust = selectedCustomer;
                latestDatePicker.MinDate = earliestDatePicker.Value;
                //latestDatePicker.Value = earliestDatePicker.Value;
            
                UpdateOrdersList();
                InitializeDataGridView();
            }
        }

        private void LatestDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (latestDatePicker.Value > earliestDatePicker.Value && customerNameTextBox.TextLength >= minCharsToEnter)
            {
                var mindate = earliestDatePicker.Value;
                var maxdate = latestDatePicker.Value;

                earliestDatePicker.MaxDate = latestOrderDateInDB;
                //earliestDatePicker.Value = latestOrderDateInDB;
                earliestDatePicker.MaxDate = latestDatePicker.Value;
                //earliestDatePicker.Value = latestDatePicker.Value;
    
            
                UpdateOrdersList();
                InitializeDataGridView();
            }
        }

        private void clearFiltersBbutton_Click(object sender, EventArgs e)
        {
            ResetMinMaxDatesAndPickers();
            earliestDatePicker.MinDate = earliestOrderDateInDB;
            earliestDatePicker.MaxDate = latestOrderDateInDB;
            latestDatePicker.MinDate = earliestOrderDateInDB;
            latestDatePicker.MaxDate = latestOrderDateInDB;
            var custearliest = selectedCustomer.EarliestOrderDate;
            var custlatest = selectedCustomer.LatestOrderDate;
            earliestDatePicker.Value = selectedCustomer.EarliestOrderDate;
            latestDatePicker.Value = selectedCustomer.LatestOrderDate;
        }

        private void ordersListView_DoubleClick(object sender, EventArgs e)
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

        private void ordersDataGridView_DoubleClick(object sender, EventArgs e)
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
