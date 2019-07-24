using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FurnitureStore.Models
{
    public class Client
    {
        public int ClientID { get; set; }

        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("Phone Nr")]
        public string PhoneNr { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }
        public string UserName { get; set; }
    }
}