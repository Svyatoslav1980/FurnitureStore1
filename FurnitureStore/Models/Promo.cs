using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FurnitureStore.Models
{
    public class Promo
    {
        public System.Int16 PromoID { get; set; }
        public string PromoName { get; set; }
        public string PromoDescription { get; set; }
        public System.Int16 ProductID { get; set; }
        public System.Int16 DiscountPercentage { get; set; }
        public DateTime PromoStart { get; set; }
        public DateTime PromoFinish { get; set; }
        public string PromoImage { get; set; }

    }
}