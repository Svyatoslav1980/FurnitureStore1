using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FurnitureStore.Models
{
    public class SubCategory
    {
        public Int16 SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        public Int16 CategoryID { get; set; }
        public string SubCategoryImage { get; set; }
    }
}