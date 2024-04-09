using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entities
{
    public class AddressBlog
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Definition { get; set; }
        public string AddressDetail { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
    }
}