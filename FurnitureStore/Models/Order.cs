using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FurnitureStore.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int ClientID { get; set; }
        public int DeliveryID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderSum { get; set; }
    }
}