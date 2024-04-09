using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entities
{
    public class HomePage
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Definition { get; set; }
    }
}