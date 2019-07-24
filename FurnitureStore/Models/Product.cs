using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FurnitureStore.Models
{
    public class Product
    {
        public System.Int16 ProductID { get; set; }
        public string ProductName { get; set; }
        public System.Int16 SubCategoryID { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int NumberOfProduct { get; set; }
        public System.Int16 ProductHeight { get; set; }
        public System.Int16 ProductWidth { get; set; }
        public System.Int16 ProductLenght { get; set; }
        public System.Int16 ProductGrossWeight { get; set; }
        public System.Int16 ProductNetWeight { get; set; }
        public string ProductImage { get; set; }
        public string ProductColor { get; set; }
    }
}