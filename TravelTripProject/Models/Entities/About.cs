using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entities
{
    public class About
    {
        [Key]
        public int ID { get; set; }
        public string ImageUrl { get; set; }
        public string Definition { get; set; }
    }
}