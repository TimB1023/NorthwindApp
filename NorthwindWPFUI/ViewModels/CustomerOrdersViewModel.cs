using Caliburn.Micro;
using NorthwindLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWPFUI.ViewModels
{
    public class CustomerOrdersViewModel : Screen
    {
        public DateTime latestOrderDateInDB = NorthwindMethods.LatestOrderDateInDB();
        public DateTime earliestOrderDateInDB = NorthwindMethods.EarliestOrderDateInDB();

        //List<Order> ordersBySelectedCustomer = new();

        //public Customer MySelectedCustomer { get; set; }

        //MySelectedCustomer = 

        //public BindableCollection <Order> SelectedCustomerOrders
        //    if (MySelectedCustomer==null)
            
        //    = new BindableCollection<Order>(da.GetOrdersByCustomerID(SelectedCustomer.CustomerID));

        // if (SelectedCustomer !=null)
        //    {
        //        BindableCollection<Order> ordersBySelectedCustomer = new BindableCollection<Order>(da.GetOrdersByCustomerID(SelectedCustomer.CustomerID));

        //======================= CONSTRUCTOR =============================
        public CustomerOrdersViewModel(Customer SelectedCustomer)
        {
            DataAccess da = new();
            //BindableCollection<Order> AllOrders = new BindableCollection<Order>(da.GetOrdersByCustomerID(SelectedCustomer.CustomerID));
            //var MySelectedCustomer = SelectedCustomer;
        }



    }


    // This uses a BindableCollection function to convert List<> to a bindable collection:
    //BindableCollection<Customer> _filteredCustomers = new BindableCollection<Customer>(da.GetCustomers(PartialSearchString));
}

