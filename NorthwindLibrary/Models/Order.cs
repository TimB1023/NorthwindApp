using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLibrary
{
    public class Order
    {
        public decimal ExtendedPrice { get; set; }
        public double Discount { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductName { get; set; }
        public string ProductID { get; set; }
        public string CustomerID { get; set; }
        public string EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipVia { get; set; }
        public string Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipCountry { get; set; }
        public string ShipPostalCode { get; set; }
        public string OrderID { get; set; } //Int in db
        public decimal SumOfOrder => NorthwindMethods.SumOfOrdersByOrder(CustomerID, OrderID);
        public decimal LineItemCountOfOrder => NorthwindMethods.CountOfItemsByOrder(CustomerID, OrderID);

    }
}
