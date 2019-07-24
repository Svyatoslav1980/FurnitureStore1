using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FurnitureStore.Models
{
    public class Delivery
    {
        [Key]
        public int DeliveryID { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DeliveryAdress { get; set; }
        public string DeliveryCity { get; set; }
        public decimal DeliveryPrice { get; set; }
    }
}