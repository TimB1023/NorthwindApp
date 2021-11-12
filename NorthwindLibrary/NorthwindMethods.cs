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
            DataAccess db = new DataAccess();
            selectedCustomerOrders = db.GetOrdersByCustomerID(CustomerID).ToList();

            //Old version for reference and to highlight efficiency of Lambda method
            //foreach(Order order in selectedCustomerOrders)
            //{
            //    sumOfOrders += order.ExtendedPrice;
            //}
            return selectedCustomerOrders.Sum(x => x.ExtendedPrice);
        }
        public static decimal SumOfOrdersByOrder(string CustomerID, string OrderID)
        {
            List<Order> selectedCustomerOrders = new();
            DataAccess db = new DataAccess();
            selectedCustomerOrders = db.GetOrdersByCustomerID(CustomerID).ToList();
            //I feel I should be able to combine these into one, but...
            var items = selectedCustomerOrders.Where(x => x.OrderID == OrderID).ToList();
            return items.Sum(x => x.ExtendedPrice);
        }
        public static DateTime EarliestOrderDateInDB()
        {
            List<Order> allCustomerOrders = new();
            DataAccess db = new DataAccess();
            allCustomerOrders = db.GetAllOrderDates().ToList();
            return allCustomerOrders.Min(x => x.OrderDate);
        }
        public static DateTime LatestOrderDateInDB()
        {
                List<Order> allCustomerOrders = new();
                DataAccess db = new DataAccess();
                allCustomerOrders = db.GetAllOrderDates().ToList();
                return allCustomerOrders.Max(x => x.OrderDate);
        }
        public static DateTime EarliestOrderDateByCustomerID(string CustomerID)
        {
            if (CustomerID != null)
            {
                List<Order> selectedCustomerOrders = new();
                DataAccess db = new DataAccess();
                selectedCustomerOrders = db.GetOrdersByCustomerID(CustomerID).ToList();
                return selectedCustomerOrders.Min(x => x.OrderDate);
            }
            else return DateTime.Today; //shouldn't ever reach this as there should always be a selected customer when called
        }
        public static DateTime LatestOrderDateByCustomerID(string CustomerID)
        {
            if (CustomerID != null)
            {
                List<Order> selectedCustomerOrders = new();
                DataAccess db = new DataAccess();
                selectedCustomerOrders = db.GetOrdersByCustomerID(CustomerID).ToList();
                return selectedCustomerOrders.Max(x => x.OrderDate);
            }
            else return DateTime.Today; //shouldn't ever reach this
        }
        public static List<Order> OrdersByCustIDAndDateFilter(List<Order> CustOrderList, Customer SelectedCustomer, DateTime EarliestDate, DateTime LatestDate)
        {
            // Grouping needed as the grain of the database is at the order row level, not
            // order. This means that each order number could occur several times
            return CustOrderList.Where(x => x.OrderDate >= EarliestDate && x.OrderDate <= LatestDate).GroupBy(x => x.OrderID).Select(group => group.First()).ToList();
        }
    }
}
