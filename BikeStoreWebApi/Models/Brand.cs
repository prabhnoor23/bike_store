﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
// This is the brand page
using System;
using System.Collections.Generic;

namespace BikeStores.MSSQL.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}