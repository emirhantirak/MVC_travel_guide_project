using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entities
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Definition { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}