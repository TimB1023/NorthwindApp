using Caliburn.Micro;
using NorthwindLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NorthwindWPFUI.ViewModels
{
    public class CustomerOrdersViewModel : Screen 
    {
        //======================= CONSTRUCTOR =============================
        public CustomerOrdersViewModel()
        {
            DataAccess da = new();
            Orders = new BindableCollection<Order>(da.GetTop100Orders()); //Default collection before customer selected
        }
       
        public BindableCollection<Order> Orders { get; set; }

        private Customer _selectedCustomer; 
        public Customer SelectedCustomer
        {
            get { return  _selectedCustomer; } //NWMainViewModel.SharedSelectedCustomer
            set
            {
                _selectedCustomer = value;
                MessageBox.Show("New selected customer"); // Never gets run
                NotifyOfPropertyChange(() => SelectedCustomer);
                NotifyOfPropertyChange(() => FilteredOrders);
            }
        }
        
        public BindableCollection<Order> Top100Orders
        {
            get
            {
                DataAccess da = new();
                var Orders = new BindableCollection<Order>((IEnumerable<Order>)da.GetTop100Orders());
                return Orders;
            }
                set { }
        }
        public BindableCollection<Order> FilteredOrders
        {
            get
            {
                if (SelectedCustomer != null)
                {
                    DataAccess da = new();
                    // This uses a BindableCollection function from CB to convert List<> to a bindable collection:
                    BindableCollection<Order> _filteredOrders = new BindableCollection<Order>(da.GetOrdersByCustomerID(SelectedCustomer.CustomerID));
                    var count = _filteredOrders.Count;
                    MessageBox.Show($"ID: {SelectedCustomer.CustomerID}, Orders: {count}"); //never run
                    return _filteredOrders;
                }
                else
                {
                    MessageBox.Show("Top100 (Selected Customer was null");
                    return Top100Orders;
                }
            }
            set { }
        }
        // For later
        //public DateTime latestOrderDateInDB = NorthwindMethods.LatestOrderDateInDB();
        //public DateTime earliestOrderDateInDB = NorthwindMethods.EarliestOrderDateInDB();
    }
}

