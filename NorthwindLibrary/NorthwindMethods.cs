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


    }
}
