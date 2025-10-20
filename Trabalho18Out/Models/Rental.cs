﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho18Out.Abstracts;

namespace Trabalho18Out.Models
{
    public class Rental
    {
        private Guid Id { get; set; } = Guid.NewGuid();
        private Person Customer { get; set; }
        private Vehicle Vehicle { get; set; }

        private DateTime RentalDate { get; set; } = DateTime.Now;
        private DateTime? ReturnDate { get; set; } = null;
        private double? TotalPrice { get; set; } = null;

        public Rental
            (
            Person customer, 
            Vehicle vehicle
            )
        {
            Customer = customer;
            Vehicle = vehicle;
        }
    }
}
