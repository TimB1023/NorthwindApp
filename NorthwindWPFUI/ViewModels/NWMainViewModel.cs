using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using NorthwindLibrary;

namespace NorthwindWPFUI.ViewModels
{
    public class NWMainViewModel
    {
        public BindableCollection<Customer> Customers { get; set; }


        public NWMainViewModel()
        {
            DataAccess da = new();
            Customers = new BindableCollection<Customer>(da.GetCustomers(""));
        }

        private Customer _selectedCustomer;

        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set { _selectedCustomer = value; }
        }


        //private DateTime _earliestPickerMinDate;

        //public Decimal MaxRevenueByCustomer
        //{
        //    get { return NorthwindLibrary.NorthwindMethods.MaxRevenueByAnyCustomer(); }
        //}

        public Decimal MyDecimal
        {
            get { return 20; }
        }


        public decimal MaxRevenue
        {
            get { return NorthwindMethods.MaxRevenueByAnyCustomer(); }

        }



        //public DateTime EarliestPickerMinDate
        //{
        //    get { return _earliestPickerMinDate; }
        //    set { _earliestPickerMinDate = value; }
        //}





        // ///////////////////// Form interaction methods /////////////////////
        //private void CustomerNameTextBox_TextChanged(object sender, EventArgs e) // User entry in cust search box
        //{
        //    if (customerNameTextBox.TextLength < minCharsToEnter) ClearCustomerForm();
        //    if (customerNameTextBox.TextLength >= minCharsToEnter) FindCustomersByPartialName();
        //}
        //private void CustomersFoundListBox_SelectedItemChanged(object sender, EventArgs e) // User clicks on entry in customer list
        //{
        //    if (customersFoundListBox.SelectedItem != null)
        //    {
        //        selectedCustomer = (Customer)customersFoundListBox.SelectedItem;
        //        ResetMinMaxDatesAndPickersToDBLimits();
        //        RefreshCustomerFields();
        //        ResetMinMaxDatesAndPickersToCustLimits();
        //    }
        //    else
        //    {
        //        ClearCustomerForm();
        //    }
        //}
        //private void EarliestDatePicker_ValueChanged(object sender, EventArgs e)
        //{
        //    latestDatePicker.MinDate = earliestDatePicker.Value;
        //    UpdateOrdersList();
        //    PopulateOrdersDataGridView();
        //    earlyFilterIconPictureBox.Visible = true;
        //    clearFilterPictureBox.Visible = true;
        //}
        //private void LatestDatePicker_ValueChanged(object sender, EventArgs e)
        //{
        //    earliestDatePicker.MaxDate = latestDatePicker.Value;
        //    UpdateOrdersList();
        //    PopulateOrdersDataGridView();
        //    lateFilterIconPictureBox.Visible = true;
        //    clearFilterPictureBox.Visible = true;
        //}
        //private void OrdersDataGridView_DoubleClick(object sender, EventArgs e) // View order details
        //{
        //    var selectedOrderID = "-";

        //    selectedOrderID = this.ordersDataGridView.CurrentRow.Cells[0].Value.ToString();

        //    Order selectedOrder = ordersBySelectedCustomer.Where(x => x.OrderID == selectedOrderID).FirstOrDefault();
        //    OrderDetailsForm orderform = new(selectedCustomer, selectedOrder); //Calls form, passing parameters
        //    orderform.ShowDialog(); //Opens the form, not allowing access to other form whilst open
        //}
        //private void ShowAllCustomersButton_Click(object sender, EventArgs e)
        //{
        //    customerNameTextBox.Text = "%%";
        //    // CustomerNameTextBox_TextChanged() takes care of the everything else
        //}
        //private void newCLearFilterPictureBox_Click(object sender, EventArgs e)
        //{
        //    ResetMinMaxDatesAndPickersToCustLimits();
        //    UpdateOrdersList();
        //    PopulateOrdersDataGridView();
        //    clearFilterPictureBox.Visible = false;

        /////////////////////////////////////////////
    }


}


