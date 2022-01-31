using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using NorthwindLibrary;
using System.ComponentModel;

namespace NorthwindWPFUI.ViewModels 
{
    public class NWMainViewModel : Conductor<object>
    {
        public BindableCollection<Customer> Customers { get; set; }
        public BindableCollection<Customer> FilteredCustomers 
        { 
            get
            {
                if (!String.IsNullOrEmpty(PartialSearchString))
                {
                    DataAccess da = new();
                    // This uses a BindableCollection function to convert List<> to a bindable collection:
                    BindableCollection<Customer> _filteredCustomers = new BindableCollection<Customer>(da.GetCustomers(PartialSearchString));
                    return _filteredCustomers;
                }
                else
                {
                    return Customers;
                }
            }
            set { } 
        }
        //======================= CONSTRUCTOR =============================
        public NWMainViewModel()
        {
            DataAccess da = new();
            Customers = new BindableCollection<Customer>(da.GetCustomers(""));
        }

        public decimal MaxRevenue
        {
            get { return NorthwindMethods.MaxRevenueByAnyCustomer(); }

        }

        private string _partialSearchString;

        public string PartialSearchString
        {
            get { return _partialSearchString; }
            set {
                _partialSearchString = value;
                NotifyOfPropertyChange(() => PartialSearchString);
                NotifyOfPropertyChange(() => FilteredCustomers);
                
            }
        }









        private Customer _selectedCustomer;
        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                NotifyOfPropertyChange(() => SelectedCustomer);
            }
        }

        //public DateTime EarliestPickerMinDate
        //{
        //    get { return _earliestPickerMinDate; }
        //    set { _earliestPickerMinDate = value; }
        //}

        //private DateTime _earliestPickerMinDate;

        //public Decimal MaxRevenueByCustomer
        //{
        //    get { return NorthwindLibrary.NorthwindMethods.MaxRevenueByAnyCustomer(); }
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


