using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FurnitureStore.Models
{
    public class OrderProduct
    {
        [Key]
        public int OrderProductID { get; set; }
        public int OrderID { get; set; }
        public short ProductID { get; set; }
        public short ProductCount { get; set; }
    }
}