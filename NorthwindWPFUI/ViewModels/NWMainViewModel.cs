using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using NorthwindLibrary;
using System.ComponentModel;
using System.Windows;


namespace NorthwindWPFUI.ViewModels 
{
    public class NWMainViewModel : Conductor<object>
    {
        //======================= CONSTRUCTOR =============================
        public NWMainViewModel()
        {
            DataAccess da = new();
            Customers = new BindableCollection<Customer>(da.GetCustomers(""));
            //CustomerOrdersViewModel = new CustomerOrdersViewModel(); //Works in constructor, not in prop set for SelectedCustomer below
        }
        public CustomerOrdersViewModel CustomerOrdersViewModel { get; set; } //Not sure any more why I need this
        //====================== Methods ================
        private async Task LoadNewOrdersListAsync()
        {
            await ActivateItemAsync(new CustomerOrdersViewModel(SelectedCustomer));
        }
        //===================== Full Properties ===============
        private Customer _selectedCustomer;
        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                NotifyOfPropertyChange(() => SelectedCustomer);
                NotifyOfPropertyChange(() => CustomerOrdersViewModel.SelectedCustomer); //Does nothing, but generates error if the VM has not been instatiated in the constructor
               
                //MessageBox.Show("Customer Selected"); //Proves that this is run when expected
                LoadNewOrdersListAsync();
                //CustomerOrdersViewModel = new CustomerOrdersViewModel(); //Does nothing
            }
        }
        public BindableCollection<Customer> Customers { get; set; }
        public BindableCollection<Customer> FilteredCustomers
        {
            get
            {
                if (!String.IsNullOrEmpty(PartialSearchString))
                {
                    DataAccess da = new();
                    // This uses a BindableCollection function from CB to convert List<> to a bindable collection:
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
        public decimal MaxRevenue
        {
            get { return NorthwindMethods.MaxRevenueByAnyCustomer(); }
        }
        private string _partialSearchString;
        public string PartialSearchString
        {
            get { return _partialSearchString; }
            set
            {
                _partialSearchString = value;
                NotifyOfPropertyChange(() => PartialSearchString);
                NotifyOfPropertyChange(() => FilteredCustomers);
            }
        }
    }
}


