using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC1ejemplo.Models
{
    public class RestaurantReview
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public int Rating { get; set; }
    }
}