﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesDatabase.Data.Models
{
    public class Customer
    {
        public Customer()
        {
            this.Sales = new HashSet<Sale>();
        }

        public int CustomerId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(80)]
        public string Email { get; set; }

        public string CreditCardNumber  { get; set; }

        public ICollection<Sale> Sales  { get; set; }
    }
}
