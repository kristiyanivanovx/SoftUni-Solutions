﻿using System;

namespace SalesDatabase.Data.Models
{
    public class Sale
    {
        public int SaleId { get; set; }

        public DateTime Date => DateTime.UtcNow;

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int StoreId { get; set; }

        public Store Store { get; set; }
    }
}
