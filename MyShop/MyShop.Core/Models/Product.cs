﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product
    {
        public string Id { get; set; }

        [StringLength(20)] //Validations
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0,1000)] //Validation for Price
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string IImage { get; set; }

        //Constructor
        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}