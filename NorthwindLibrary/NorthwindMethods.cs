using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLibrary
{
    public class NorthwindMethods
    {
        
        public static decimal SumOfOrdersByCustomerID(string CustomerID)
        {
            List<Order> selectedCustomerOrders = new();
            decimal sumOfOrders = 0;

            DataAccess db = new NorthwindLibrary.DataAccess();
            selectedCustomerOrders = db.GetOrdersByCustomerID(CustomerID).ToList();

            //Old version
            //foreach(Order order in selectedCustomerOrders)
            //{
            //    sumOfOrders += order.ExtendedPrice;
            //}
            sumOfOrders = selectedCustomerOrders.Sum(x => x.ExtendedPrice);

            return sumOfOrders;
        }

        public static decimal SumOfOrdersByOrder(string CustomerID, string OrderID)
        {
            List<Order> selectedCustomerOrders = new();
            decimal sumOfItems = 0;

            DataAccess db = new DataAccess();
            selectedCustomerOrders = db.GetOrdersByCustomerID(CustomerID).ToList();
            //I feel I should be able to combine these into one, but...
            var items = selectedCustomerOrders.Where(x => x.OrderID == OrderID).ToList();
            sumOfItems = items.Sum(x => x.ExtendedPrice);

            return sumOfItems;
        }

        public static DateTime EarliestOrderDateByCustomerID(string CustomerID)
        {
            if (CustomerID != null)
            {
                List<Order> selectedCustomerOrders = new();
                DateTime earliestOrderDate = new();

                DataAccess db = new NorthwindLibrary.DataAccess();
                selectedCustomerOrders = db.GetOrdersByCustomerID(CustomerID).ToList();

                earliestOrderDate = selectedCustomerOrders.Min(x => x.OrderDate);

                return earliestOrderDate;
            }
            else return DateTime.Today;

        }

        public static DateTime LatestOrderDateByCustomerID(string CustomerID)
        {
            if (CustomerID != null)
            {
                List<Order> selectedCustomerOrders = new();
                DateTime latestOrderDate = new();

                DataAccess db = new NorthwindLibrary.DataAccess();
                selectedCustomerOrders = db.GetOrdersByCustomerID(CustomerID).ToList();

                latestOrderDate = selectedCustomerOrders.Max(x => x.OrderDate);

                return latestOrderDate;
            }
            else return DateTime.Today;
        }

        public static List<Order> OrdersByCustIDAndDateFilter(List<Order> CustOrderList, Customer SelectedCustomer, DateTime EarliestDate, DateTime LatestDate)
        {
            var earlyFilteredOrders = CustOrderList.Where(x => x.OrderDate > EarliestDate).ToList();
            var filteredOrders = earlyFilteredOrders.Where(x => x.OrderDate < LatestDate).ToList();
            return filteredOrders;
        }
    }
}
