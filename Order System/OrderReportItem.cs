using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_System
{
    public class OrderReportItem
    {
        public string OrderCustomerId { get; set; }

        public string OrderCustomerName { get; set; }
            
        public double OrderCustomerPaymentAmout { get; set; }
        
        public int OrderNumber { set; get; }

        public string OrderDate { set; get; }

        public string OrderProductId { set; get; }   

        public decimal OrderQuantity { set; get; }

        public string UnitOfMeasurement { set; get; }

        public decimal OrderPrice { set; get; }

        public OrderReportItem()
        {
        }
        public OrderReportItem ( string orderCustomerId, string orderCustomerName, double orderCustomerPaymentAmount, int orderNumber, string orderDate, string orderProductId, decimal orderQuantity, string unitOfMeasurement, decimal orderPrice)
        {
            this.OrderCustomerId = orderCustomerId;
            this.OrderCustomerName = orderCustomerName;
            this.OrderCustomerPaymentAmout = orderCustomerPaymentAmount;
            this.OrderNumber = orderNumber;
            this.OrderDate =  orderDate;
            this.OrderProductId = orderProductId;   
            this.OrderQuantity = orderQuantity;
            this.UnitOfMeasurement = unitOfMeasurement;
            this.OrderPrice = orderPrice;
        }
    }
}
