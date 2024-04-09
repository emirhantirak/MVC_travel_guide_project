using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entities
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Commnt { get; set; }
        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }
    }
}