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
    public partial class OrderDetailsForm : Form
    {
        public OrderDetailsForm(Customer customer, Order order)
        {
            InitializeComponent();
            RefreshOrderFields(customer, order);
            UpdateItemsList(customer, order);
        }

        private void RefreshOrderFields(Customer customer, Order order)
        {
            if (customer != null && order !=null)
            {
                customerNameLabel.Text = $"Order {order.OrderID} from {customer.customerDisplayName}";
                orderIDTextBox.Text = order.OrderID;
                employeeIDTextBox.Text = order.EmployeeID;
                orderedDateTextBox.Text = order.OrderDate.ToString("dd/MM/yyyy");
                shippedDateTextBox.Text = order.ShippedDate.ToString("dd/MM/yyyy");
                thisOrderValueTextBox.Text = order.SumOfOrder.ToString("C"); 
                orderSumTextBox.Text = order.SumOfOrder.ToString("C");
                allOrdersValueTextBox.Text = customer.OrdersToDate.ToString("C");

                shippingAdressTextBox.Text = order.ShipAddress;
                shippingCityTextBox.Text = order.ShipCity;
                shippingRegionTextBox.Text = order.ShipRegion;
                shippingPostCodeTextBox.Text = order.ShipPostalCode;
                shippingCountryTextBox.Text = order.ShipCountry;

                //UpdateItemssList();

            }
            else
            {
                customerNameLabel.Text = "";
                orderIDTextBox.Text = "";
                employeeIDTextBox.Text = "";
                orderDateLabel.Text = "";
                shippedDateTextBox.Text = "";
                thisOrderValueTextBox.Text = "";
                allOrdersValueTextBox.Text = "";
                orderSumTextBox.Text = "";

                shippingAdressTextBox.Text = "";
                shippingCityTextBox.Text = "";
                shippingRegionTextBox.Text = "";
                shippingPostCodeTextBox.Text = "";
                shippingCountryTextBox.Text = "";
            }
        }


        private void UpdateItemsList(Customer customer, Order order)
        {
            DataAccess db = new DataAccess();
            var itemsList = db.GetOrdersByCustomerID(customer.CustomerID).Where(x => x.OrderID == order.OrderID);

            var columns = from selectedOrder in itemsList //ordersBySelectedCustomer
                          orderby order.ProductID
                          select new
                          {
                              OrderID = selectedOrder.OrderID,
                              ProductID = selectedOrder.ProductID,
                              ProductName = selectedOrder.ProductName,
                              Qty = selectedOrder.Quantity,
                              UnitPrice = selectedOrder.UnitPrice.ToString("C"),
                              ExtendedPrice = selectedOrder.ExtendedPrice.ToString("C"),
                          };
            orderItemsDataGridView.DataSource = columns.ToList();

            //orderItemsDataGridView.Refresh();
        }
    }
}
