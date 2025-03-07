﻿namespace StockManagement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public OrderType OrderType { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal Tax { get; set; }
        public decimal ShippingCharges { get; set; }
        public decimal TotalCharges { get; set;}
        public string PromoCode { get; set; }
        public decimal Discount { get; set;}
        public decimal GrandTotal { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public DateTime UpdatedAt { get; set; }

    }

}

namespace StockManagement
{
    public enum OrderType
    {
        PurchaseOrder, CustomerOrder
    }

    public enum OrderStatus
    {
        CheckOut,Paid,Failed,Shipped,Delivered,Returned,Complete
    }
}