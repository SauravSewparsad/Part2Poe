//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Part2Poe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Nullable<int> ProductQuantity { get; set; }
        public Nullable<decimal> ProductPrice { get; set; }
        public string ProductDate { get; set; }
        public Nullable<int> FarmerId { get; set; }
    
        public virtual Farmer Farmer { get; set; }
    }
}
