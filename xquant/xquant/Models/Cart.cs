﻿namespace xquant.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
